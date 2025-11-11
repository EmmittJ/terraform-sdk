using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public required TerraformValue<string> GalleryName { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSharedImageDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_network_support_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AcceleratedNetworkSupportEnabled => new TerraformReference(this, "accelerated_network_support_enabled");

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Architecture => new TerraformReference(this, "architecture");

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("confidential_vm_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ConfidentialVmEnabled => new TerraformReference(this, "confidential_vm_enabled");

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    [TerraformPropertyName("confidential_vm_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ConfidentialVmSupported => new TerraformReference(this, "confidential_vm_supported");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformPropertyName("eula")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Eula => new TerraformReference(this, "eula");

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hibernation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HibernationEnabled => new TerraformReference(this, "hibernation_enabled");

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformPropertyName("hyper_v_generation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HyperVGeneration => new TerraformReference(this, "hyper_v_generation");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identifier => new TerraformReference(this, "identifier");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsType => new TerraformReference(this, "os_type");

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformPropertyName("privacy_statement_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivacyStatementUri => new TerraformReference(this, "privacy_statement_uri");

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    [TerraformPropertyName("purchase_plan")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PurchasePlan => new TerraformReference(this, "purchase_plan");

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformPropertyName("release_note_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReleaseNoteUri => new TerraformReference(this, "release_note_uri");

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    [TerraformPropertyName("specialized")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Specialized => new TerraformReference(this, "specialized");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TrustedLaunchEnabled => new TerraformReference(this, "trusted_launch_enabled");

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    [TerraformPropertyName("trusted_launch_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TrustedLaunchSupported => new TerraformReference(this, "trusted_launch_supported");

}
