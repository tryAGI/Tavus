#nullable enable

namespace Tavus
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// Create Objectives<br/>
        /// Creates a new objective for a persona.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavus.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Objectives> CreateObjectivesAsync(

            global::Tavus.CreateObjectivesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Objectives<br/>
        /// Creates a new objective for a persona.
        /// </summary>
        /// <param name="objectiveName"></param>
        /// <param name="objectivePrompt"></param>
        /// <param name="confirmationMode"></param>
        /// <param name="outputVariables"></param>
        /// <param name="modality"></param>
        /// <param name="nextConditionalObjectives"></param>
        /// <param name="nextRequiredObjective"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavus.Objectives> CreateObjectivesAsync(
            string? objectiveName = default,
            string? objectivePrompt = default,
            global::Tavus.CreateObjectivesRequestConfirmationMode? confirmationMode = default,
            global::System.Collections.Generic.IList<string>? outputVariables = default,
            string? modality = default,
            global::System.Collections.Generic.IList<global::Tavus.ConditionalObjective>? nextConditionalObjectives = default,
            string? nextRequiredObjective = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}