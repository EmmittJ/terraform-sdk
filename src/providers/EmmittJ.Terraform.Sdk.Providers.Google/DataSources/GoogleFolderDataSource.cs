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
    public required TerraformProperty<TerraformProperty<string>> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lookup_organization attribute.
    /// </summary>
    [TerraformPropertyName("lookup_organization")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LookupOrganization { get; set; }

    /// <summary>
    /// The configured_capabilities attribute.
    /// </summary>
    [TerraformPropertyName("configured_capabilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConfiguredCapabilities => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "configured_capabilities");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [TerraformPropertyName("folder_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FolderId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "folder_id");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The management_project attribute.
    /// </summary>
    [TerraformPropertyName("management_project")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagementProject => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "management_project");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [TerraformPropertyName("organization")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Organization => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organization");

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Parent => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent");

}
