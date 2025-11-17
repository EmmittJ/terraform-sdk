using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNginxConfigurationDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_nginx_configuration Terraform data source.
/// Retrieves information about a azurerm_nginx_configuration.
/// </summary>
public partial class AzurermNginxConfigurationDataSource(string name) : TerraformDataSource("azurerm_nginx_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ConfigFile
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "config_file").ResolveNodes(ctx));
    }

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformValue<string> PackageData
    {
        get => new TerraformReference<string>(this, "package_data");
    }

    /// <summary>
    /// The protected_file attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ProtectedFile
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "protected_file").ResolveNodes(ctx));
    }

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    public TerraformValue<string> RootFile
    {
        get => new TerraformReference<string>(this, "root_file");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
