using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identifier in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSharedImageIdentifierBlock : TerraformBlockBase
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformProperty("offer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

}

/// <summary>
/// Block type for purchase_plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSharedImagePurchasePlanBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [TerraformProperty("product")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformProperty("publisher")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Publisher { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSharedImageTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_shared_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSharedImage : TerraformResource
{
    public AzurermSharedImage(string name) : base("azurerm_shared_image", name)
    {
    }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    [TerraformProperty("accelerated_network_support_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    [TerraformProperty("confidential_vm_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ConfidentialVmEnabled { get; set; }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    [TerraformProperty("confidential_vm_supported")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ConfidentialVmSupported { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    [TerraformProperty("disk_controller_type_nvme_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DiskControllerTypeNvmeEnabled { get; set; }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    [TerraformProperty("disk_types_not_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    [TerraformProperty("end_of_life_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndOfLifeDate { get; set; }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformProperty("eula")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Eula { get; set; }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformProperty("gallery_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryName { get; set; }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformProperty("hibernation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HibernationEnabled { get; set; }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformProperty("hyper_v_generation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HyperVGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    [TerraformProperty("max_recommended_memory_in_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    [TerraformProperty("max_recommended_vcpu_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxRecommendedVcpuCount { get; set; }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    [TerraformProperty("min_recommended_memory_in_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinRecommendedMemoryInGb { get; set; }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    [TerraformProperty("min_recommended_vcpu_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinRecommendedVcpuCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    [TerraformProperty("os_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OsType { get; set; }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformProperty("privacy_statement_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivacyStatementUri { get; set; }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformProperty("release_note_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReleaseNoteUri { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    [TerraformProperty("specialized")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Specialized { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TrustedLaunchEnabled { get; set; }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_supported")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TrustedLaunchSupported { get; set; }

    /// <summary>
    /// Block for identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identifier block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identifier block(s) allowed")]
    [TerraformProperty("identifier")]
    public partial TerraformList<TerraformBlock<AzurermSharedImageIdentifierBlock>>? Identifier { get; set; }

    /// <summary>
    /// Block for purchase_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PurchasePlan block(s) allowed")]
    [TerraformProperty("purchase_plan")]
    public partial TerraformList<TerraformBlock<AzurermSharedImagePurchasePlanBlock>>? PurchasePlan { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSharedImageTimeoutsBlock>? Timeouts { get; set; }

}
