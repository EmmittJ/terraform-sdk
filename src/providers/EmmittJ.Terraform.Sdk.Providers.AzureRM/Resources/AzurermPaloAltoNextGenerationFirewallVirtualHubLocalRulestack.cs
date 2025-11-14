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
/// Block type for destination_nat in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_nat";

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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
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
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_settings";


    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    [TerraformArgument("use_azure_dns")]
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
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// The egress_nat_ip_address_ids attribute.
    /// </summary>
    [TerraformArgument("egress_nat_ip_address_ids")]
    public TerraformList<string>? EgressNatIpAddressIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "egress_nat_ip_address_ids").ResolveNodes(ctx));
        set => SetArgument("egress_nat_ip_address_ids", value);
    }



    /// <summary>
    /// The network_virtual_appliance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkVirtualApplianceId is required")]
    [TerraformArgument("network_virtual_appliance_id")]
    public required TerraformValue<string> NetworkVirtualApplianceId
    {
        get => new TerraformReference<string>(this, "network_virtual_appliance_id");
        set => SetArgument("network_virtual_appliance_id", value);
    }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    [TerraformArgument("public_ip_address_ids")]
    public TerraformList<string>? PublicIpAddressIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "public_ip_address_ids").ResolveNodes(ctx));
        set => SetArgument("public_ip_address_ids", value);
    }


    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    [TerraformArgument("trusted_address_ranges")]
    public TerraformList<string>? TrustedAddressRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_address_ranges").ResolveNodes(ctx));
        set => SetArgument("trusted_address_ranges", value);
    }



    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    [TerraformArgument("virtual_hub_id")]
    public required TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack", name)
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
    /// The marketplace_offer_id attribute.
    /// </summary>
    [TerraformArgument("marketplace_offer_id")]
    public TerraformValue<string>? MarketplaceOfferId
    {
        get => new TerraformReference<string>(this, "marketplace_offer_id");
        set => SetArgument("marketplace_offer_id", value);
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
    /// The plan_id attribute.
    /// </summary>
    [TerraformArgument("plan_id")]
    public TerraformValue<string>? PlanId
    {
        get => new TerraformReference<string>(this, "plan_id");
        set => SetArgument("plan_id", value);
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
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformArgument("rulestack_id")]
    public required TerraformValue<string> RulestackId
    {
        get => new TerraformReference<string>(this, "rulestack_id");
        set => SetArgument("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for destination_nat.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("destination_nat")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock> DestinationNat { get; set; } = new();

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    [TerraformArgument("dns_settings")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock> DnsSettings { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformArgument("network_profile")]
    public required TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock> NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock Timeouts { get; set; } = new();

}
