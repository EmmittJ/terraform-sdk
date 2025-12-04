// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Helper methods for working with Aspire pipelines in Terraform environments.
/// </summary>
public static class TerraformPipelineHelpers
{
    /// <summary>
    /// Expands pipeline steps from a child resource into a parent's step collection.
    /// </summary>
    /// <param name="childResource">The child resource to expand steps from.</param>
    /// <param name="factoryContext">The pipeline step factory context.</param>
    /// <param name="steps">The list to add expanded steps to.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    /// <remarks>
    /// <para>
    /// This method iterates through all <see cref="PipelineStepAnnotation"/> instances on the child resource,
    /// creates steps using the child's context, and ensures each step has its <see cref="PipelineStep.Resource"/>
    /// property set to the child resource.
    /// </para>
    /// <para>
    /// This is useful for composite resources (like <c>TerraformAzureContainerAppEnvironmentResource</c>)
    /// that need to aggregate pipeline steps from multiple child resources.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// Annotations.Add(new PipelineStepAnnotation(async (factoryContext) =>
    /// {
    ///     var steps = new List&lt;PipelineStep&gt;();
    ///
    ///     await TerraformPipelineHelpers.ExpandChildStepsAsync(_containerRegistry, factoryContext, steps);
    ///     await TerraformPipelineHelpers.ExpandChildStepsAsync(_environment, factoryContext, steps);
    ///
    ///     return steps;
    /// }));
    /// </code>
    /// </example>
    public static async Task ExpandChildStepsAsync(
        IResource childResource,
        PipelineStepFactoryContext factoryContext,
        List<PipelineStep> steps)
    {
        ArgumentNullException.ThrowIfNull(childResource);
        ArgumentNullException.ThrowIfNull(factoryContext);
        ArgumentNullException.ThrowIfNull(steps);

        if (!childResource.TryGetAnnotationsOfType<PipelineStepAnnotation>(out var annotations))
        {
            return;
        }

        foreach (var annotation in annotations)
        {
            var childContext = new PipelineStepFactoryContext
            {
                PipelineContext = factoryContext.PipelineContext,
                Resource = childResource
            };

            var childSteps = await annotation.CreateStepsAsync(childContext).ConfigureAwait(false);

            foreach (var step in childSteps)
            {
                // Ensure each step has its resource set to the child
                step.Resource ??= childResource;
            }

            steps.AddRange(childSteps);
        }
    }

    /// <summary>
    /// Expands pipeline configuration from a child resource.
    /// </summary>
    /// <param name="childResource">The child resource to expand configuration from.</param>
    /// <param name="context">The pipeline configuration context.</param>
    /// <remarks>
    /// <para>
    /// This method iterates through all <see cref="PipelineConfigurationAnnotation"/> instances
    /// on the child resource and executes their callbacks with the provided context.
    /// </para>
    /// <para>
    /// This is useful for composite resources that need to aggregate pipeline configuration
    /// (like step dependencies) from multiple child resources.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// Annotations.Add(new PipelineConfigurationAnnotation(context =>
    /// {
    ///     TerraformPipelineHelpers.ExpandChildConfiguration(_containerRegistry, context);
    ///     TerraformPipelineHelpers.ExpandChildConfiguration(_environment, context);
    /// }));
    /// </code>
    /// </example>
    public static void ExpandChildConfiguration(
        IResource childResource,
        PipelineConfigurationContext context)
    {
        ArgumentNullException.ThrowIfNull(childResource);
        ArgumentNullException.ThrowIfNull(context);

        if (!childResource.TryGetAnnotationsOfType<PipelineConfigurationAnnotation>(out var annotations))
        {
            return;
        }

        foreach (var annotation in annotations)
        {
            annotation.Callback(context);
        }
    }
}
