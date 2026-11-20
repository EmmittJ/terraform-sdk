// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules;

/// <summary>
/// Extension methods for wiring existing Terraform modules into an Aspire AppHost.
/// </summary>
public static class TerraformModuleExtensions
{
    /// <summary>
    /// Adds an existing Terraform configuration on disk. It is applied during deploy;
    /// in run mode it is not added to the model.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The resource name.</param>
    /// <param name="path">Directory containing the Terraform files, relative to the AppHost directory.</param>
    public static IResourceBuilder<TerraformModuleResource> AddTerraformModule(
        this IDistributedApplicationBuilder builder,
        string name,
        string path)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(path);

        var directory = Path.GetFullPath(path, builder.AppHostDirectory);

        if (builder.ExecutionContext.IsRunMode)
        {
            return builder.CreateResourceBuilder(new TerraformModuleResource(name, directory, deployable: false));
        }

        return builder.AddResource(new TerraformModuleResource(name, directory, deployable: true));
    }

    /// <summary>Passes a literal value to the module's Terraform variable.</summary>
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, string value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes an Aspire expression (endpoints, parameters, other outputs) to the module's Terraform variable.</summary>
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, ReferenceExpression value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes an Aspire parameter to the module's Terraform variable.</summary>
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, IResourceBuilder<ParameterResource> value)
        => builder.SetVariable(variableName, value.Resource);

    /// <summary>Passes another module's output to the module's Terraform variable.</summary>
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, TerraformModuleOutputReference value)
        => builder.SetVariable(variableName, value);

    /// <summary>Gets an Aspire value backed by one of the module's Terraform outputs.</summary>
    public static TerraformModuleOutputReference GetOutput(
        this IResourceBuilder<TerraformModuleResource> builder, string name)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        return new TerraformModuleOutputReference(name, builder.Resource);
    }

    private static IResourceBuilder<TerraformModuleResource> SetVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, object value)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(variableName);
        ArgumentNullException.ThrowIfNull(value);

        builder.Resource.SetVariable(variableName, value);
        return builder;
    }
}
