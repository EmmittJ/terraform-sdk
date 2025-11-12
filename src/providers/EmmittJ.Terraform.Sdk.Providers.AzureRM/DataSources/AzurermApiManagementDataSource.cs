using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management.
/// </summary>
public partial class AzurermApiManagementDataSource : TerraformDataSource
{
    public AzurermApiManagementDataSource(string name) : base("azurerm_api_management", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermApiManagementDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    [TerraformProperty("additional_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AdditionalLocation { get; }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformProperty("developer_portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeveloperPortalUrl { get; }

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformProperty("gateway_regional_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayRegionalUrl { get; }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformProperty("gateway_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayUrl { get; }

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    [TerraformProperty("hostname_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HostnameConfiguration { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformProperty("management_api_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagementApiUrl { get; }

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformProperty("notification_sender_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotificationSenderEmail { get; }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformProperty("portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalUrl { get; }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PrivateIpAddresses { get; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicIpAddressId { get; }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PublicIpAddresses { get; }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [TerraformProperty("publisher_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublisherEmail { get; }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [TerraformProperty("publisher_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublisherName { get; }

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformProperty("scm_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ScmUrl { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    [TerraformProperty("tenant_access")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TenantAccess { get; }

}
