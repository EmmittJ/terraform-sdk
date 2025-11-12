using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudIdentityGroupGroupKeyBlock() : TerraformBlock("group_key")
{
    /// <summary>
    /// The ID of the entity.
    /// 
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// 
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&#39;s requirements.
    /// 
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The namespace in which the entity exists.
    /// 
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// 
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of &#39;identitysources/{identity_source_id}&#39;.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Namespace { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudIdentityGroupTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloud_identity_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudIdentityGroup : TerraformResource
{
    public GoogleCloudIdentityGroup(string name) : base("google_cloud_identity_group", name)
    {
    }

    /// <summary>
    /// An extended description to help users determine the purpose of a Group.
    /// Must not be longer than 4,096 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the Group.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initial configuration options for creating a Group.
    /// 
    /// See the
    /// [API reference](https://cloud.google.com/identity/docs/reference/rest/v1beta1/groups/create#initialgroupconfig)
    /// for possible values. Default value: &amp;quot;EMPTY&amp;quot; Possible values: [&amp;quot;INITIAL_GROUP_CONFIG_UNSPECIFIED&amp;quot;, &amp;quot;WITH_INITIAL_OWNER&amp;quot;, &amp;quot;EMPTY&amp;quot;]
    /// </summary>
    [TerraformProperty("initial_group_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InitialGroupConfig { get; set; }

    /// <summary>
    /// One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value.
    /// 
    /// Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value.
    /// 
    /// Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added.
    /// 
    /// Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic.
    /// 
    /// Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Labels is required")]
    [TerraformProperty("labels")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> Labels { get; set; }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// 
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for group_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    [TerraformProperty("group_key")]
    public required TerraformList<GoogleCloudIdentityGroupGroupKeyBlock> GroupKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleCloudIdentityGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Additional group keys associated with the Group
    /// </summary>
    [TerraformProperty("additional_group_keys")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AdditionalGroupKeys { get; }

    /// <summary>
    /// The time when the Group was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Resource name of the Group in the format: groups/{group_id}, where group_id
    /// is the unique ID assigned to the Group.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The time when the Group was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
