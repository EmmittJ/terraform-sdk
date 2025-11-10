using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identifier in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageIdentifierBlock : ITerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

}

/// <summary>
/// Block type for purchase_plan in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImagePurchasePlanBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [TerraformPropertyName("product")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformPropertyName("publisher")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Publisher { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_shared_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSharedImage : TerraformResource
{
    public AzurermSharedImage(string name) : base("azurerm_shared_image", name)
    {
    }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_network_support_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Architecture { get; set; }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("confidential_vm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ConfidentialVmEnabled { get; set; }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    [TerraformPropertyName("confidential_vm_supported")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ConfidentialVmSupported { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    [TerraformPropertyName("disk_controller_type_nvme_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DiskControllerTypeNvmeEnabled { get; set; }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    [TerraformPropertyName("disk_types_not_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DiskTypesNotAllowed { get; set; }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    [TerraformPropertyName("end_of_life_date")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndOfLifeDate { get; set; }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformPropertyName("eula")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Eula { get; set; }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformPropertyName("gallery_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GalleryName { get; set; }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HibernationEnabled { get; set; }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformPropertyName("hyper_v_generation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HyperVGeneration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("max_recommended_memory_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    [TerraformPropertyName("max_recommended_vcpu_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxRecommendedVcpuCount { get; set; }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("min_recommended_memory_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinRecommendedMemoryInGb { get; set; }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    [TerraformPropertyName("min_recommended_vcpu_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinRecommendedVcpuCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    [TerraformPropertyName("os_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OsType { get; set; }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformPropertyName("privacy_statement_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivacyStatementUri { get; set; }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformPropertyName("release_note_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReleaseNoteUri { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    [TerraformPropertyName("specialized")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Specialized { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TrustedLaunchEnabled { get; set; }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_supported")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TrustedLaunchSupported { get; set; }

    /// <summary>
    /// Block for identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identifier block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identifier block(s) allowed")]
    [TerraformPropertyName("identifier")]
    public TerraformList<TerraformBlock<AzurermSharedImageIdentifierBlock>>? Identifier { get; set; } = new();

    /// <summary>
    /// Block for purchase_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PurchasePlan block(s) allowed")]
    [TerraformPropertyName("purchase_plan")]
    public TerraformList<TerraformBlock<AzurermSharedImagePurchasePlanBlock>>? PurchasePlan { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSharedImageTimeoutsBlock>? Timeouts { get; set; } = new();

}
