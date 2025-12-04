using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for destination_nat in AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// BackendConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendConfig block(s) allowed")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlockBackendConfigBlock>? BackendConfig
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlockBackendConfigBlock>>("backend_config");
        set => SetArgument("backend_config", value);
    }

    /// <summary>
    /// FrontendConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendConfig block(s) allowed")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlockFrontendConfigBlock>? FrontendConfig
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlockFrontendConfigBlock>>("frontend_config");
        set => SetArgument("frontend_config", value);
    }

}

/// <summary>
/// Block type for backend_config in AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlockBackendConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddress is required")]
    public required TerraformValue<string> PublicIpAddress
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address");
        set => SetArgument("public_ip_address", value);
    }

}

/// <summary>
/// Block type for frontend_config in AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlockFrontendConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    public required TerraformValue<string> PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

}


/// <summary>
/// Block type for dns_settings in AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_settings";

    /// <summary>
    /// The azure_dns_servers attribute.
    /// </summary>
    public TerraformList<string> AzureDnsServers
        => AsReference("azure_dns_servers");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers");
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    public TerraformValue<bool>? UseAzureDns
    {
        get => GetArgument<TerraformValue<bool>>("use_azure_dns");
        set => SetArgument("use_azure_dns", value);
    }

}


/// <summary>
/// Block type for network_profile in AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfileBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("egress_nat_ip_address_ids");
        set => SetArgument("egress_nat_ip_address_ids", value);
    }

    /// <summary>
    /// The egress_nat_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> EgressNatIpAddresses
        => AsReference("egress_nat_ip_addresses");

    /// <summary>
    /// The ip_of_trust_for_user_defined_routes attribute.
    /// </summary>
    public TerraformValue<string> IpOfTrustForUserDefinedRoutes
        => AsReference("ip_of_trust_for_user_defined_routes");

    /// <summary>
    /// The network_virtual_appliance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkVirtualApplianceId is required")]
    public required TerraformValue<string> NetworkVirtualApplianceId
    {
        get => GetArgument<TerraformValue<string>>("network_virtual_appliance_id");
        set => SetArgument("network_virtual_appliance_id", value);
    }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    public TerraformList<string>? PublicIpAddressIds
    {
        get => GetArgument<TerraformList<string>>("public_ip_address_ids");
        set => SetArgument("public_ip_address_ids", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PublicIpAddresses
        => AsReference("public_ip_addresses");

    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    public TerraformList<string>? TrustedAddressRanges
    {
        get => GetArgument<TerraformList<string>>("trusted_address_ranges");
        set => SetArgument("trusted_address_ranges", value);
    }

    /// <summary>
    /// The trusted_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> TrustedSubnetId
        => AsReference("trusted_subnet_id");

    /// <summary>
    /// The untrusted_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> UntrustedSubnetId
        => AsReference("untrusted_subnet_id");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => GetArgument<TerraformValue<string>>("virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama.
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_palo_alto_next_generation_firewall_virtual_hub_panorama Terraform resource.
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_hub_panorama resource.
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualHubPanorama(string name) : TerraformResource("azurerm_palo_alto_next_generation_firewall_virtual_hub_panorama", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    public TerraformValue<string>? MarketplaceOfferId
    {
        get => GetArgument<TerraformValue<string>>("marketplace_offer_id");
        set => SetArgument("marketplace_offer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The panorama_base64_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PanoramaBase64Config is required")]
    public required TerraformValue<string> PanoramaBase64Config
    {
        get => GetArgument<TerraformValue<string>>("panorama_base64_config");
        set => SetArgument("panorama_base64_config", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformValue<string>? PlanId
    {
        get => GetArgument<TerraformValue<string>>("plan_id");
        set => SetArgument("plan_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The panorama attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Panorama
        => AsReference("panorama");

    /// <summary>
    /// DestinationNat block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlock>? DestinationNat
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNatBlock>>("destination_nat");
        set => SetArgument("destination_nat", value);
    }

    /// <summary>
    /// DnsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettingsBlock>? DnsSettings
    {
        get => GetArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettingsBlock>>("dns_settings");
        set => SetArgument("dns_settings", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public required TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfileBlock> NetworkProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfileBlock>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoNextGenerationFirewallVirtualHubPanoramaTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
