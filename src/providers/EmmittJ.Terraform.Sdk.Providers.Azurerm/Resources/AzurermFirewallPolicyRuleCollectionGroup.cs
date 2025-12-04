using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for application_rule_collection in AzurermFirewallPolicyRuleCollectionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_rule_collection";

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
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlock : TerraformBlock
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
    /// The destination_fqdn_tags attribute.
    /// </summary>
    public TerraformList<string>? DestinationFqdnTags
    {
        get => GetArgument<TerraformList<string>>("destination_fqdn_tags");
        set => SetArgument("destination_fqdn_tags", value);
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
    /// The destination_urls attribute.
    /// </summary>
    public TerraformList<string>? DestinationUrls
    {
        get => GetArgument<TerraformList<string>>("destination_urls");
        set => SetArgument("destination_urls", value);
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

    /// <summary>
    /// The terminate_tls attribute.
    /// </summary>
    public TerraformValue<bool>? TerminateTls
    {
        get => GetArgument<TerraformValue<bool>>("terminate_tls");
        set => SetArgument("terminate_tls", value);
    }

    /// <summary>
    /// The web_categories attribute.
    /// </summary>
    public TerraformList<string>? WebCategories
    {
        get => GetArgument<TerraformList<string>>("web_categories");
        set => SetArgument("web_categories", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

    /// <summary>
    /// Protocols block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlockProtocolsBlock>? Protocols
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlockProtocolsBlock>>("protocols");
        set => SetArgument("protocols", value);
    }

}

/// <summary>
/// Block type for http_headers in AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for protocols in AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlockRuleBlockProtocolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocols";

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for nat_rule_collection in AzurermFirewallPolicyRuleCollectionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nat_rule_collection";

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
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlockRuleBlock : TerraformBlock
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
    /// The destination_address attribute.
    /// </summary>
    public TerraformValue<string>? DestinationAddress
    {
        get => GetArgument<TerraformValue<string>>("destination_address");
        set => SetArgument("destination_address", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
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

    /// <summary>
    /// The translated_address attribute.
    /// </summary>
    public TerraformValue<string>? TranslatedAddress
    {
        get => GetArgument<TerraformValue<string>>("translated_address");
        set => SetArgument("translated_address", value);
    }

    /// <summary>
    /// The translated_fqdn attribute.
    /// </summary>
    public TerraformValue<string>? TranslatedFqdn
    {
        get => GetArgument<TerraformValue<string>>("translated_fqdn");
        set => SetArgument("translated_fqdn", value);
    }

    /// <summary>
    /// The translated_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TranslatedPort is required")]
    public required TerraformValue<double> TranslatedPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("translated_port");
        set => SetArgument("translated_port", value);
    }

}


/// <summary>
/// Block type for network_rule_collection in AzurermFirewallPolicyRuleCollectionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_rule_collection";

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
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlockRuleBlock : TerraformBlock
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
/// Block type for timeouts in AzurermFirewallPolicyRuleCollectionGroup.
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_firewall_policy_rule_collection_group Terraform resource.
/// Manages a azurerm_firewall_policy_rule_collection_group resource.
/// </summary>
public partial class AzurermFirewallPolicyRuleCollectionGroup(string name) : TerraformResource("azurerm_firewall_policy_rule_collection_group", name)
{
    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyId is required")]
    public required TerraformValue<string> FirewallPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
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
    /// ApplicationRuleCollection block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock>? ApplicationRuleCollection
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock>>("application_rule_collection");
        set => SetArgument("application_rule_collection", value);
    }

    /// <summary>
    /// NatRuleCollection block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock>? NatRuleCollection
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock>>("nat_rule_collection");
        set => SetArgument("nat_rule_collection", value);
    }

    /// <summary>
    /// NetworkRuleCollection block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock>? NetworkRuleCollection
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock>>("network_rule_collection");
        set => SetArgument("network_rule_collection", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFirewallPolicyRuleCollectionGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFirewallPolicyRuleCollectionGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
