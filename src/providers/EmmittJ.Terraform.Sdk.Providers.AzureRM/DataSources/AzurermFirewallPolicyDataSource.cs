using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_firewall_policy.
/// </summary>
public class AzurermFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermFirewallPolicyDataSource(string name) : base("azurerm_firewall_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFirewallPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("base_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BasePolicyId => new TerraformReference(this, "base_policy_id");

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformPropertyName("child_policies")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ChildPolicies => new TerraformReference(this, "child_policies");

    /// <summary>
    /// The dns attribute.
    /// </summary>
    [TerraformPropertyName("dns")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Dns => new TerraformReference(this, "dns");

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformPropertyName("firewalls")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Firewalls => new TerraformReference(this, "firewalls");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformPropertyName("rule_collection_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<string> RuleCollectionGroups => new TerraformReference(this, "rule_collection_groups");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    [TerraformPropertyName("threat_intelligence_allowlist")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ThreatIntelligenceAllowlist => new TerraformReference(this, "threat_intelligence_allowlist");

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformPropertyName("threat_intelligence_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ThreatIntelligenceMode => new TerraformReference(this, "threat_intelligence_mode");

}
