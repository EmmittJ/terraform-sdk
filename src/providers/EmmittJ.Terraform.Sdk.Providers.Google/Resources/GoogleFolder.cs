using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFolderTimeoutsBlock : ITerraformBlock
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
/// Manages a google_folder resource.
/// </summary>
public class GoogleFolder : TerraformResource
{
    public GoogleFolder(string name) : base("google_folder", name)
    {
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The folder&#39;s display name. A folder&#39;s display name must be unique amongst its siblings, e.g. no two folders with the same parent can share the same display name. The display name must start and end with a letter or digit, may contain letters, digits, spaces, hyphens and underscores and can be no longer than 30 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource name of the parent Folder or Organization. Must be of the form folders/{folder_id} or organizations/{org_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored when empty. This field is only set at create time and modifying this field after creation will trigger recreation. To apply tags to an existing resource, see the google_tags_tag_value resource.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFolderTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// A list of capabilities that are configured for this folder.
    /// </summary>
    [TerraformPropertyName("configured_capabilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConfiguredCapabilities => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "configured_capabilities");

    /// <summary>
    /// Timestamp when the Folder was created. Assigned by the server. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The folder id from the name &amp;quot;folders/{folder_id}&amp;quot;
    /// </summary>
    [TerraformPropertyName("folder_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FolderId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "folder_id");

    /// <summary>
    /// The lifecycle state of the folder such as ACTIVE or DELETE_REQUESTED.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The Management Project associated with the folder&#39;s configured capabilities.
    /// </summary>
    [TerraformPropertyName("management_project")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagementProject => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "management_project");

    /// <summary>
    /// The resource name of the Folder. Its format is folders/{folder_id}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
