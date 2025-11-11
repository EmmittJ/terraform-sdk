using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ingress_from in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterIngressPolicyIngressFromBlock : TerraformBlockBase
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
    public partial TerraformList<string>? Identities { get; set; }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will be
    /// allowed access. Possible values: [&amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    [TerraformProperty("identity_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityType { get; set; }

}

/// <summary>
/// Block type for ingress_to in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterIngressPolicyIngressToBlock : TerraformBlockBase
{
    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, protected by this &#39;ServicePerimeter&#39;
    /// that are allowed to be accessed by sources defined in the
    /// corresponding &#39;IngressFrom&#39;. A request matches if it contains
    /// a resource in this list. If &#39;*&#39; is specified for resources,
    /// then this &#39;IngressTo&#39; rule will authorize access to all
    /// resources inside the perimeter, provided that the request
    /// also matches the &#39;operations&#39; field.
    /// </summary>
    [TerraformProperty("resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Resources { get; set; }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding &#39;IngressFrom&#39;
    /// are allowed to perform.
    /// </summary>
    [TerraformProperty("roles")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Roles { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterIngressPolicyTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_ingress_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAccessContextManagerServicePerimeterIngressPolicy : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterIngressPolicy(string name) : base("google_access_context_manager_service_perimeter_ingress_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Perimeter is required")]
    [TerraformProperty("perimeter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Perimeter { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// Block for ingress_from.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressFrom block(s) allowed")]
    [TerraformProperty("ingress_from")]
    public partial TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterIngressPolicyIngressFromBlock>>? IngressFrom { get; set; }

    /// <summary>
    /// Block for ingress_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressTo block(s) allowed")]
    [TerraformProperty("ingress_to")]
    public partial TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterIngressPolicyIngressToBlock>>? IngressTo { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleAccessContextManagerServicePerimeterIngressPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformProperty("access_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessPolicyId { get; }

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of policies on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of policies. The policy defined in this resource is added or removed from that list, and then this etag is sent with the PATCH call along with the updated policies.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

}
