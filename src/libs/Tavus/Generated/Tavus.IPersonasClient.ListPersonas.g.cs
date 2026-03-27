#nullable enable

namespace Tavus
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// List Personas<br/>
        /// Returns a list of all personas.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.ListPersonasResponse> ListPersonasAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}