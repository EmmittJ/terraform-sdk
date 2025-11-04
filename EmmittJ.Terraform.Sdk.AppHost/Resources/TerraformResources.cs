using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Terraform.Sdk.AppHost.Resources;

/// <summary>
/// Represents a Terraform provider that will have its resources and data sources generated.
/// </summary>
public sealed class TerraformProviderResource : Resource
{
    /// <summary>
    /// Gets the Terraform provider name (e.g., "aws", "azurerm").
    /// </summary>
    public string ProviderName { get; }

    /// <summary>
    /// Gets the version constraint for the provider (e.g., "~> 6.0").
    /// </summary>
    public string Version { get; }

    /// <summary>
    /// Gets or sets the C# namespace for the generated code.
    /// </summary>
    public string Namespace { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the output folder path for generated code.
    /// </summary>
    public string? OutputFolder { get; set; }

    /// <summary>
    /// Gets or sets the working directory for Terraform operations.
    /// </summary>
    public string? WorkingDirectory { get; set; }

    /// <summary>
    /// Gets or sets the template path for code generation.
    /// </summary>
    public string? TemplatePath { get; set; }

    public TerraformProviderResource(string name, string providerName, string version) : base(name)
    {
        ProviderName = providerName;
        Version = version;
    }
}

/// <summary>
/// Represents a generated Terraform resource class.
/// </summary>
public sealed class TerraformResourceResource : Resource
{
    /// <summary>
    /// Gets the parent provider resource.
    /// </summary>
    public TerraformProviderResource Provider { get; }

    /// <summary>
    /// Gets the Terraform resource type (e.g., "aws_instance").
    /// </summary>
    public string TerraformType { get; }

    /// <summary>
    /// Gets the generated C# class name.
    /// </summary>
    public string ClassName { get; }

    public TerraformResourceResource(string name, TerraformProviderResource provider, string terraformType, string className) 
        : base(name)
    {
        Provider = provider;
        TerraformType = terraformType;
        ClassName = className;
    }
}

/// <summary>
/// Represents a generated Terraform data source class.
/// </summary>
public sealed class TerraformDataSourceResource : Resource
{
    /// <summary>
    /// Gets the parent provider resource.
    /// </summary>
    public TerraformProviderResource Provider { get; }

    /// <summary>
    /// Gets the Terraform data source type (e.g., "aws_ami").
    /// </summary>
    public string TerraformType { get; }

    /// <summary>
    /// Gets the generated C# class name.
    /// </summary>
    public string ClassName { get; }

    public TerraformDataSourceResource(string name, TerraformProviderResource provider, string terraformType, string className) 
        : base(name)
    {
        Provider = provider;
        TerraformType = terraformType;
        ClassName = className;
    }
}
