using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    [TerraformPropertyName("additional_location")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AdditionalLocation => new TerraformReference(this, "additional_location");

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("developer_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeveloperPortalUrl => new TerraformReference(this, "developer_portal_url");

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_regional_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayRegionalUrl => new TerraformReference(this, "gateway_regional_url");

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayUrl => new TerraformReference(this, "gateway_url");

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    [TerraformPropertyName("hostname_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HostnameConfiguration => new TerraformReference(this, "hostname_configuration");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformPropertyName("management_api_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagementApiUrl => new TerraformReference(this, "management_api_url");

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformPropertyName("notification_sender_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotificationSenderEmail => new TerraformReference(this, "notification_sender_email");

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformPropertyName("portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalUrl => new TerraformReference(this, "portal_url");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PrivateIpAddresses => new TerraformReference(this, "private_ip_addresses");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIpAddressId => new TerraformReference(this, "public_ip_address_id");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PublicIpAddresses => new TerraformReference(this, "public_ip_addresses");

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [TerraformPropertyName("publisher_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublisherEmail => new TerraformReference(this, "publisher_email");

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [TerraformPropertyName("publisher_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublisherName => new TerraformReference(this, "publisher_name");

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformPropertyName("scm_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScmUrl => new TerraformReference(this, "scm_url");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    [TerraformPropertyName("tenant_access")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TenantAccess => new TerraformReference(this, "tenant_access");

}
