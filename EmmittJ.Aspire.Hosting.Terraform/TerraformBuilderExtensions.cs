// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform code generation to Aspire resources.
/// </summary>
public static class TerraformBuilderExtensions
{
    /// <summary>
    /// Adds a Terraform stack as a child resource of the specified parent resource.
    /// The stack will be registered as a separate resource in the application model.
    /// </summary>
    /// <typeparam name="T">The parent resource type.</typeparam>
    /// <param name="builder">The parent resource builder.</param>
    /// <param name="stackName">The name of the Terraform stack (will be used as part of the resource name).</param>
    /// <param name="configureStack">Optional action to configure the Terraform stack with providers, resources, etc.</param>
    /// <returns>A resource builder for the newly created <see cref="TerraformStackResource"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="builder"/> or <paramref name="stackName"/> is null.</exception>
    public static IResourceBuilder<TerraformStackResource> AddTerraformStack<T>(
        this IResourceBuilder<T> builder,
        string stackName,
        Action<TerraformStack>? configureStack = null)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(stackName);

        // Ensure the eventing subscriber is registered
        builder.ApplicationBuilder.Services.TryAddEventingSubscriber<TerraformEventingSubscriber>();

        // Create the stack
        var stack = new TerraformStack(stackName);
        configureStack?.Invoke(stack);

        // Create the resource with a unique name
        var resourceName = $"{builder.Resource.Name}-{stackName}";
        var stackResource = new TerraformStackResource(resourceName, builder.Resource, stack);

        // Add resource to application model
        var stackBuilder = builder.ApplicationBuilder.AddResource(stackResource);

        // Create Aspire parameters for Terraform variables
        ProcessTerraformVariables(stackBuilder);

        return stackBuilder;
    }

    /// <summary>
    /// Adds a Terraform stack as a child resource of the specified parent resource.
    /// Returns the parent builder to allow method chaining.
    /// </summary>
    /// <typeparam name="T">The parent resource type.</typeparam>
    /// <param name="builder">The parent resource builder.</param>
    /// <param name="stackName">The name of the Terraform stack (will be used as part of the resource name).</param>
    /// <param name="configureStack">Optional action to configure the Terraform stack with providers, resources, etc.</param>
    /// <returns>The parent resource builder for chaining.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="builder"/> or <paramref name="stackName"/> is null.</exception>
    public static IResourceBuilder<T> WithTerraformStack<T>(
        this IResourceBuilder<T> builder,
        string stackName,
        Action<TerraformStack>? configureStack = null)
        where T : IResource
    {
        AddTerraformStack(builder, stackName, configureStack);
        return builder;
    }

    /// <summary>
    /// Sets the working directory for Terraform file generation on the parent resource.
    /// This applies to all Terraform stacks associated with the resource.
    /// </summary>
    /// <typeparam name="T">The resource type.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="workingDirectory">The working directory path where Terraform files will be generated.</param>
    /// <returns>The resource builder for chaining.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="builder"/> or <paramref name="workingDirectory"/> is null.</exception>
    public static IResourceBuilder<T> WithTerraformWorkingDirectory<T>(
        this IResourceBuilder<T> builder,
        string workingDirectory)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(workingDirectory);

        var annotation = builder.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        if (annotation is null)
        {
            annotation = new TerraformConfigurationAnnotation
            {
                WorkingDirectory = workingDirectory
            };
            builder.WithAnnotation(annotation);
        }
        else
        {
            annotation.WorkingDirectory = workingDirectory;
        }

        return builder;
    }

    private static void ProcessTerraformVariables(IResourceBuilder<TerraformStackResource> stackBuilder)
    {
        // Get all TerraformVariable constructs from the stack
        var variables = stackBuilder.Resource.Stack.Constructs.OfType<TerraformVariable>();

        foreach (var variable in variables)
        {
            // Create an Aspire parameter for each Terraform variable
            // Replace underscores with hyphens to comply with Aspire's resource naming rules
            // TODO: probably need to rethink how variables are mapped to parameters
            var parameterName = $"{stackBuilder.Resource.Name}-{variable.Name}".Replace('_', '-');
            stackBuilder.ApplicationBuilder.AddParameter(parameterName);
        }
    }
}
