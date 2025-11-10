using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFirewallPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("base_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BasePolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "base_policy_id");

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformPropertyName("child_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ChildPolicies => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "child_policies");

    /// <summary>
    /// The dns attribute.
    /// </summary>
    [TerraformPropertyName("dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Dns => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dns");

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformPropertyName("firewalls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Firewalls => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "firewalls");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformPropertyName("rule_collection_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> RuleCollectionGroups => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "rule_collection_groups");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    [TerraformPropertyName("threat_intelligence_allowlist")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ThreatIntelligenceAllowlist => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "threat_intelligence_allowlist");

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformPropertyName("threat_intelligence_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ThreatIntelligenceMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "threat_intelligence_mode");

}
