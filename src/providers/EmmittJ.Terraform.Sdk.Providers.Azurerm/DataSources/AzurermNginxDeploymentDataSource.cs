using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNginxDeploymentDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_nginx_deployment Terraform data source.
/// Retrieves information about a azurerm_nginx_deployment.
/// </summary>
public partial class AzurermNginxDeploymentDataSource(string name) : TerraformDataSource("azurerm_nginx_deployment", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoScaleProfile
        => AsReference("auto_scale_profile");

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformValue<string> AutomaticUpgradeChannel
        => AsReference("automatic_upgrade_channel");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => AsReference("capacity");

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> DataplaneApiEndpoint
        => AsReference("dataplane_api_endpoint");

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DiagnoseSupportEnabled
        => AsReference("diagnose_support_enabled");

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => AsReference("email");

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPrivate
        => AsReference("frontend_private");

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPublic
        => AsReference("frontend_public");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> LoggingStorageAccount
        => AsReference("logging_storage_account");

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ManagedResourceGroup
        => AsReference("managed_resource_group");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
        => AsReference("network_interface");

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformValue<string> NginxVersion
        => AsReference("nginx_version");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebApplicationFirewall
        => AsReference("web_application_firewall");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxDeploymentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxDeploymentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
