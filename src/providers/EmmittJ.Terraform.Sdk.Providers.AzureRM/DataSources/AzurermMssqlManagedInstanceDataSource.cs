using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_instance.
/// </summary>
public class AzurermMssqlManagedInstanceDataSource : TerraformDataSource
{
    public AzurermMssqlManagedInstanceDataSource(string name) : base("azurerm_mssql_managed_instance", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdministratorLogin => new TerraformReference(this, "administrator_login");

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Collation => new TerraformReference(this, "collation");

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerManagedKeyId => new TerraformReference(this, "customer_managed_key_id");

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsZone => new TerraformReference(this, "dns_zone");

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone_partner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsZonePartnerId => new TerraformReference(this, "dns_zone_partner_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseType => new TerraformReference(this, "license_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MinimumTlsVersion => new TerraformReference(this, "minimum_tls_version");

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    [TerraformPropertyName("proxy_override")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProxyOverride => new TerraformReference(this, "proxy_override");

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_data_endpoint_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicDataEndpointEnabled => new TerraformReference(this, "public_data_endpoint_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountType => new TerraformReference(this, "storage_account_type");

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("storage_size_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageSizeInGb => new TerraformReference(this, "storage_size_in_gb");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformPropertyName("timezone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimezoneId => new TerraformReference(this, "timezone_id");

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [TerraformPropertyName("vcores")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Vcores => new TerraformReference(this, "vcores");

}
