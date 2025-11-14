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
public class AzurermApiManagementDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_api_management.
/// </summary>
public class AzurermApiManagementDataSource : TerraformDataSource
{
    public AzurermApiManagementDataSource(string name) : base("azurerm_api_management", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    [TerraformArgument("additional_location")]
    public TerraformList<object> AdditionalLocation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "additional_location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformArgument("developer_portal_url")]
    public TerraformValue<string> DeveloperPortalUrl
    {
        get => new TerraformReference<string>(this, "developer_portal_url");
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformArgument("gateway_regional_url")]
    public TerraformValue<string> GatewayRegionalUrl
    {
        get => new TerraformReference<string>(this, "gateway_regional_url");
    }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformArgument("gateway_url")]
    public TerraformValue<string> GatewayUrl
    {
        get => new TerraformReference<string>(this, "gateway_url");
    }

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    [TerraformArgument("hostname_configuration")]
    public TerraformList<object> HostnameConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "hostname_configuration").ResolveNodes(ctx));
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
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformArgument("management_api_url")]
    public TerraformValue<string> ManagementApiUrl
    {
        get => new TerraformReference<string>(this, "management_api_url");
    }

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformArgument("notification_sender_email")]
    public TerraformValue<string> NotificationSenderEmail
    {
        get => new TerraformReference<string>(this, "notification_sender_email");
    }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformArgument("portal_url")]
    public TerraformValue<string> PortalUrl
    {
        get => new TerraformReference<string>(this, "portal_url");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("private_ip_addresses")]
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string> PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("public_ip_addresses")]
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [TerraformArgument("publisher_email")]
    public TerraformValue<string> PublisherEmail
    {
        get => new TerraformReference<string>(this, "publisher_email");
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [TerraformArgument("publisher_name")]
    public TerraformValue<string> PublisherName
    {
        get => new TerraformReference<string>(this, "publisher_name");
    }

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformArgument("scm_url")]
    public TerraformValue<string> ScmUrl
    {
        get => new TerraformReference<string>(this, "scm_url");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    [TerraformArgument("tenant_access")]
    public TerraformList<object> TenantAccess
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "tenant_access").ResolveNodes(ctx));
    }

}
