using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_configuration.
/// </summary>
public class AzurermNginxConfigurationDataSource : TerraformDataSource
{
    public AzurermNginxConfigurationDataSource(string name) : base("azurerm_nginx_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformArgument("nginx_deployment_id")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNginxConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    [TerraformArgument("config_file")]
    public TerraformSet<object> ConfigFile
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "config_file").ResolveNodes(ctx));
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    [TerraformArgument("package_data")]
    public TerraformValue<string> PackageData
    {
        get => new TerraformReference<string>(this, "package_data");
    }

    /// <summary>
    /// The protected_file attribute.
    /// </summary>
    [TerraformArgument("protected_file")]
    public TerraformSet<object> ProtectedFile
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "protected_file").ResolveNodes(ctx));
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    [TerraformArgument("root_file")]
    public TerraformValue<string> RootFile
    {
        get => new TerraformReference<string>(this, "root_file");
    }

}
