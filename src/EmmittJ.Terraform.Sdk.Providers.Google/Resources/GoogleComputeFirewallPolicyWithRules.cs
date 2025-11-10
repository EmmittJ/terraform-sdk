using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallPolicyWithRulesRuleBlock : TerraformBlock
{
    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Can currently be either
    /// &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;apply_security_profile_group&amp;quot; or &amp;quot;goto_next&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// A description of the rule.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The direction in which this rule applies. If unspecified an INGRESS rule is created. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => WithProperty("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled. When set to true,
    /// the firewall policy rule is not enforced and traffic behaves as if it did
    /// not exist. If this is unspecified, the firewall policy rule will be
    /// enabled.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => WithProperty("disabled", value);
    }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the
    /// configured export destination in Stackdriver.
    /// </summary>
    public TerraformProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_logging");
        set => WithProperty("enable_logging", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list. The priority must be a value
    /// between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the
    /// highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier
    /// and can be updated.
    /// </summary>
    public TerraformProperty<string>? RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => WithProperty("rule_name", value);
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example:
    /// https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action is &#39;apply_security_profile_group&#39;.
    /// </summary>
    public TerraformProperty<string>? SecurityProfileGroup
    {
        get => GetProperty<TerraformProperty<string>>("security_profile_group");
        set => WithProperty("security_profile_group", value);
    }

    /// <summary>
    /// A list of network resource URLs to which this rule applies.
    /// This field allows you to control which network&#39;s VMs get
    /// this rule. If this field is left blank, all VMs
    /// within the organization will receive the rule.
    /// </summary>
    public List<TerraformProperty<string>>? TargetResources
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_resources");
        set => WithProperty("target_resources", value);
    }

    /// <summary>
    /// A list of service accounts indicating the sets of
    /// instances that are applied with this rule.
    /// </summary>
    public List<TerraformProperty<string>>? TargetServiceAccounts
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_service_accounts");
        set => WithProperty("target_service_accounts", value);
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// It can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public TerraformProperty<bool>? TlsInspect
    {
        get => GetProperty<TerraformProperty<bool>>("tls_inspect");
        set => WithProperty("tls_inspect", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallPolicyWithRulesTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_firewall_policy_with_rules resource.
/// </summary>
public class GoogleComputeFirewallPolicyWithRules : TerraformResource
{
    public GoogleComputeFirewallPolicyWithRules(string name) : base("google_compute_firewall_policy_with_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("policy_id");
        this.DeclareOutput("predefined_rules");
        this.DeclareOutput("rule_tuple_count");
        this.DeclareOutput("self_link");
        this.DeclareOutput("self_link_with_id");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The parent of this FirewallPolicy in the Cloud Resource Hierarchy.
    /// Format: organizations/{organization_id} or folders/{folder_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// A textual name of the security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformProperty<string> ShortName
    {
        get => GetProperty<TerraformProperty<string>>("short_name");
        set => this.WithProperty("short_name", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public List<GoogleComputeFirewallPolicyWithRulesRuleBlock>? Rule
    {
        get => GetProperty<List<GoogleComputeFirewallPolicyWithRulesRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeFirewallPolicyWithRulesTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeFirewallPolicyWithRulesTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of the resource. This field is used internally during updates of this resource.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression PolicyId => this["policy_id"];

    /// <summary>
    /// A list of pre-define firewall policy rules.
    /// </summary>
    public TerraformExpression PredefinedRules => this["predefined_rules"];

    /// <summary>
    /// Total count of all firewall policy rule tuples. A firewall policy can not exceed a set number of tuples.
    /// </summary>
    public TerraformExpression RuleTupleCount => this["rule_tuple_count"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformExpression SelfLinkWithId => this["self_link_with_id"];

}
