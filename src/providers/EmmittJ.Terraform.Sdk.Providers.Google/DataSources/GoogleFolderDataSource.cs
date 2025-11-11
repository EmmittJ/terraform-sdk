using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folder.
/// </summary>
public class GoogleFolderDataSource : TerraformDataSource
{
    public GoogleFolderDataSource(string name) : base("google_folder", name)
    {
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformPropertyName("folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The lookup_organization attribute.
    /// </summary>
    [TerraformPropertyName("lookup_organization")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LookupOrganization { get; set; }

    /// <summary>
    /// The configured_capabilities attribute.
    /// </summary>
    [TerraformPropertyName("configured_capabilities")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ConfiguredCapabilities => new TerraformReference(this, "configured_capabilities");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [TerraformPropertyName("folder_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FolderId => new TerraformReference(this, "folder_id");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The management_project attribute.
    /// </summary>
    [TerraformPropertyName("management_project")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagementProject => new TerraformReference(this, "management_project");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [TerraformPropertyName("organization")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Organization => new TerraformReference(this, "organization");

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Parent => new TerraformReference(this, "parent");

}
