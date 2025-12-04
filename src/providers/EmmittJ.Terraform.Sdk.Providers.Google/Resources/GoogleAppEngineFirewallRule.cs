using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAppEngineFirewallRule.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineFirewallRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_app_engine_firewall_rule Terraform resource.
/// Manages a google_app_engine_firewall_rule resource.
/// </summary>
public partial class GoogleAppEngineFirewallRule(string name) : TerraformResource("google_app_engine_firewall_rule", name)
{
    /// <summary>
    /// The action to take if this rule matches. Possible values: [&amp;quot;UNSPECIFIED_ACTION&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// An optional string description of this rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A positive integer that defines the order of rule evaluation.
    /// Rules with the lowest priority are evaluated first.
    /// 
    /// A default rule at priority Int32.MaxValue matches all IPv4 and
    /// IPv6 traffic when no previous rule matches. Only the action of
    /// this rule can be modified by the user.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRange is required")]
    public required TerraformValue<string> SourceRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_range");
        set => SetArgument("source_range", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineFirewallRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineFirewallRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
