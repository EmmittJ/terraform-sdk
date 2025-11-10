using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admission_whitelist_patterns in .
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock : TerraformBlock
{
    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// &#39;registry/path/to/image&#39;. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePattern is required")]
    public required TerraformProperty<string> NamePattern
    {
        set => SetProperty("name_pattern", value);
    }

}

/// <summary>
/// Block type for cluster_admission_rules in .
/// Nesting mode: set
/// </summary>
public class GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock : TerraformBlock
{
    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    public required TerraformProperty<string> EnforcementMode
    {
        set => SetProperty("enforcement_mode", value);
    }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    public required TerraformProperty<string> EvaluationMode
    {
        set => SetProperty("evaluation_mode", value);
    }

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
    public HashSet<TerraformProperty<string>>? RequireAttestationsBy
    {
        set => SetProperty("require_attestations_by", value);
    }

}

/// <summary>
/// Block type for default_admission_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock : TerraformBlock
{
    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    public required TerraformProperty<string> EnforcementMode
    {
        set => SetProperty("enforcement_mode", value);
    }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    public required TerraformProperty<string> EvaluationMode
    {
        set => SetProperty("evaluation_mode", value);
    }

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
    public HashSet<TerraformProperty<string>>? RequireAttestationsBy
    {
        set => SetProperty("require_attestations_by", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBinaryAuthorizationPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_binary_authorization_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBinaryAuthorizationPolicy : TerraformResource
{
    public GoogleBinaryAuthorizationPolicy(string name) : base("google_binary_authorization_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("global_policy_evaluation_mode");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// A descriptive comment.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy. Possible values: [&amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> GlobalPolicyEvaluationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_policy_evaluation_mode");
        set => SetProperty("global_policy_evaluation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for admission_whitelist_patterns.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock>? AdmissionWhitelistPatterns
    {
        set => SetProperty("admission_whitelist_patterns", value);
    }

    /// <summary>
    /// Block for cluster_admission_rules.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock>? ClusterAdmissionRules
    {
        set => SetProperty("cluster_admission_rules", value);
    }

    /// <summary>
    /// Block for default_admission_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdmissionRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAdmissionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAdmissionRule block(s) allowed")]
    public List<GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock>? DefaultAdmissionRule
    {
        set => SetProperty("default_admission_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBinaryAuthorizationPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
