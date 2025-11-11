using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_soa_record.
/// </summary>
public class AzurermPrivateDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermPrivateDnsSoaRecordDataSource(string name) : base("azurerm_private_dns_soa_record", name)
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
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    [TerraformPropertyName("zone_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ZoneName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Email => new TerraformReference(this, "email");

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ExpireTime => new TerraformReference(this, "expire_time");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostName => new TerraformReference(this, "host_name");

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformPropertyName("minimum_ttl")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinimumTtl => new TerraformReference(this, "minimum_ttl");

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformPropertyName("refresh_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RefreshTime => new TerraformReference(this, "refresh_time");

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformPropertyName("retry_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RetryTime => new TerraformReference(this, "retry_time");

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformPropertyName("serial_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SerialNumber => new TerraformReference(this, "serial_number");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Ttl => new TerraformReference(this, "ttl");

}
