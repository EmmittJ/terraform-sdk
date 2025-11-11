using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFirewallPolicyDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_firewall_policy.
/// </summary>
public partial class AzurermFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermFirewallPolicyDataSource(string name) : base("azurerm_firewall_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermFirewallPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformProperty("base_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BasePolicyId { get; }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformProperty("child_policies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ChildPolicies { get; }

    /// <summary>
    /// The dns attribute.
    /// </summary>
    [TerraformProperty("dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Dns { get; }

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformProperty("firewalls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Firewalls { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformProperty("rule_collection_groups")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> RuleCollectionGroups { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    [TerraformProperty("threat_intelligence_allowlist")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ThreatIntelligenceAllowlist { get; }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformProperty("threat_intelligence_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ThreatIntelligenceMode { get; }

}
