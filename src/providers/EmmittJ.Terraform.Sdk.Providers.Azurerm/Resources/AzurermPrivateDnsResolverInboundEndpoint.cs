using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_configurations in AzurermPrivateDnsResolverInboundEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermPrivateDnsResolverInboundEndpointIpConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configurations";

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_allocation_method attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAllocationMethod
    {
        get => GetArgument<TerraformValue<string>>("private_ip_allocation_method");
        set => SetArgument("private_ip_allocation_method", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPrivateDnsResolverInboundEndpoint.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsResolverInboundEndpointTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_private_dns_resolver_inbound_endpoint Terraform resource.
/// Manages a azurerm_private_dns_resolver_inbound_endpoint resource.
/// </summary>
public partial class AzurermPrivateDnsResolverInboundEndpoint(string name) : TerraformResource("azurerm_private_dns_resolver_inbound_endpoint", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_dns_resolver_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsResolverId is required")]
    public required TerraformValue<string> PrivateDnsResolverId
    {
        get => GetArgument<TerraformValue<string>>("private_dns_resolver_id");
        set => SetArgument("private_dns_resolver_id", value);
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
    /// IpConfigurations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfigurations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfigurations block(s) allowed")]
    public required TerraformList<AzurermPrivateDnsResolverInboundEndpointIpConfigurationsBlock> IpConfigurations
    {
        get => GetRequiredArgument<TerraformList<AzurermPrivateDnsResolverInboundEndpointIpConfigurationsBlock>>("ip_configurations");
        set => SetArgument("ip_configurations", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsResolverInboundEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsResolverInboundEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
