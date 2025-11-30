using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management Terraform data source.
/// Retrieves information about a azurerm_api_management.
/// </summary>
public partial class AzurermApiManagementDataSource(string name) : TerraformDataSource("azurerm_api_management", name)
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdditionalLocation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "additional_location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformValue<string> DeveloperPortalUrl
    {
        get => new TerraformReference<string>(this, "developer_portal_url");
    }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayRegionalUrl
    {
        get => new TerraformReference<string>(this, "gateway_regional_url");
    }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayUrl
    {
        get => new TerraformReference<string>(this, "gateway_url");
    }

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HostnameConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hostname_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformValue<string> ManagementApiUrl
    {
        get => new TerraformReference<string>(this, "management_api_url");
    }

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformValue<string> NotificationSenderEmail
    {
        get => new TerraformReference<string>(this, "notification_sender_email");
    }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformValue<string> PortalUrl
    {
        get => new TerraformReference<string>(this, "portal_url");
    }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string> PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    public TerraformValue<string> PublisherEmail
    {
        get => new TerraformReference<string>(this, "publisher_email");
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    public TerraformValue<string> PublisherName
    {
        get => new TerraformReference<string>(this, "publisher_name");
    }

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformValue<string> ScmUrl
    {
        get => new TerraformReference<string>(this, "scm_url");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TenantAccess
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "tenant_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
