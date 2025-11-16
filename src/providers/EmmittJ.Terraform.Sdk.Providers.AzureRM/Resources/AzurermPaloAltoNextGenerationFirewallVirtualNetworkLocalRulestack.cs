using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for destination_nat in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_nat";

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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_settings";

    /// <summary>
    /// The azure_dns_servers attribute.
    /// </summary>
    public TerraformList<string> AzureDnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "azure_dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    public TerraformValue<bool>? UseAzureDns
    {
        get => new TerraformReference<bool>(this, "use_azure_dns");
        set => SetArgument("use_azure_dns", value);
    }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// The egress_nat_ip_address_ids attribute.
    /// </summary>
    public TerraformList<string>? EgressNatIpAddressIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "egress_nat_ip_address_ids").ResolveNodes(ctx));
        set => SetArgument("egress_nat_ip_address_ids", value);
    }

    /// <summary>
    /// The egress_nat_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> EgressNatIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "egress_nat_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    public TerraformList<string>? PublicIpAddressIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_address_ids").ResolveNodes(ctx));
        set => SetArgument("public_ip_address_ids", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    public TerraformList<string>? TrustedAddressRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_address_ranges").ResolveNodes(ctx));
        set => SetArgument("trusted_address_ranges", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack Terraform resource.
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack resource.
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(string name) : TerraformResource("azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack", name)
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
    /// The marketplace_offer_id attribute.
    /// </summary>
    public TerraformValue<string>? MarketplaceOfferId
    {
        get => new TerraformReference<string>(this, "marketplace_offer_id");
        set => SetArgument("marketplace_offer_id", value);
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
    /// The plan_id attribute.
    /// </summary>
    public TerraformValue<string>? PlanId
    {
        get => new TerraformReference<string>(this, "plan_id");
        set => SetArgument("plan_id", value);
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
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformValue<string> RulestackId
    {
        get => new TerraformReference<string>(this, "rulestack_id");
        set => SetArgument("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// DestinationNat block (nesting mode: list).
    /// </summary>
    public AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBlock? DestinationNat
    {
        get => GetArgument<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBlock>("destination_nat");
        set => SetArgument("destination_nat", value);
    }

    /// <summary>
    /// DnsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsBlock? DnsSettings
    {
        get => GetArgument<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsBlock>("dns_settings");
        set => SetArgument("dns_settings", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public required AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileBlock NetworkProfile
    {
        get => GetRequiredArgument<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileBlock>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
