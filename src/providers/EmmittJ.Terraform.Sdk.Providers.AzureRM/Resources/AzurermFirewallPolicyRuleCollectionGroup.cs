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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_addresses attribute.
    /// </summary>
    public TerraformList<string>? DestinationAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_addresses").ResolveNodes(ctx));
        set => SetArgument("destination_addresses", value);
    }

    /// <summary>
    /// The destination_fqdn_tags attribute.
    /// </summary>
    public TerraformList<string>? DestinationFqdnTags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_fqdn_tags").ResolveNodes(ctx));
        set => SetArgument("destination_fqdn_tags", value);
    }

    /// <summary>
    /// The destination_fqdns attribute.
    /// </summary>
    public TerraformList<string>? DestinationFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_fqdns").ResolveNodes(ctx));
        set => SetArgument("destination_fqdns", value);
    }

    /// <summary>
    /// The destination_urls attribute.
    /// </summary>
    public TerraformList<string>? DestinationUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_urls").ResolveNodes(ctx));
        set => SetArgument("destination_urls", value);
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
    /// The source_addresses attribute.
    /// </summary>
    public TerraformList<string>? SourceAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_addresses").ResolveNodes(ctx));
        set => SetArgument("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public TerraformList<string>? SourceIpGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_ip_groups").ResolveNodes(ctx));
        set => SetArgument("source_ip_groups", value);
    }

    /// <summary>
    /// The terminate_tls attribute.
    /// </summary>
    public TerraformValue<bool>? TerminateTls
    {
        get => new TerraformReference<bool>(this, "terminate_tls");
        set => SetArgument("terminate_tls", value);
    }

    /// <summary>
    /// The web_categories attribute.
    /// </summary>
    public TerraformList<string>? WebCategories
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "web_categories").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    public TerraformValue<string>? DestinationAddress
    {
        get => new TerraformReference<string>(this, "destination_address");
        set => SetArgument("destination_address", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    public TerraformList<string>? DestinationPorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_ports").ResolveNodes(ctx));
        set => SetArgument("destination_ports", value);
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
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public TerraformList<string>? Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    public TerraformList<string>? SourceAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_addresses").ResolveNodes(ctx));
        set => SetArgument("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public TerraformList<string>? SourceIpGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_ip_groups").ResolveNodes(ctx));
        set => SetArgument("source_ip_groups", value);
    }

    /// <summary>
    /// The translated_address attribute.
    /// </summary>
    public TerraformValue<string>? TranslatedAddress
    {
        get => new TerraformReference<string>(this, "translated_address");
        set => SetArgument("translated_address", value);
    }

    /// <summary>
    /// The translated_fqdn attribute.
    /// </summary>
    public TerraformValue<string>? TranslatedFqdn
    {
        get => new TerraformReference<string>(this, "translated_fqdn");
        set => SetArgument("translated_fqdn", value);
    }

    /// <summary>
    /// The translated_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TranslatedPort is required")]
    public required TerraformValue<double> TranslatedPort
    {
        get => new TerraformReference<double>(this, "translated_port");
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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_addresses attribute.
    /// </summary>
    public TerraformList<string>? DestinationAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_addresses").ResolveNodes(ctx));
        set => SetArgument("destination_addresses", value);
    }

    /// <summary>
    /// The destination_fqdns attribute.
    /// </summary>
    public TerraformList<string>? DestinationFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_fqdns").ResolveNodes(ctx));
        set => SetArgument("destination_fqdns", value);
    }

    /// <summary>
    /// The destination_ip_groups attribute.
    /// </summary>
    public TerraformList<string>? DestinationIpGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_ip_groups").ResolveNodes(ctx));
        set => SetArgument("destination_ip_groups", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    public TerraformList<string>? DestinationPorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_ports").ResolveNodes(ctx));
        set => SetArgument("destination_ports", value);
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
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public TerraformList<string>? Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    public TerraformList<string>? SourceAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_addresses").ResolveNodes(ctx));
        set => SetArgument("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public TerraformList<string>? SourceIpGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_ip_groups").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
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
