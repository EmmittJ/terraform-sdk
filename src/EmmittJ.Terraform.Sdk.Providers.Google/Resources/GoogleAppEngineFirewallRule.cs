using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineFirewallRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_app_engine_firewall_rule resource.
/// </summary>
public class GoogleAppEngineFirewallRule : TerraformResource
{
    public GoogleAppEngineFirewallRule(string name) : base("google_app_engine_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action to take if this rule matches. Possible values: [&amp;quot;UNSPECIFIED_ACTION&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// An optional string description of this rule.
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
    /// A positive integer that defines the order of rule evaluation.
    /// Rules with the lowest priority are evaluated first.
    /// 
    /// A default rule at priority Int32.MaxValue matches all IPv4 and
    /// IPv6 traffic when no previous rule matches. Only the action of
    /// this rule can be modified by the user.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRange is required")]
    public required TerraformProperty<string> SourceRange
    {
        get => GetProperty<TerraformProperty<string>>("source_range");
        set => this.WithProperty("source_range", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineFirewallRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAppEngineFirewallRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
