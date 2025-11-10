using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock : ITerraformBlock
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
/// Manages a google_access_context_manager_authorized_orgs_desc resource.
/// </summary>
public class GoogleAccessContextManagerAuthorizedOrgsDesc : TerraformResource
{
    public GoogleAccessContextManagerAuthorizedOrgsDesc(string name) : base("google_access_context_manager_authorized_orgs_desc", name)
    {
    }

    /// <summary>
    /// The type of entities that need to use the authorization relationship during
    /// evaluation, such as a device. Valid values are &amp;quot;ASSET_TYPE_DEVICE&amp;quot; and
    /// &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;. Possible values: [&amp;quot;ASSET_TYPE_DEVICE&amp;quot;, &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("asset_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AssetType { get; set; }

    /// <summary>
    /// The direction of the authorization relationship between this organization
    /// and the organizations listed in the &amp;quot;orgs&amp;quot; field. The valid values for this
    /// field include the following:
    /// 
    /// AUTHORIZATION_DIRECTION_FROM: Allows this organization to evaluate traffic
    /// in the organizations listed in the &#39;orgs&#39; field.
    /// 
    /// AUTHORIZATION_DIRECTION_TO: Allows the organizations listed in the &#39;orgs&#39;
    /// field to evaluate the traffic in this organization.
    /// 
    /// For the authorization relationship to take effect, all of the organizations
    /// must authorize and specify the appropriate relationship direction. For
    /// example, if organization A authorized organization B and C to evaluate its
    /// traffic, by specifying &amp;quot;AUTHORIZATION_DIRECTION_TO&amp;quot; as the authorization
    /// direction, organizations B and C must specify
    /// &amp;quot;AUTHORIZATION_DIRECTION_FROM&amp;quot; as the authorization direction in their
    /// &amp;quot;AuthorizedOrgsDesc&amp;quot; resource. Possible values: [&amp;quot;AUTHORIZATION_DIRECTION_TO&amp;quot;, &amp;quot;AUTHORIZATION_DIRECTION_FROM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("authorization_direction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizationDirection { get; set; }

    /// <summary>
    /// A granular control type for authorization levels. Valid value is &amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;. Possible values: [&amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;]
    /// </summary>
    [TerraformPropertyName("authorization_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizationType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource name for the &#39;AuthorizedOrgsDesc&#39;. Format:
    /// &#39;accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}&#39;.
    /// The &#39;authorized_orgs_desc&#39; component must begin with a letter, followed by
    /// alphanumeric characters or &#39;_&#39;.
    /// After you create an &#39;AuthorizedOrgsDesc&#39;, you cannot change its &#39;name&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The list of organization ids in this AuthorizedOrgsDesc.
    /// Format: &#39;organizations/&amp;lt;org_number&amp;gt;&#39;
    /// Example: &#39;organizations/123456&#39;
    /// </summary>
    [TerraformPropertyName("orgs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Orgs { get; set; }

    /// <summary>
    /// Required. Resource name for the access policy which owns this &#39;AuthorizedOrgsDesc&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time the AuthorizedOrgsDesc was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Time the AuthorizedOrgsDesc was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
