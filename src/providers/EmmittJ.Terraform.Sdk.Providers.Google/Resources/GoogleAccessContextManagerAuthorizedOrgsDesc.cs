using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_access_context_manager_authorized_orgs_desc resource.
/// </summary>
public partial class GoogleAccessContextManagerAuthorizedOrgsDesc : TerraformResource
{
    public GoogleAccessContextManagerAuthorizedOrgsDesc(string name) : base("google_access_context_manager_authorized_orgs_desc", name)
    {
    }

    /// <summary>
    /// The type of entities that need to use the authorization relationship during
    /// evaluation, such as a device. Valid values are &amp;quot;ASSET_TYPE_DEVICE&amp;quot; and
    /// &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;. Possible values: [&amp;quot;ASSET_TYPE_DEVICE&amp;quot;, &amp;quot;ASSET_TYPE_CREDENTIAL_STRENGTH&amp;quot;]
    /// </summary>
    [TerraformProperty("asset_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AssetType { get; set; }

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
    [TerraformProperty("authorization_direction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationDirection { get; set; }

    /// <summary>
    /// A granular control type for authorization levels. Valid value is &amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;. Possible values: [&amp;quot;AUTHORIZATION_TYPE_TRUST&amp;quot;]
    /// </summary>
    [TerraformProperty("authorization_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource name for the &#39;AuthorizedOrgsDesc&#39;. Format:
    /// &#39;accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}&#39;.
    /// The &#39;authorized_orgs_desc&#39; component must begin with a letter, followed by
    /// alphanumeric characters or &#39;_&#39;.
    /// After you create an &#39;AuthorizedOrgsDesc&#39;, you cannot change its &#39;name&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The list of organization ids in this AuthorizedOrgsDesc.
    /// Format: &#39;organizations/&amp;lt;org_number&amp;gt;&#39;
    /// Example: &#39;organizations/123456&#39;
    /// </summary>
    [TerraformProperty("orgs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Orgs { get; set; }

    /// <summary>
    /// Required. Resource name for the access policy which owns this &#39;AuthorizedOrgsDesc&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleAccessContextManagerAuthorizedOrgsDescTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the AuthorizedOrgsDesc was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Time the AuthorizedOrgsDesc was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
