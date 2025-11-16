using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_firewall_policy Terraform data source.
/// Retrieves information about a azurerm_firewall_policy.
/// </summary>
public partial class AzurermFirewallPolicyDataSource(string name) : TerraformDataSource("azurerm_firewall_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformValue<string> BasePolicyId
    {
        get => new TerraformReference<string>(this, "base_policy_id");
    }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformList<string> ChildPolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "child_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Dns
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformList<string> Firewalls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "firewalls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformList<string> RuleCollectionGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rule_collection_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ThreatIntelligenceAllowlist
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "threat_intelligence_allowlist").ResolveNodes(ctx));
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformValue<string> ThreatIntelligenceMode
    {
        get => new TerraformReference<string>(this, "threat_intelligence_mode");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFirewallPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFirewallPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
