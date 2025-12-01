// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides utility methods for working with container registries during Terraform deployments.
/// </summary>
public static class TerraformRegistryHelpers
{
    /// <summary>
    /// Gets the fully qualified image name for pushing to a container registry.
    /// </summary>
    /// <param name="registry">The container registry.</param>
    /// <param name="imageName">The image name (without registry prefix).</param>
    /// <param name="tag">The image tag.</param>
    /// <returns>The fully qualified image name (e.g., "myregistry.azurecr.io/myapp:latest").</returns>
    public static string GetFullImageName(IContainerRegistry registry, string imageName, string tag)
    {
        ArgumentNullException.ThrowIfNull(registry);
        ArgumentException.ThrowIfNullOrEmpty(imageName);
        ArgumentException.ThrowIfNullOrEmpty(tag);

        // Get the endpoint value - this may be a ReferenceExpression that needs to be resolved
        var endpoint = GetRegistryEndpointValue(registry);

        return $"{endpoint}/{imageName}:{tag}";
    }

    /// <summary>
    /// Gets the registry endpoint value from the container registry.
    /// </summary>
    /// <param name="registry">The container registry.</param>
    /// <returns>The endpoint URL string.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the endpoint cannot be resolved.</exception>
    public static string GetRegistryEndpointValue(IContainerRegistry registry)
    {
        ArgumentNullException.ThrowIfNull(registry);

        if (registry is TerraformContainerRegistryResource terraformRegistry)
        {
            var endpoint = terraformRegistry.EndpointOutput.Value;
            if (string.IsNullOrEmpty(endpoint))
            {
                throw new InvalidOperationException(
                    $"Registry endpoint not available for '{terraformRegistry.Name}'. " +
                    "Ensure terraform apply has completed and the 'endpoint' output is defined.");
            }
            return endpoint;
        }

        throw new InvalidOperationException(
            $"Unsupported registry type '{registry.GetType().Name}'. Expected TerraformContainerRegistryResource.");
    }

    /// <summary>
    /// Gets the registry name value from the container registry.
    /// </summary>
    /// <param name="registry">The container registry.</param>
    /// <returns>The registry name string.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the name cannot be resolved.</exception>
    public static string GetRegistryNameValue(IContainerRegistry registry)
    {
        ArgumentNullException.ThrowIfNull(registry);

        if (registry is TerraformContainerRegistryResource terraformRegistry)
        {
            var name = terraformRegistry.NameOutput.Value;
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidOperationException(
                    $"Registry name not available for '{terraformRegistry.Name}'. " +
                    "Ensure terraform apply has completed and the 'name' output is defined.");
            }
            return name;
        }

        throw new InvalidOperationException(
            $"Unsupported registry type '{registry.GetType().Name}'. Expected TerraformContainerRegistryResource.");
    }

    /// <summary>
    /// Logs registry information for debugging purposes.
    /// </summary>
    /// <param name="registry">The container registry.</param>
    /// <param name="logger">The logger to write to.</param>
    public static void LogRegistryInfo(IContainerRegistry registry, ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(registry);
        ArgumentNullException.ThrowIfNull(logger);

        if (registry is TerraformContainerRegistryResource terraformRegistry)
        {
            try
            {
                var name = terraformRegistry.NameOutput.Value;
                var endpoint = terraformRegistry.EndpointOutput.Value;
                logger.LogInformation("Container Registry: Name='{Name}', Endpoint='{Endpoint}'", name, endpoint);
            }
            catch (InvalidOperationException)
            {
                logger.LogWarning("Container Registry '{ResourceName}' outputs not yet available", terraformRegistry.Name);
            }
        }
        else
        {
            logger.LogInformation("Container Registry type: {RegistryType}", registry.GetType().Name);
        }
    }

    /// <summary>
    /// Ensures the registry is ready for use (outputs have been populated).
    /// </summary>
    /// <param name="registry">The container registry.</param>
    /// <exception cref="InvalidOperationException">Thrown when the registry is not ready.</exception>
    public static void EnsureRegistryReady(IContainerRegistry registry)
    {
        ArgumentNullException.ThrowIfNull(registry);

        if (registry is TerraformContainerRegistryResource terraformRegistry)
        {
            var hasName = !string.IsNullOrEmpty(terraformRegistry.NameOutput.Value);
            var hasEndpoint = !string.IsNullOrEmpty(terraformRegistry.EndpointOutput.Value);

            if (!hasName || !hasEndpoint)
            {
                throw new InvalidOperationException(
                    $"Registry '{terraformRegistry.Name}' is not ready. " +
                    $"Missing: {(hasName ? "" : "name ")}{(hasEndpoint ? "" : "endpoint")}. " +
                    "Ensure terraform apply has completed for the registry.");
            }
        }
    }
}
