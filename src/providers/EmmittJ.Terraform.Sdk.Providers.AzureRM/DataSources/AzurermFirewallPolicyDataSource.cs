using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFirewallPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformArgument("base_policy_id")]
    public TerraformValue<string> BasePolicyId
    {
        get => new TerraformReference<string>(this, "base_policy_id");
    }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformArgument("child_policies")]
    public TerraformList<string> ChildPolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "child_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns attribute.
    /// </summary>
    [TerraformArgument("dns")]
    public TerraformList<object> Dns
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "dns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformArgument("firewalls")]
    public TerraformList<string> Firewalls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "firewalls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformArgument("rule_collection_groups")]
    public TerraformList<string> RuleCollectionGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rule_collection_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    [TerraformArgument("threat_intelligence_allowlist")]
    public TerraformList<object> ThreatIntelligenceAllowlist
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "threat_intelligence_allowlist").ResolveNodes(ctx));
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformArgument("threat_intelligence_mode")]
    public TerraformValue<string> ThreatIntelligenceMode
    {
        get => new TerraformReference<string>(this, "threat_intelligence_mode");
    }

}
