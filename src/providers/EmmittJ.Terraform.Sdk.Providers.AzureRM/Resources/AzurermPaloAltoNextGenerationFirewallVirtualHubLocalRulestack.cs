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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
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
        set => SetProperty("azure_dns_servers", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        set => SetProperty("dns_servers", value);
    }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    public TerraformProperty<bool>? UseAzureDns
    {
        set => SetProperty("use_azure_dns", value);
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
        set => SetProperty("egress_nat_ip_address_ids", value);
    }

    /// <summary>
    /// The egress_nat_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EgressNatIpAddresses
    {
        set => SetProperty("egress_nat_ip_addresses", value);
    }

    /// <summary>
    /// The ip_of_trust_for_user_defined_routes attribute.
    /// </summary>
    public TerraformProperty<string>? IpOfTrustForUserDefinedRoutes
    {
        set => SetProperty("ip_of_trust_for_user_defined_routes", value);
    }

    /// <summary>
    /// The network_virtual_appliance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkVirtualApplianceId is required")]
    public required TerraformProperty<string> NetworkVirtualApplianceId
    {
        set => SetProperty("network_virtual_appliance_id", value);
    }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    public List<TerraformProperty<string>>? PublicIpAddressIds
    {
        set => SetProperty("public_ip_address_ids", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpAddresses
    {
        set => SetProperty("public_ip_addresses", value);
    }

    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedAddressRanges
    {
        set => SetProperty("trusted_address_ranges", value);
    }

    /// <summary>
    /// The trusted_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrustedSubnetId
    {
        set => SetProperty("trusted_subnet_id", value);
    }

    /// <summary>
    /// The untrusted_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? UntrustedSubnetId
    {
        set => SetProperty("untrusted_subnet_id", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        set => SetProperty("virtual_hub_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("marketplace_offer_id");
        SetOutput("name");
        SetOutput("plan_id");
        SetOutput("resource_group_name");
        SetOutput("rulestack_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    public TerraformProperty<string> MarketplaceOfferId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("marketplace_offer_id");
        set => SetProperty("marketplace_offer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformProperty<string> PlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plan_id");
        set => SetProperty("plan_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rulestack_id");
        set => SetProperty("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for destination_nat.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock>? DestinationNat
    {
        set => SetProperty("destination_nat", value);
    }

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock>? DnsSettings
    {
        set => SetProperty("dns_settings", value);
    }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public List<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock>? NetworkProfile
    {
        set => SetProperty("network_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
