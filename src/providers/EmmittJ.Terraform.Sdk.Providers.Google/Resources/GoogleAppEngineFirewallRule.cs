using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineFirewallRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_firewall_rule resource.
/// </summary>
public partial class GoogleAppEngineFirewallRule : TerraformResource
{
    public GoogleAppEngineFirewallRule(string name) : base("google_app_engine_firewall_rule", name)
    {
    }

    /// <summary>
    /// The action to take if this rule matches. Possible values: [&amp;quot;UNSPECIFIED_ACTION&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// An optional string description of this rule.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A positive integer that defines the order of rule evaluation.
    /// Rules with the lowest priority are evaluated first.
    /// 
    /// A default rule at priority Int32.MaxValue matches all IPv4 and
    /// IPv6 traffic when no previous rule matches. Only the action of
    /// this rule can be modified by the user.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRange is required")]
    [TerraformProperty("source_range")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAppEngineFirewallRuleTimeoutsBlock>? Timeouts { get; set; }

}
