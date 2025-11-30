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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoScaleProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auto_scale_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformValue<string> AutomaticUpgradeChannel
    {
        get => new TerraformReference<string>(this, "automatic_upgrade_channel");
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
    }

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformValue<string> DataplaneApiEndpoint
    {
        get => new TerraformReference<string>(this, "dataplane_api_endpoint");
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DiagnoseSupportEnabled
    {
        get => new TerraformReference<bool>(this, "diagnose_support_enabled");
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPrivate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "frontend_private").ResolveNodes(ctx));
    }

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FrontendPublic
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "frontend_public").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> LoggingStorageAccount
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logging_storage_account").ResolveNodes(ctx));
    }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ManagedResourceGroup
    {
        get => new TerraformReference<string>(this, "managed_resource_group");
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_interface").ResolveNodes(ctx));
    }

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformValue<string> NginxVersion
    {
        get => new TerraformReference<string>(this, "nginx_version");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebApplicationFirewall
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "web_application_firewall").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxDeploymentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxDeploymentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
