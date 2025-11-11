using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admission_whitelist_patterns in .
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock
{
    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// &#39;registry/path/to/image&#39;. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePattern is required")]
    [TerraformPropertyName("name_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NamePattern { get; set; }

}

/// <summary>
/// Block type for cluster_admission_rules in .
/// Nesting mode: set
/// </summary>
public class GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock
{
    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    [TerraformPropertyName("enforcement_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    [TerraformPropertyName("evaluation_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EvaluationMode { get; set; }

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
    [TerraformPropertyName("require_attestations_by")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RequireAttestationsBy { get; set; }

}

/// <summary>
/// Block type for default_admission_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock
{
    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    [TerraformPropertyName("enforcement_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    [TerraformPropertyName("evaluation_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EvaluationMode { get; set; }

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
    [TerraformPropertyName("require_attestations_by")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RequireAttestationsBy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBinaryAuthorizationPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_binary_authorization_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBinaryAuthorizationPolicy : TerraformResource
{
    public GoogleBinaryAuthorizationPolicy(string name) : base("google_binary_authorization_policy", name)
    {
    }

    /// <summary>
    /// A descriptive comment.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy. Possible values: [&amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("global_policy_evaluation_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> GlobalPolicyEvaluationMode { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for admission_whitelist_patterns.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("admission_whitelist_patterns")]
    public TerraformList<TerraformBlock<GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock>>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>
    /// Block for cluster_admission_rules.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cluster_admission_rules")]
    public TerraformSet<TerraformBlock<GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock>>? ClusterAdmissionRules { get; set; }

    /// <summary>
    /// Block for default_admission_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdmissionRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAdmissionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAdmissionRule block(s) allowed")]
    [TerraformPropertyName("default_admission_rule")]
    public TerraformList<TerraformBlock<GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock>>? DefaultAdmissionRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBinaryAuthorizationPolicyTimeoutsBlock>? Timeouts { get; set; }

}
