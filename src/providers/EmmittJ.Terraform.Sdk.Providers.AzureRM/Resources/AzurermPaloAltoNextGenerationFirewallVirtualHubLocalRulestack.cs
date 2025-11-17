using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for destination_nat in AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack.
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

    /// <summary>
    /// BackendConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendConfig block(s) allowed")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlockBackendConfigBlock>? BackendConfig
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlockBackendConfigBlock>>("backend_config");
        set => SetArgument("backend_config", value);
    }

    /// <summary>
    /// FrontendConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendConfig block(s) allowed")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlockFrontendConfigBlock>? FrontendConfig
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlockFrontendConfigBlock>>("frontend_config");
        set => SetArgument("frontend_config", value);
    }

}

/// <summary>
/// Block type for backend_config in AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlockBackendConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_config";

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
    /// The public_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddress is required")]
    public required TerraformValue<string> PublicIpAddress
    {
        get => new TerraformReference<string>(this, "public_ip_address");
        set => SetArgument("public_ip_address", value);
    }

}

/// <summary>
/// Block type for frontend_config in AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlockFrontendConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_config";

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
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    public required TerraformValue<string> PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

}


/// <summary>
/// Block type for dns_settings in AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock : TerraformBlock
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
/// Block type for network_profile in AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack.
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
    /// The ip_of_trust_for_user_defined_routes attribute.
    /// </summary>
    public TerraformValue<string> IpOfTrustForUserDefinedRoutes
    {
        get => new TerraformReference<string>(this, "ip_of_trust_for_user_defined_routes");
    }

    /// <summary>
    /// The network_virtual_appliance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkVirtualApplianceId is required")]
    public required TerraformValue<string> NetworkVirtualApplianceId
    {
        get => new TerraformReference<string>(this, "network_virtual_appliance_id");
        set => SetArgument("network_virtual_appliance_id", value);
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

    /// <summary>
    /// The trusted_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> TrustedSubnetId
    {
        get => new TerraformReference<string>(this, "trusted_subnet_id");
    }

    /// <summary>
    /// The untrusted_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> UntrustedSubnetId
    {
        get => new TerraformReference<string>(this, "untrusted_subnet_id");
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack.
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
/// Represents a azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack Terraform resource.
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack resource.
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack(string name) : TerraformResource("azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack", name)
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
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock>? DestinationNat
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock>>("destination_nat");
        set => SetArgument("destination_nat", value);
    }

    /// <summary>
    /// DnsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock>? DnsSettings
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock>>("dns_settings");
        set => SetArgument("dns_settings", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public required TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock> NetworkProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
