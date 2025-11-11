using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for soa_record in .
/// Nesting mode: list
/// </summary>
public class AzurermDnsZoneSoaRecordBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExpireTime { get; set; }



    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformPropertyName("minimum_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumTtl { get; set; }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformPropertyName("refresh_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RefreshTime { get; set; }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformPropertyName("retry_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryTime { get; set; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformPropertyName("serial_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SerialNumber { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ttl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDnsZoneTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDnsZone : TerraformResource
{
    public AzurermDnsZone(string name) : base("azurerm_dns_zone", name)
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
    /// Block for soa_record.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    [TerraformPropertyName("soa_record")]
    public TerraformList<TerraformBlock<AzurermDnsZoneSoaRecordBlock>>? SoaRecord { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDnsZoneTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxNumberOfRecordSets => new TerraformReference(this, "max_number_of_record_sets");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformPropertyName("name_servers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> NameServers => new TerraformReference(this, "name_servers");

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("number_of_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumberOfRecordSets => new TerraformReference(this, "number_of_record_sets");

}
