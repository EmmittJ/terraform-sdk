using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSharedImageDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image.
/// </summary>
public partial class AzurermSharedImageDataSource : TerraformDataSource
{
    public AzurermSharedImageDataSource(string name) : base("azurerm_shared_image", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformProperty("gallery_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryName { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSharedImageDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    [TerraformProperty("accelerated_network_support_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AcceleratedNetworkSupportEnabled { get; }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Architecture { get; }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    [TerraformProperty("confidential_vm_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ConfidentialVmEnabled { get; }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    [TerraformProperty("confidential_vm_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ConfidentialVmSupported { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformProperty("eula")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Eula { get; }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformProperty("hibernation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HibernationEnabled { get; }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformProperty("hyper_v_generation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HyperVGeneration { get; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformProperty("identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identifier { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsType { get; }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformProperty("privacy_statement_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivacyStatementUri { get; }

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    [TerraformProperty("purchase_plan")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PurchasePlan { get; }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformProperty("release_note_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReleaseNoteUri { get; }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    [TerraformProperty("specialized")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Specialized { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TrustedLaunchEnabled { get; }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    [TerraformProperty("trusted_launch_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TrustedLaunchSupported { get; }

}
