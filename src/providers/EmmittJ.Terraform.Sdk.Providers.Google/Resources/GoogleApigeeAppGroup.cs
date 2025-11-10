using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAppGroupAttributesBlock : ITerraformBlock
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeAppGroupTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_app_group resource.
/// </summary>
public class GoogleApigeeAppGroup : TerraformResource
{
    public GoogleApigeeAppGroup(string name) : base("google_apigee_app_group", name)
    {
    }

    /// <summary>
    /// Channel identifier identifies the owner maintaining this grouping.
    /// </summary>
    [TerraformPropertyName("channel_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChannelId { get; set; }

    /// <summary>
    /// A reference to the associated storefront/marketplace.
    /// </summary>
    [TerraformPropertyName("channel_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChannelUri { get; set; }

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the AppGroup. Characters you can use in the name are restricted to: A-Z0-9._-$ %.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee app group,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// Valid values are active or inactive. Note that the status of the AppGroup should be updated via UpdateAppGroupRequest by setting the action as active or inactive. Possible values: [&amp;quot;active&amp;quot;, &amp;quot;inactive&amp;quot;]
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("attributes")]
    public TerraformList<TerraformBlock<GoogleApigeeAppGroupAttributesBlock>>? Attributes { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeAppGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Internal identifier that cannot be edited
    /// </summary>
    [TerraformPropertyName("app_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_group_id");

    /// <summary>
    /// Created time as milliseconds since epoch.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// Modified time as milliseconds since epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_at");

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    [TerraformPropertyName("organization")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Organization => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organization");

}
