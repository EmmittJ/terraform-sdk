// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable ASPIREPIPELINES004 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Utility methods for working with publishing context and output paths in Terraform environments.
/// </summary>
internal static class PublishingContextUtils
{
    /// <summary>
    /// Gets the correct output path for the Terraform environment, respecting the pipeline's output service.
    /// </summary>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="environment">The Terraform environment resource.</param>
    /// <returns>The absolute path where Terraform files should be written.</returns>
    public static string GetEnvironmentOutputPath(PipelineStepContext context, TerraformEnvironmentResource environment)
    {
        var outputService = context.Services.GetRequiredService<IPipelineOutputService>();

        // Check if there are multiple Terraform environments
        var terraformEnvironments = context.Model.Resources.OfType<TerraformEnvironmentResource>().ToList();

        var basePath = terraformEnvironments.Count > 1
            ? outputService.GetOutputDirectory(environment)
            : outputService.GetOutputDirectory();

        // If the environment has a custom OutputPath configured, use it; otherwise default to the environment name
        var outputPath = !string.IsNullOrEmpty(environment.OutputPath)
            ? environment.OutputPath
            : environment.Name;

        return Path.Combine(basePath, outputPath);
    }

    /// <summary>
    /// Gets the output path for a specific resource, respecting both environment and resource-level configuration.
    /// </summary>
    /// <param name="context">The pipeline step context.</param>
    /// <param name="environment">The Terraform environment resource.</param>
    /// <param name="resource">The resource being processed.</param>
    /// <returns>The absolute path where Terraform files for this resource should be written.</returns>
    public static string GetResourceOutputPath(PipelineStepContext context, TerraformEnvironmentResource environment, IResource resource)
    {
        // Start with the environment base path
        var basePath = GetEnvironmentOutputPath(context, environment);

        // Check if the resource has a custom OutputPath configured
        var configAnnotation = resource.Annotations.OfType<TerraformConfigurationAnnotation>().FirstOrDefault();
        if (configAnnotation?.OutputPath != null)
        {
            // If absolute path is provided, use it directly; otherwise combine with base
            return Path.IsPathRooted(configAnnotation.OutputPath)
                ? configAnnotation.OutputPath
                : Path.Combine(basePath, configAnnotation.OutputPath);
        }

        // Default: create a subdirectory for this resource
        return Path.Combine(basePath, resource.Name);
    }
}
