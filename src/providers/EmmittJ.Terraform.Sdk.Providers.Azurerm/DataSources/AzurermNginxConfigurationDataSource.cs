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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => GetArgument<TerraformValue<string>>("nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ConfigFile
        => AsReference("config_file");

    /// <summary>
    /// The package_data attribute.
    /// </summary>
    public TerraformValue<string> PackageData
        => AsReference("package_data");

    /// <summary>
    /// The protected_file attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ProtectedFile
        => AsReference("protected_file");

    /// <summary>
    /// The root_file attribute.
    /// </summary>
    public TerraformValue<string> RootFile
        => AsReference("root_file");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
