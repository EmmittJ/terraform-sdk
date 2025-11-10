using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image.
/// </summary>
public class AzurermSharedImageDataSource : TerraformDataSource
{
    public AzurermSharedImageDataSource(string name) : base("azurerm_shared_image", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformPropertyName("gallery_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GalleryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSharedImageDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_network_support_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AcceleratedNetworkSupportEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "accelerated_network_support_enabled");

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Architecture => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "architecture");

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("confidential_vm_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ConfidentialVmEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "confidential_vm_enabled");

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    [TerraformPropertyName("confidential_vm_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ConfidentialVmSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "confidential_vm_supported");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformPropertyName("eula")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Eula => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "eula");

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HibernationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hibernation_enabled");

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformPropertyName("hyper_v_generation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HyperVGeneration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hyper_v_generation");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identifier => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identifier");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_type");

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformPropertyName("privacy_statement_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivacyStatementUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "privacy_statement_uri");

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    [TerraformPropertyName("purchase_plan")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PurchasePlan => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "purchase_plan");

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformPropertyName("release_note_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReleaseNoteUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "release_note_uri");

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    [TerraformPropertyName("specialized")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Specialized => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "specialized");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TrustedLaunchEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "trusted_launch_enabled");

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TrustedLaunchSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "trusted_launch_supported");

}
