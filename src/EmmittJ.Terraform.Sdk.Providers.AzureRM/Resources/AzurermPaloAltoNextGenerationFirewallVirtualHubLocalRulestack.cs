using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for destination_nat in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The azure_dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AzureDnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("azure_dns_servers");
        set => WithProperty("azure_dns_servers", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_servers");
        set => WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    public TerraformProperty<bool>? UseAzureDns
    {
        get => GetProperty<TerraformProperty<bool>>("use_azure_dns");
        set => WithProperty("use_azure_dns", value);
    }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// The egress_nat_ip_address_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EgressNatIpAddressIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("egress_nat_ip_address_ids");
        set => WithProperty("egress_nat_ip_address_ids", value);
    }

    /// <summary>
    /// The egress_nat_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EgressNatIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("egress_nat_ip_addresses");
        set => WithProperty("egress_nat_ip_addresses", value);
    }

    /// <summary>
    /// The ip_of_trust_for_user_defined_routes attribute.
    /// </summary>
    public TerraformProperty<string>? IpOfTrustForUserDefinedRoutes
    {
        get => GetProperty<TerraformProperty<string>>("ip_of_trust_for_user_defined_routes");
        set => WithProperty("ip_of_trust_for_user_defined_routes", value);
    }

    /// <summary>
    /// The network_virtual_appliance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkVirtualApplianceId is required")]
    public required TerraformProperty<string> NetworkVirtualApplianceId
    {
        get => GetProperty<TerraformProperty<string>>("network_virtual_appliance_id");
        set => WithProperty("network_virtual_appliance_id", value);
    }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    public List<TerraformProperty<string>>? PublicIpAddressIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_ip_address_ids");
        set => WithProperty("public_ip_address_ids", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_ip_addresses");
        set => WithProperty("public_ip_addresses", value);
    }

    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedAddressRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_address_ranges");
        set => WithProperty("trusted_address_ranges", value);
    }

    /// <summary>
    /// The trusted_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrustedSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("trusted_subnet_id");
        set => WithProperty("trusted_subnet_id", value);
    }

    /// <summary>
    /// The untrusted_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? UntrustedSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("untrusted_subnet_id");
        set => WithProperty("untrusted_subnet_id", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => WithProperty("virtual_hub_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack resource.
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    public TerraformProperty<string>? MarketplaceOfferId
    {
        get => GetProperty<TerraformProperty<string>>("marketplace_offer_id");
        set => this.WithProperty("marketplace_offer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlanId
    {
        get => GetProperty<TerraformProperty<string>>("plan_id");
        set => this.WithProperty("plan_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetProperty<TerraformProperty<string>>("rulestack_id");
        set => this.WithProperty("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for destination_nat.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock>? DestinationNat
    {
        get => GetProperty<List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock>>("destination_nat");
        set => this.WithProperty("destination_nat", value);
    }

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock>? DnsSettings
    {
        get => GetProperty<List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock>>("dns_settings");
        set => this.WithProperty("dns_settings", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock>? NetworkProfile
    {
        get => GetProperty<List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock>>("network_profile");
        set => this.WithProperty("network_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
