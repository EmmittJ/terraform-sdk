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
        get => GetArgument<TerraformValue<string>>("read");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdditionalLocation
        => CreateReference("additional_location");

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformValue<string> DeveloperPortalUrl
        => CreateReference("developer_portal_url");

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayRegionalUrl
        => CreateReference("gateway_regional_url");

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayUrl
        => CreateReference("gateway_url");

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HostnameConfiguration
        => CreateReference("hostname_configuration");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformValue<string> ManagementApiUrl
        => CreateReference("management_api_url");

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformValue<string> NotificationSenderEmail
        => CreateReference("notification_sender_email");

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformValue<string> PortalUrl
        => CreateReference("portal_url");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => CreateReference("private_ip_addresses");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string> PublicIpAddressId
        => CreateReference("public_ip_address_id");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
        => CreateReference("public_ip_addresses");

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    public TerraformValue<string> PublisherEmail
        => CreateReference("publisher_email");

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    public TerraformValue<string> PublisherName
        => CreateReference("publisher_name");

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformValue<string> ScmUrl
        => CreateReference("scm_url");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => CreateReference("sku_name");

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TenantAccess
        => CreateReference("tenant_access");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
