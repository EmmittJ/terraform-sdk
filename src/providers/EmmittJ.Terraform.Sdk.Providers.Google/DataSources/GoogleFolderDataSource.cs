using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folder.
/// </summary>
public partial class GoogleFolderDataSource : TerraformDataSource
{
    public GoogleFolderDataSource(string name) : base("google_folder", name)
    {
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformProperty("folder")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lookup_organization attribute.
    /// </summary>
    [TerraformProperty("lookup_organization")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LookupOrganization { get; set; }

    /// <summary>
    /// The configured_capabilities attribute.
    /// </summary>
    [TerraformProperty("configured_capabilities")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ConfiguredCapabilities { get; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [TerraformProperty("folder_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FolderId { get; }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The management_project attribute.
    /// </summary>
    [TerraformProperty("management_project")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ManagementProject { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [TerraformProperty("organization")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Organization { get; }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [TerraformProperty("parent")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Parent { get; }

}
