// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsumingWebsite.Clients.DataService
{
    using ConsumingWebsite.Clients;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataService.
    /// </summary>
    public static partial class DataServiceExtensions
    {
            /// <summary>
            /// Simple health check http endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetHealthCheck(this IDataService operations)
            {
                return operations.GetHealthCheckAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Simple health check http endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetHealthCheckAsync(this IDataService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHealthCheckWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all blog posts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<BlogPostModel> GetBlogPosts(this IDataService operations)
            {
                return operations.GetBlogPostsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all blog posts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BlogPostModel>> GetBlogPostsAsync(this IDataService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBlogPostsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a blog post by identifier.
            /// </summary>
            /// <remarks>
            /// As {404} is a valid response code, clients should return {null} for those
            /// responses instead of throwing an exception.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The identifier.
            /// </param>
            public static BlogPostModel GetBlogPostById(this IDataService operations, string id)
            {
                return operations.GetBlogPostByIdAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a blog post by identifier.
            /// </summary>
            /// <remarks>
            /// As {404} is a valid response code, clients should return {null} for those
            /// responses instead of throwing an exception.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BlogPostModel> GetBlogPostByIdAsync(this IDataService operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBlogPostByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all blog posts filtered by tag.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tag'>
            /// The tag to filter.
            /// </param>
            public static IList<BlogPostModel> GetBlogPostsByTag(this IDataService operations, string tag)
            {
                return operations.GetBlogPostsByTagAsync(tag).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all blog posts filtered by tag.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tag'>
            /// The tag to filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BlogPostModel>> GetBlogPostsByTagAsync(this IDataService operations, string tag, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBlogPostsByTagWithHttpMessagesAsync(tag, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
