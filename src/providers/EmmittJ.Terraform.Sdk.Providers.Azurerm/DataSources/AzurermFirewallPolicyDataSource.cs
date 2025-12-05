using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermFirewallPolicyDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformValue<string> BasePolicyId
        => CreateReference("base_policy_id");

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformList<string> ChildPolicies
        => CreateReference("child_policies");

    /// <summary>
    /// The dns attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Dns
        => CreateReference("dns");

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformList<string> Firewalls
        => CreateReference("firewalls");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformList<string> RuleCollectionGroups
        => CreateReference("rule_collection_groups");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ThreatIntelligenceAllowlist
        => CreateReference("threat_intelligence_allowlist");

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformValue<string> ThreatIntelligenceMode
        => CreateReference("threat_intelligence_mode");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFirewallPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFirewallPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
