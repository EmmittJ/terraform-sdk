using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDnsSoaRecordDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dns_soa_record.
/// </summary>
public class AzurermDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermDnsSoaRecordDataSource(string name) : base("azurerm_dns_soa_record", name)
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
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    [TerraformPropertyName("zone_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ZoneName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDnsSoaRecordDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ExpireTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "expire_time");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_name");

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformPropertyName("minimum_ttl")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinimumTtl => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "minimum_ttl");

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformPropertyName("refresh_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RefreshTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "refresh_time");

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformPropertyName("retry_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RetryTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retry_time");

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformPropertyName("serial_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SerialNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "serial_number");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Ttl => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ttl");

}
