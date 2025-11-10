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
        SetOutput("action");
        SetOutput("description");
        SetOutput("id");
        SetOutput("priority");
        SetOutput("project");
        SetOutput("source_range");
    }

    /// <summary>
    /// The action to take if this rule matches. Possible values: [&amp;quot;UNSPECIFIED_ACTION&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// An optional string description of this rule.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// A positive integer that defines the order of rule evaluation.
    /// Rules with the lowest priority are evaluated first.
    /// 
    /// A default rule at priority Int32.MaxValue matches all IPv4 and
    /// IPv6 traffic when no previous rule matches. Only the action of
    /// this rule can be modified by the user.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
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
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRange is required")]
    public required TerraformProperty<string> SourceRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_range");
        set => SetProperty("source_range", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineFirewallRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
