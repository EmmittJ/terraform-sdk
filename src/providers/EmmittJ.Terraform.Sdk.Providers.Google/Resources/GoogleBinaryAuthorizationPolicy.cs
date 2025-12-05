using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admission_whitelist_patterns in GoogleBinaryAuthorizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admission_whitelist_patterns";

    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// &#39;registry/path/to/image&#39;. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePattern is required")]
    public required TerraformValue<string> NamePattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("name_pattern");
        set => SetArgument("name_pattern", value);
    }

}


/// <summary>
/// Block type for cluster_admission_rules in GoogleBinaryAuthorizationPolicy.
/// Nesting mode: set
/// </summary>
public class GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_admission_rules";

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    public required TerraformValue<string> EnforcementMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("enforcement_mode");
        set => SetArgument("enforcement_mode", value);
    }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    public required TerraformValue<string> EvaluationMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
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
    public TerraformSet<string>? RequireAttestationsBy
    {
        get => GetArgument<TerraformSet<string>>("require_attestations_by");
        set => SetArgument("require_attestations_by", value);
    }

}


/// <summary>
/// Block type for default_admission_rule in GoogleBinaryAuthorizationPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_admission_rule";

    /// <summary>
    /// The action when a pod creation is denied by the admission rule. Possible values: [&amp;quot;ENFORCED_BLOCK_AND_AUDIT_LOG&amp;quot;, &amp;quot;DRYRUN_AUDIT_LOG_ONLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforcementMode is required")]
    public required TerraformValue<string> EnforcementMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("enforcement_mode");
        set => SetArgument("enforcement_mode", value);
    }

    /// <summary>
    /// How this admission rule will be evaluated. Possible values: [&amp;quot;ALWAYS_ALLOW&amp;quot;, &amp;quot;REQUIRE_ATTESTATION&amp;quot;, &amp;quot;ALWAYS_DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationMode is required")]
    public required TerraformValue<string> EvaluationMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
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
    public TerraformSet<string>? RequireAttestationsBy
    {
        get => GetArgument<TerraformSet<string>>("require_attestations_by");
        set => SetArgument("require_attestations_by", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBinaryAuthorizationPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleBinaryAuthorizationPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_binary_authorization_policy Terraform resource.
/// Manages a google_binary_authorization_policy resource.
/// </summary>
public partial class GoogleBinaryAuthorizationPolicy(string name) : TerraformResource("google_binary_authorization_policy", name)
{
    /// <summary>
    /// A descriptive comment.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy. Possible values: [&amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    public TerraformValue<string> GlobalPolicyEvaluationMode
    {
        get => GetArgument<TerraformValue<string>>("global_policy_evaluation_mode") ?? CreateReference("global_policy_evaluation_mode");
        set => SetArgument("global_policy_evaluation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// AdmissionWhitelistPatterns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock>? AdmissionWhitelistPatterns
    {
        get => GetArgument<TerraformList<GoogleBinaryAuthorizationPolicyAdmissionWhitelistPatternsBlock>>("admission_whitelist_patterns");
        set => SetArgument("admission_whitelist_patterns", value);
    }

    /// <summary>
    /// ClusterAdmissionRules block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock>? ClusterAdmissionRules
    {
        get => GetArgument<TerraformSet<GoogleBinaryAuthorizationPolicyClusterAdmissionRulesBlock>>("cluster_admission_rules");
        set => SetArgument("cluster_admission_rules", value);
    }

    /// <summary>
    /// DefaultAdmissionRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdmissionRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAdmissionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAdmissionRule block(s) allowed")]
    public required TerraformList<GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock> DefaultAdmissionRule
    {
        get => GetRequiredArgument<TerraformList<GoogleBinaryAuthorizationPolicyDefaultAdmissionRuleBlock>>("default_admission_rule");
        set => SetArgument("default_admission_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBinaryAuthorizationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBinaryAuthorizationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
