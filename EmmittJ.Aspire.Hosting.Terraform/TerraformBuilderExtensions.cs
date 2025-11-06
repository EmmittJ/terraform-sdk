// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Lifecycle;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

#pragma warning disable ASPIREPIPELINES001

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
        var stackBuilder = builder.ApplicationBuilder.AddResource(stackResource)
            .WithPipelineStepFactory(context => CreatePipelineSteps(stackResource, context));

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
    /// Configures Terraform generation settings for a resource or stack.
    /// </summary>
    /// <typeparam name="T">The resource type.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">An action to configure the Terraform settings.</param>
    /// <returns>The resource builder for chaining.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="builder"/> or <paramref name="configure"/> is null.</exception>
    public static IResourceBuilder<T> WithTerraformConfiguration<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformConfigurationAnnotation> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        var annotation = builder.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        if (annotation is null)
        {
            annotation = new TerraformConfigurationAnnotation();
            builder.WithAnnotation(annotation);
        }

        configure(annotation);
        return builder;
    }

    private static List<PipelineStep> CreatePipelineSteps(TerraformStackResource stackResource, PipelineStepFactoryContext context)
    {
        var validation = new PipelineStep
        {
            Name = $"terraform-validate-{stackResource.Name}",
            Resource = stackResource,
            Action = async stepContext => await ValidateTerraformStackAsync(stackResource, stepContext),
            Tags = { "terraform", "validation" }
        };

        var generate = new PipelineStep
        {
            Name = $"terraform-generate-{stackResource.Name}",
            Resource = stackResource,
            Action = async stepContext => await GenerateTerraformStackToFileAsync(stackResource, stepContext),
            Tags = { "terraform", "codegen" }
        };
        generate.DependsOn(validation);

        generate.RequiredBy(WellKnownPipelineSteps.Publish);

        return [validation, generate];
    }

    private static async Task ValidateTerraformStackAsync(TerraformStackResource stackResource, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var validateTask = await step.CreateTaskAsync($"Validating {stackResource.Name}", stepContext.CancellationToken);
        try
        {
            logger.LogInformation("Validating Terraform stack: {StackName}", stackResource.Stack.Name);

            var validationResult = stackResource.Stack.Validate();

            if (!validationResult.IsValid)
            {
                logger.LogError("❌ Validation failed for stack {StackName}", stackResource.Stack.Name);

                foreach (var error in validationResult.Errors)
                {
                    logger.LogError("  • {ErrorMessage}", error.Message);
                }

                await validateTask.FailAsync("Validation failed", stepContext.CancellationToken);
                throw new InvalidOperationException($"Terraform stack validation failed with {validationResult.Errors.Count} error(s). See logs for details.");
            }

            logger.LogInformation("✅ Validation passed for stack {StackName}", stackResource.Stack.Name);
            await validateTask.CompleteAsync("Validation passed", CompletionState.Completed, stepContext.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error validating Terraform stack {StackName}", stackResource.Stack.Name);
            await validateTask.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static async Task GenerateTerraformStackToFileAsync(TerraformStackResource stackResource, PipelineStepContext stepContext)
    {
        var logger = stepContext.Logger;
        var step = stepContext.ReportingStep;

        var initTask = await step.CreateTaskAsync($"Generating Terraform for {stackResource.Name}", stepContext.CancellationToken);
        try
        {
            logger.LogInformation("Starting Terraform generation for stack: {StackName}", stackResource.Stack.Name);

            // Determine the working directory using pipeline options and builder context
            var workingDirectory = GetWorkingDirectory(stackResource, stepContext);
            Directory.CreateDirectory(workingDirectory);

            logger.LogInformation("Writing Terraform files to: {WorkingDirectory}", workingDirectory);

            await initTask.CompleteAsync("Initialized", CompletionState.Completed, stepContext.CancellationToken);

            // Generate the HCL from the stack
            var generateTask = await step.CreateTaskAsync($"Compiling HCL", stepContext.CancellationToken);
            var hclContent = stackResource.Stack.ToHcl();
            await generateTask.CompleteAsync("HCL compiled", CompletionState.Completed, stepContext.CancellationToken);

            // Write the {stackName}.tf file
            var terraformFileName = $"{stackResource.Stack.Name}.tf";
            var writeTask = await step.CreateTaskAsync($"Writing {terraformFileName}", stepContext.CancellationToken);
            var terraformFilePath = Path.Combine(workingDirectory, terraformFileName);
            await File.WriteAllTextAsync(terraformFilePath, hclContent, stepContext.CancellationToken);

            var fullyQualifiedPath = Path.GetFullPath(terraformFilePath);
            logger.LogInformation("Generated Terraform file at {FilePath}", fullyQualifiedPath);
            await writeTask.CompleteAsync($"{terraformFileName} written", CompletionState.Completed, stepContext.CancellationToken);
            logger.LogInformation("✅ Terraform generation completed for {StackName}", stackResource.Stack.Name);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Error generating Terraform for stack {StackName}", stackResource.Stack.Name);
            await initTask.FailAsync(ex.Message, stepContext.CancellationToken);
            throw;
        }
    }

    private static string GetWorkingDirectory(TerraformStackResource stackResource, PipelineStepContext stepContext)
    {
        // First, check if the stack resource has its own TerraformConfigurationAnnotation (most specific)
        var stackAnnotation = stackResource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        if (stackAnnotation?.OutputDirectory is not null)
        {
            // Stack-specific output directory takes precedence
            return stackAnnotation.OutputDirectory;
        }

        // Second, check if the parent resource has a TerraformConfigurationAnnotation
        var parentAnnotation = stackResource.Parent.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        if (parentAnnotation?.OutputDirectory is not null)
        {
            // Parent's output directory - append stack name as subdirectory
            return Path.Combine(parentAnnotation.OutputDirectory, stackResource.Stack.Name);
        }

        // Third, check if PipelineOptions specifies an output path (similar to how Aspire's AzureBicepResource works)
        // This is typically set when publishing with --output-path
        var pipelineOptions = stepContext.Services.GetService<IOptions<PipelineOptions>>();

        if (pipelineOptions?.Value.OutputPath is not null)
        {
            // User explicitly provided an output path via CLI - append stack name as subdirectory
            return Path.Combine(pipelineOptions.Value.OutputPath, stackResource.Stack.Name);
        }

        // Default to a temporary directory (similar to Aspire's approach with Directory.CreateTempSubdirectory("aspire"))
        // In run mode, this allows the files to be inspected
        // In publish mode without --output-path, this keeps generated files separate
        return Path.Combine(Directory.GetCurrentDirectory(), ".terraform", stackResource.Stack.Name);
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
