using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_soa_record.
/// </summary>
public partial class AzurermPrivateDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermPrivateDnsSoaRecordDataSource(string name) : base("azurerm_private_dns_soa_record", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    [TerraformProperty("zone_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ZoneName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Email { get; }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ExpireTime { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformProperty("host_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostName { get; }

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformProperty("minimum_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MinimumTtl { get; }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformProperty("refresh_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RefreshTime { get; }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformProperty("retry_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RetryTime { get; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformProperty("serial_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SerialNumber { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Ttl { get; }

}
