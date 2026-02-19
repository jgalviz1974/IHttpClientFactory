namespace Gasolutions.Core.Interfaces.HttpClient
{
    /// <summary>
    /// Interface for creating HTTP clients.
    /// </summary>
    /// <typeparam name="T">The type of the Http client.</typeparam>
    public interface IHttpClientFactory<T>
    {
        /// <summary>
        /// Creates an instance of the HTTP client.
        /// </summary>
        /// <param name="url">The base URL for the API.</param>
        /// <returns>An instance of the HTTP client.</returns>
        T CreateClient(string url);
    }
}
