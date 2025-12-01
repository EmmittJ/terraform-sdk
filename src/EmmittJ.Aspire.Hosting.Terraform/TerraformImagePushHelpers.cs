// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIREPIPELINES003

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Helper methods for pushing container images to Terraform-managed registries.
/// </summary>
internal static class TerraformImagePushHelpers
{
    /// <summary>
    /// Pushes a container image to the specified registry.
    /// </summary>
    /// <param name="registry">The container registry to push to.</param>
    /// <param name="resource">The resource whose image should be pushed.</param>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="containerImageBuilder">The container image builder service.</param>
    public static async Task PushImageToRegistryAsync(
        IContainerRegistry registry,
        IResource resource,
        PipelineStepContext context,
        IResourceContainerImageBuilder containerImageBuilder)
    {
        var registryEndpoint = await registry.Endpoint.GetValueAsync(context.CancellationToken).ConfigureAwait(false) ??
            throw new InvalidOperationException("Failed to retrieve container registry endpoint.");

        // Get the local image name (defaults to resource name)
        if (!resource.TryGetContainerImageName(out var localImageName))
        {
            localImageName = resource.Name.ToLowerInvariant();
        }

        // Get the target tag using ContainerImageReference
        IValueProvider cir = new ContainerImageReference(resource);
        var targetTag = await cir.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

        var pushTask = await context.ReportingStep.CreateTaskAsync(
            $"Pushing **{resource.Name}** to **{registryEndpoint}**",
            context.CancellationToken).ConfigureAwait(false);

        await using (pushTask.ConfigureAwait(false))
        {
            try
            {
                if (targetTag is null)
                {
                    throw new InvalidOperationException($"Failed to get target tag for {resource.Name}");
                }

                await TagAndPushImageAsync(localImageName, targetTag, context.CancellationToken, containerImageBuilder).ConfigureAwait(false);

                await pushTask.CompleteAsync(
                    $"Successfully pushed **{resource.Name}** to `{targetTag}`",
                    CompletionState.Completed,
                    context.CancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await pushTask.CompleteAsync(
                    $"Failed to push **{resource.Name}**: {ex.Message}",
                    CompletionState.CompletedWithError,
                    context.CancellationToken).ConfigureAwait(false);
                throw;
            }
        }
    }

    private static async Task TagAndPushImageAsync(
        string localTag,
        string targetTag,
        CancellationToken cancellationToken,
        IResourceContainerImageBuilder containerImageBuilder)
    {
        await containerImageBuilder.TagImageAsync(localTag, targetTag, cancellationToken).ConfigureAwait(false);
        await containerImageBuilder.PushImageAsync(targetTag, cancellationToken).ConfigureAwait(false);
    }
}
