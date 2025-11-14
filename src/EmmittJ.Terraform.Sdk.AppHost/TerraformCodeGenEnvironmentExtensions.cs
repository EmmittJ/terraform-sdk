using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Extension methods for adding Terraform code generation environment.
/// </summary>
public static class TerraformCodeGenEnvironmentExtensions
{
    internal static IDistributedApplicationBuilder AddTerraformCodeGenInfrastructureCore(
        this IDistributedApplicationBuilder builder)
    {
        builder.Services.TryAddEventingSubscriber<TerraformCodeGenInfrastructure>();

        // Register code generation services
        builder.Services.AddTerraformCodeGeneration(builder.Configuration);

        return builder;
    }

    /// <summary>
    /// Adds a Terraform code generation environment to the application model.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the environment resource.</param>
    /// <returns>A resource builder for the Terraform code generation environment.</returns>
    public static IResourceBuilder<TerraformCodeGenEnvironmentResource> AddTerraformCodeGenEnvironment(
        this IDistributedApplicationBuilder builder,
        string name = "terraform-codegen")
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        builder.AddTerraformCodeGenInfrastructureCore();

        var resource = new TerraformCodeGenEnvironmentResource(name);

        if (builder.ExecutionContext.IsRunMode)
        {
            // Don't surface as a resource in run mode
            return builder.CreateResourceBuilder(resource);
        }

        return builder.AddResource(resource);
    }

    /// <summary>
    /// Sets the output directory for generated provider code.
    /// </summary>
    public static IResourceBuilder<TerraformCodeGenEnvironmentResource> WithOutputDirectory(
        this IResourceBuilder<TerraformCodeGenEnvironmentResource> builder,
        string outputDirectory)
    {
        builder.Resource.OutputDirectory = outputDirectory;
        return builder;
    }

    /// <summary>
    /// Sets the working directory for Terraform operations.
    /// </summary>
    public static IResourceBuilder<TerraformCodeGenEnvironmentResource> WithWorkingDirectory(
        this IResourceBuilder<TerraformCodeGenEnvironmentResource> builder,
        string workingDirectory)
    {
        builder.Resource.WorkingDirectory = workingDirectory;
        return builder;
    }

    /// <summary>
    /// Sets the base namespace for generated provider code.
    /// </summary>
    public static IResourceBuilder<TerraformCodeGenEnvironmentResource> WithNamespace(
        this IResourceBuilder<TerraformCodeGenEnvironmentResource> builder,
        string @namespace)
    {
        builder.Resource.Namespace = @namespace;
        return builder;
    }
}
