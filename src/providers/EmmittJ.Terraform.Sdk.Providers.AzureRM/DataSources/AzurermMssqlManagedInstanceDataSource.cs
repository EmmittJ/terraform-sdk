using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdministratorLogin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "administrator_login");

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Collation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collation");

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerManagedKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_managed_key_id");

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_zone");

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone_partner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsZonePartnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_zone_partner_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinimumTlsVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "minimum_tls_version");

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    [TerraformPropertyName("proxy_override")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProxyOverride => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "proxy_override");

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_data_endpoint_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PublicDataEndpointEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_data_endpoint_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_type");

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("storage_size_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageSizeInGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_size_in_gb");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformPropertyName("timezone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimezoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "timezone_id");

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [TerraformPropertyName("vcores")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Vcores => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "vcores");

}
