using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDnsSoaRecordDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dns_soa_record.
/// </summary>
public partial class AzurermDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermDnsSoaRecordDataSource(string name) : base("azurerm_dns_soa_record", name)
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
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    [TerraformProperty("zone_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ZoneName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDnsSoaRecordDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Email { get; }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ExpireTime { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformProperty("host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostName { get; }

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformProperty("minimum_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinimumTtl { get; }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformProperty("refresh_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RefreshTime { get; }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformProperty("retry_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RetryTime { get; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformProperty("serial_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SerialNumber { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Ttl { get; }

}
