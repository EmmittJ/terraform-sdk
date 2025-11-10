using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for egress_from in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunEgressPolicyEgressFromBlock : ITerraformBlock
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    [TerraformPropertyName("identities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access to outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will
    /// be allowed access. Possible values: [&amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("identity_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityType { get; set; }

    /// <summary>
    /// Whether to enforce traffic restrictions based on &#39;sources&#39; field. If the &#39;sources&#39; field is non-empty, then this field must be set to &#39;SOURCE_RESTRICTION_ENABLED&#39;. Possible values: [&amp;quot;SOURCE_RESTRICTION_ENABLED&amp;quot;, &amp;quot;SOURCE_RESTRICTION_DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("source_restriction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceRestriction { get; set; }

}

/// <summary>
/// Block type for egress_to in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunEgressPolicyEgressToBlock : ITerraformBlock
{
    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &#39;*&#39; is not allowed.
    /// </summary>
    [TerraformPropertyName("external_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExternalResources { get; set; }

    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, that match this to stanza. A request matches
    /// if it contains a resource in this list. If * is specified for resources,
    /// then this &#39;EgressTo&#39; rule will authorize access to all resources outside
    /// the perimeter.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding &#39;EgressFrom&#39;
    /// are allowed to perform.
    /// </summary>
    [TerraformPropertyName("roles")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Roles { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunEgressPolicyTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_dry_run_egress_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerServicePerimeterDryRunEgressPolicy : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterDryRunEgressPolicy(string name) : base("google_access_context_manager_service_perimeter_dry_run_egress_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Perimeter is required")]
    [TerraformPropertyName("perimeter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Perimeter { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Title { get; set; }

    /// <summary>
    /// Block for egress_from.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressFrom block(s) allowed")]
    [TerraformPropertyName("egress_from")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterDryRunEgressPolicyEgressFromBlock>>? EgressFrom { get; set; } = new();

    /// <summary>
    /// Block for egress_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressTo block(s) allowed")]
    [TerraformPropertyName("egress_to")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterDryRunEgressPolicyEgressToBlock>>? EgressTo { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerServicePerimeterDryRunEgressPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformPropertyName("access_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_policy_id");

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of policies on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of policies. The policy defined in this resource is added or removed from that list, and then this etag is sent with the PATCH call along with the updated policies.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

}
