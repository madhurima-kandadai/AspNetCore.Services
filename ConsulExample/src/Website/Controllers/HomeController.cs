using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DnsClient;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDnsQuery _dns;

        public HomeController(IDnsQuery dns)
        {
            _dns = dns ?? throw new ArgumentNullException(nameof(dns));
        }

        public async Task<IActionResult> Index()
        {
            var model = new IndexViewModel()
            {
                DnsResult = await _dns.ResolveServiceAsync("service.consul", "dataservice")
            };

            if (model.DnsResult.Length > 0)
            {
                var firstAddress = model.DnsResult.First().AddressList.FirstOrDefault();
                var port = model.DnsResult.First().Port;
                using (var client = new HttpClient())
                {
                    model.ServiceResult = await client.GetStringAsync($"http://{firstAddress}:{port}/Values");
                    model.Host = firstAddress.ToString();
                    model.Port = port.ToString();
                }
            }

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }

    public class IndexViewModel
    {
        public ServiceHostEntry[] DnsResult { get; set; }

        public string ServiceResult { get; set; }

        public string Host { get; set; }

        public string Port { get; set; }
    }
}