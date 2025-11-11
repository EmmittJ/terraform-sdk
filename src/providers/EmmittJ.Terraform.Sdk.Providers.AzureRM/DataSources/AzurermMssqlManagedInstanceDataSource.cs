using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlManagedInstanceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_instance.
/// </summary>
public partial class AzurermMssqlManagedInstanceDataSource : TerraformDataSource
{
    public AzurermMssqlManagedInstanceDataSource(string name) : base("azurerm_mssql_managed_instance", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdministratorLogin { get; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformProperty("collation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Collation { get; }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerManagedKeyId { get; }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformProperty("dns_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsZone { get; }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformProperty("dns_zone_partner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsZonePartnerId { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseType { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MinimumTlsVersion { get; }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    [TerraformProperty("proxy_override")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProxyOverride { get; }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("public_data_endpoint_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PublicDataEndpointEnabled { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountType { get; }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformProperty("storage_size_in_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageSizeInGb { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformProperty("timezone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimezoneId { get; }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [TerraformProperty("vcores")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Vcores { get; }

}
