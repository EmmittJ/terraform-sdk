using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for frontend_ip_configuration in AzurermLb.
/// Nesting mode: list
/// </summary>
public class AzurermLbFrontendIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_ip_configuration";

    /// <summary>
    /// The gateway_load_balancer_frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string>? GatewayLoadBalancerFrontendIpConfigurationId
    {
        get => GetArgument<TerraformValue<string>>("gateway_load_balancer_frontend_ip_configuration_id");
        set => SetArgument("gateway_load_balancer_frontend_ip_configuration_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    public TerraformSet<string> InboundNatRules
        => AsReference("inbound_nat_rules");

    /// <summary>
    /// The load_balancer_rules attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancerRules
        => AsReference("load_balancer_rules");

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
    /// The outbound_rules attribute.
    /// </summary>
    public TerraformSet<string> OutboundRules
        => AsReference("outbound_rules");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressVersion
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address_version");
        set => SetArgument("private_ip_address_version", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpPrefixId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_prefix_id");
        set => SetArgument("public_ip_prefix_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLb.
/// Nesting mode: single
/// </summary>
public class AzurermLbTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_lb Terraform resource.
/// Manages a azurerm_lb resource.
/// </summary>
public partial class AzurermLb(string name) : TerraformResource("azurerm_lb", name)
{
    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => GetArgument<TerraformValue<string>>("edge_zone");
        set => SetArgument("edge_zone", value);
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => GetArgument<TerraformValue<string>>("public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string>? SkuTier
    {
        get => GetArgument<TerraformValue<string>>("sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => AsReference("private_ip_addresses");

    /// <summary>
    /// FrontendIpConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLbFrontendIpConfigurationBlock>? FrontendIpConfiguration
    {
        get => GetArgument<TerraformList<AzurermLbFrontendIpConfigurationBlock>>("frontend_ip_configuration");
        set => SetArgument("frontend_ip_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
