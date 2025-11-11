using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for soa_record in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPrivateDnsZoneSoaRecordBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ExpireTime { get; set; }



    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformProperty("minimum_ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumTtl { get; set; }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformProperty("refresh_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RefreshTime { get; set; }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformProperty("retry_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetryTime { get; set; }


    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Ttl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateDnsZoneTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_private_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPrivateDnsZone : TerraformResource
{
    public AzurermPrivateDnsZone(string name) : base("azurerm_private_dns_zone", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for soa_record.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    [TerraformProperty("soa_record")]
    public TerraformList<TerraformBlock<AzurermPrivateDnsZoneSoaRecordBlock>>? SoaRecord { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPrivateDnsZoneTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformProperty("max_number_of_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxNumberOfRecordSets { get; }

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    [TerraformProperty("max_number_of_virtual_network_links")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxNumberOfVirtualNetworkLinks { get; }

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    [TerraformProperty("max_number_of_virtual_network_links_with_registration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxNumberOfVirtualNetworkLinksWithRegistration { get; }

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformProperty("number_of_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NumberOfRecordSets { get; }

}
