using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    [TerraformPropertyName("additional_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdditionalLocation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "additional_location");

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    [TerraformPropertyName("developer_portal_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeveloperPortalUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "developer_portal_url");

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_regional_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayRegionalUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_regional_url");

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_url");

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    [TerraformPropertyName("hostname_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HostnameConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hostname_configuration");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    [TerraformPropertyName("management_api_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagementApiUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "management_api_url");

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    [TerraformPropertyName("notification_sender_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotificationSenderEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "notification_sender_email");

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformPropertyName("portal_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PortalUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "portal_url");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PrivateIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "private_ip_addresses");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIpAddressId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip_address_id");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PublicIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "public_ip_addresses");

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [TerraformPropertyName("publisher_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublisherEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "publisher_email");

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    [TerraformPropertyName("publisher_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublisherName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "publisher_name");

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    [TerraformPropertyName("scm_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScmUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scm_url");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    [TerraformPropertyName("tenant_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TenantAccess => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tenant_access");

}
