using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_network_firewall_policy_rule resource.
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyRule : TerraformResource
{
    public GoogleComputeRegionNetworkFirewallPolicyRule(string name) : base("google_compute_region_network_firewall_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("kind");
        this.DeclareOutput("rule_tuple_count");
    }

    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Valid actions are &amp;quot;allow&amp;quot;, &amp;quot;deny&amp;quot;, &amp;quot;goto_next&amp;quot; and &amp;quot;apply_security_profile_group&amp;quot;.
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public string? Direction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direction")?.Value;
        set => this.WithProperty("direction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &amp;quot;goto_next&amp;quot; rules.
    /// </summary>
    public bool? EnableLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_logging")?.Value;
        set => this.WithProperty("enable_logging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    public string? FirewallPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_policy")?.Value;
        set => this.WithProperty("firewall_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of this resource.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional name for the rule. This field is not a unique identifier and can be updated.
    /// </summary>
    public string? RuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_name")?.Value;
        set => this.WithProperty("rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// 
    /// Security Profile Group and Firewall Policy Rule must be in the same scope.
    /// </summary>
    public string? SecurityProfileGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_profile_group")?.Value;
        set => this.WithProperty("security_profile_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    public List<string>? TargetServiceAccounts
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_service_accounts")?.Value;
        set => this.WithProperty("target_service_accounts", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public bool? TlsInspect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_inspect")?.Value;
        set => this.WithProperty("tls_inspect", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Type of the resource. Always &#39;compute#firewallPolicyRule&#39; for firewall policy rules
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// Calculation of the complexity of a single firewall policy rule.
    /// </summary>
    public TerraformExpression RuleTupleCount => this["rule_tuple_count"];

}
