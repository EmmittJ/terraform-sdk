using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for soa_record in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDnsZoneSoaRecordBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ExpireTime { get; set; }



    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformProperty("minimum_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinimumTtl { get; set; }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformProperty("refresh_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RefreshTime { get; set; }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformProperty("retry_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryTime { get; set; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformProperty("serial_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SerialNumber { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Ttl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDnsZoneTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDnsZone : TerraformResource
{
    public AzurermDnsZone(string name) : base("azurerm_dns_zone", name)
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
    /// Block for soa_record.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    [TerraformProperty("soa_record")]
    public partial TerraformList<TerraformBlock<AzurermDnsZoneSoaRecordBlock>>? SoaRecord { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDnsZoneTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformProperty("max_number_of_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxNumberOfRecordSets { get; }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformProperty("name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> NameServers { get; }

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformProperty("number_of_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumberOfRecordSets { get; }

}
