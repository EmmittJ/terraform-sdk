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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoScaleProfile
        => CreateReference("auto_scale_profile");

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformValue<string> AutomaticUpgradeChannel
        => CreateReference("automatic_upgrade_channel");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => CreateReference("capacity");

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> DataplaneApiEndpoint
        => CreateReference("dataplane_api_endpoint");

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DiagnoseSupportEnabled
        => CreateReference("diagnose_support_enabled");

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPrivate
        => CreateReference("frontend_private");

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPublic
        => CreateReference("frontend_public");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => CreateReference("ip_address");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> LoggingStorageAccount
        => CreateReference("logging_storage_account");

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ManagedResourceGroup
        => CreateReference("managed_resource_group");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
        => CreateReference("network_interface");

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformValue<string> NginxVersion
        => CreateReference("nginx_version");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => CreateReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebApplicationFirewall
        => CreateReference("web_application_firewall");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxDeploymentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxDeploymentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
