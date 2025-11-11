using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for egress_from in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlock : TerraformBlockBase
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [TerraformProperty("identities")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access to outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will
    /// be allowed access. Possible values: [&amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    [TerraformProperty("identity_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on &#39;sources&#39; field. If the &#39;sources&#39; field is non-empty, then this field must be set to &#39;SOURCE_RESTRICTION_ENABLED&#39;. Possible values: [&amp;quot;SOURCE_RESTRICTION_UNSPECIFIED&amp;quot;, &amp;quot;SOURCE_RESTRICTION_ENABLED&amp;quot;, &amp;quot;SOURCE_RESTRICTION_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("source_restriction")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceRestriction { get; set; }

}

/// <summary>
/// Block type for egress_to in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlock : TerraformBlockBase
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &#39;*&#39; is not allowed.
    /// </summary>
    [TerraformProperty("external_resources")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ExternalResources { get; set; }

    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, that match this to stanza. A request matches
    /// if it contains a resource in this list. If * is specified for resources,
    /// then this &#39;EgressTo&#39; rule will authorize access to all resources outside
    /// the perimeter.
    /// </summary>
    [TerraformProperty("resources")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding &#39;EgressFrom&#39;
    /// are allowed to perform.
    /// </summary>
    [TerraformProperty("roles")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Roles { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterEgressPolicyTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_egress_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAccessContextManagerServicePerimeterEgressPolicy : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterEgressPolicy(string name) : base("google_access_context_manager_service_perimeter_egress_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Perimeter is required")]
    [TerraformProperty("perimeter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Perimeter { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// Block for egress_from.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressFrom block(s) allowed")]
    [TerraformProperty("egress_from")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlock>>? EgressFrom { get; set; }

    /// <summary>
    /// Block for egress_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressTo block(s) allowed")]
    [TerraformProperty("egress_to")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlock>>? EgressTo { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerServicePerimeterEgressPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformProperty("access_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessPolicyId { get; }

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of policies on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of policies. The policy defined in this resource is added or removed from that list, and then this etag is sent with the PATCH call along with the updated policies.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

}
