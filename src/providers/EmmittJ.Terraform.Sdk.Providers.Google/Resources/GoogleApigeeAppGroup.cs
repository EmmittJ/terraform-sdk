using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeAppGroupAttributesBlock : TerraformBlockBase
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeAppGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_app_group resource.
/// </summary>
public partial class GoogleApigeeAppGroup : TerraformResource
{
    public GoogleApigeeAppGroup(string name) : base("google_apigee_app_group", name)
    {
    }

    /// <summary>
    /// Channel identifier identifies the owner maintaining this grouping.
    /// </summary>
    [TerraformProperty("channel_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ChannelId { get; set; }

    /// <summary>
    /// A reference to the associated storefront/marketplace.
    /// </summary>
    [TerraformProperty("channel_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ChannelUri { get; set; }

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the AppGroup. Characters you can use in the name are restricted to: A-Z0-9._-$ %.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee app group,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Valid values are active or inactive. Note that the status of the AppGroup should be updated via UpdateAppGroupRequest by setting the action as active or inactive. Possible values: [&amp;quot;active&amp;quot;, &amp;quot;inactive&amp;quot;]
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("attributes")]
    public TerraformList<TerraformBlock<GoogleApigeeAppGroupAttributesBlock>>? Attributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleApigeeAppGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Internal identifier that cannot be edited
    /// </summary>
    [TerraformProperty("app_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AppGroupId { get; }

    /// <summary>
    /// Created time as milliseconds since epoch.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// Modified time as milliseconds since epoch.
    /// </summary>
    [TerraformProperty("last_modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedAt { get; }

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    [TerraformProperty("organization")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Organization { get; }

}
