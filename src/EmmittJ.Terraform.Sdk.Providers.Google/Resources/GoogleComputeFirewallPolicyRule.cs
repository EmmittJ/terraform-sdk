using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_firewall_policy_rule resource.
/// </summary>
public class GoogleComputeFirewallPolicyRule : TerraformResource
{
    public GoogleComputeFirewallPolicyRule(string name) : base("google_compute_firewall_policy_rule", name)
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
    public TerraformLiteralProperty<string>? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// An optional description for this resource.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The direction in which this rule applies. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? Direction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direction");
        set => this.WithProperty("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall policy rule is disabled.
    /// When set to true, the firewall policy rule is not enforced and traffic behaves as if it did not exist.
    /// If this is unspecified, the firewall policy rule will be enabled.
    /// </summary>
    public TerraformLiteralProperty<bool>? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the configured export destination in Stackdriver.
    /// Logs may be exported to BigQuery or Pub/Sub.
    /// Note: you cannot enable logging on &amp;quot;goto_next&amp;quot; rules.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    public TerraformLiteralProperty<string>? FirewallPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_policy");
        set => this.WithProperty("firewall_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest prority.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// A fully-qualified URL of a SecurityProfile resource instance.
    /// Example: https://networksecurity.googleapis.com/v1/projects/{project}/locations/{location}/securityProfileGroups/my-security-profile-group
    /// Must be specified if action = &#39;apply_security_profile_group&#39; and cannot be specified for other actions.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityProfileGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_profile_group");
        set => this.WithProperty("security_profile_group", value);
    }

    /// <summary>
    /// A list of network resource URLs to which this rule applies.
    /// This field allows you to control which network&#39;s VMs get this rule.
    /// If this field is left blank, all VMs within the organization will receive the rule.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? TargetResources
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_resources");
        set => this.WithProperty("target_resources", value);
    }

    /// <summary>
    /// A list of service accounts indicating the sets of instances that are applied with this rule.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? TargetServiceAccounts
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_service_accounts");
        set => this.WithProperty("target_service_accounts", value);
    }

    /// <summary>
    /// Boolean flag indicating if the traffic should be TLS decrypted.
    /// Can be set only if action = &#39;apply_security_profile_group&#39; and cannot be set for other actions.
    /// </summary>
    public TerraformLiteralProperty<bool>? TlsInspect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_inspect");
        set => this.WithProperty("tls_inspect", value);
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
