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
public class AzurermNginxDeploymentDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_nginx_deployment.
/// </summary>
public class AzurermNginxDeploymentDataSource : TerraformDataSource
{
    public AzurermNginxDeploymentDataSource(string name) : base("azurerm_nginx_deployment", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNginxDeploymentDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    [TerraformArgument("auto_scale_profile")]
    public TerraformList<object> AutoScaleProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "auto_scale_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformArgument("automatic_upgrade_channel")]
    public TerraformValue<string> AutomaticUpgradeChannel
    {
        get => new TerraformReference<string>(this, "automatic_upgrade_channel");
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
    }

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    [TerraformArgument("dataplane_api_endpoint")]
    public TerraformValue<string> DataplaneApiEndpoint
    {
        get => new TerraformReference<string>(this, "dataplane_api_endpoint");
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    [TerraformArgument("diagnose_support_enabled")]
    public TerraformValue<bool> DiagnoseSupportEnabled
    {
        get => new TerraformReference<bool>(this, "diagnose_support_enabled");
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformArgument("email")]
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    [TerraformArgument("frontend_private")]
    public TerraformList<object> FrontendPrivate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "frontend_private").ResolveNodes(ctx));
    }

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    [TerraformArgument("frontend_public")]
    public TerraformList<object> FrontendPublic
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "frontend_public").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformArgument("ip_address")]
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    [TerraformArgument("logging_storage_account")]
    public TerraformList<object> LoggingStorageAccount
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "logging_storage_account").ResolveNodes(ctx));
    }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [TerraformArgument("managed_resource_group")]
    public TerraformValue<string> ManagedResourceGroup
    {
        get => new TerraformReference<string>(this, "managed_resource_group");
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformArgument("network_interface")]
    public TerraformList<object> NetworkInterface
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_interface").ResolveNodes(ctx));
    }

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    [TerraformArgument("nginx_version")]
    public TerraformValue<string> NginxVersion
    {
        get => new TerraformReference<string>(this, "nginx_version");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    [TerraformArgument("web_application_firewall")]
    public TerraformList<object> WebApplicationFirewall
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "web_application_firewall").ResolveNodes(ctx));
    }

}
