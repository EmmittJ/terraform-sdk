using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rule in AzurermFirewallNetworkRuleCollection.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallNetworkRuleCollectionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_addresses attribute.
    /// </summary>
    public TerraformList<string>? DestinationAddresses
    {
        get => GetArgument<TerraformList<string>>("destination_addresses");
        set => SetArgument("destination_addresses", value);
    }

    /// <summary>
    /// The destination_fqdns attribute.
    /// </summary>
    public TerraformList<string>? DestinationFqdns
    {
        get => GetArgument<TerraformList<string>>("destination_fqdns");
        set => SetArgument("destination_fqdns", value);
    }

    /// <summary>
    /// The destination_ip_groups attribute.
    /// </summary>
    public TerraformList<string>? DestinationIpGroups
    {
        get => GetArgument<TerraformList<string>>("destination_ip_groups");
        set => SetArgument("destination_ip_groups", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    public TerraformList<string>? DestinationPorts
    {
        get => GetArgument<TerraformList<string>>("destination_ports");
        set => SetArgument("destination_ports", value);
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
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public TerraformList<string>? Protocols
    {
        get => GetArgument<TerraformList<string>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    public TerraformList<string>? SourceAddresses
    {
        get => GetArgument<TerraformList<string>>("source_addresses");
        set => SetArgument("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public TerraformList<string>? SourceIpGroups
    {
        get => GetArgument<TerraformList<string>>("source_ip_groups");
        set => SetArgument("source_ip_groups", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFirewallNetworkRuleCollection.
/// Nesting mode: single
/// </summary>
public class AzurermFirewallNetworkRuleCollectionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_firewall_network_rule_collection Terraform resource.
/// Manages a azurerm_firewall_network_rule_collection resource.
/// </summary>
public partial class AzurermFirewallNetworkRuleCollection(string name) : TerraformResource("azurerm_firewall_network_rule_collection", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The azure_firewall_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureFirewallName is required")]
    public required TerraformValue<string> AzureFirewallName
    {
        get => GetRequiredArgument<TerraformValue<string>>("azure_firewall_name");
        set => SetArgument("azure_firewall_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
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
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AzurermFirewallNetworkRuleCollectionRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AzurermFirewallNetworkRuleCollectionRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFirewallNetworkRuleCollectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFirewallNetworkRuleCollectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
