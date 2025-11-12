using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admission_whitelist_patterns in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock() : TerraformBlock("admission_whitelist_patterns")
{
    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// &#39;registry/path/to/image&#39;. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePattern is required")]
    [TerraformProperty("name_pattern")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamePattern { get; set; }

}

/// <summary>
/// Block type for cluster_admission_rules in .
/// Nesting mode: set
/// </summary>
public partial class GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock() : TerraformBlock("cluster_admission_rules")
{
    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    [TerraformProperty("enforcement_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    [TerraformProperty("evaluation_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format &#39;projects/*/attestors/*&#39;.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// 
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [TerraformProperty("require_attestations_by")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RequireAttestationsBy { get; set; }

}

/// <summary>
/// Block type for default_admission_rule in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock() : TerraformBlock("default_admission_rule")
{
    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    [TerraformProperty("enforcement_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    [TerraformProperty("evaluation_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format &#39;projects/*/attestors/*&#39;.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// 
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [TerraformProperty("require_attestations_by")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RequireAttestationsBy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBinaryAuthorizationPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_binary_authorization_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBinaryAuthorizationPolicy : TerraformResource
{
    public GoogleBinaryAuthorizationPolicy(string name) : base("google_binary_authorization_policy", name)
    {
    }

    /// <summary>
    /// A descriptive comment.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy. Possible values: [&amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    [TerraformProperty("global_policy_evaluation_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GlobalPolicyEvaluationMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for admission_whitelist_patterns.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("admission_whitelist_patterns")]
    public TerraformList<GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock> AdmissionWhitelistPatterns { get; set; } = new();

    /// <summary>
    /// Block for cluster_admission_rules.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cluster_admission_rules")]
    public TerraformSet<GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock> ClusterAdmissionRules { get; set; } = new();

    /// <summary>
    /// Block for default_admission_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdmissionRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAdmissionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAdmissionRule block(s) allowed")]
    [TerraformProperty("default_admission_rule")]
    public required TerraformList<GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock> DefaultAdmissionRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBinaryAuthorizationPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
