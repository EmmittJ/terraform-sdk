using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsResolverInboundEndpointDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsResolverInboundEndpointDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_resolver_inbound_endpoint Terraform data source.
/// Retrieves information about a azurerm_private_dns_resolver_inbound_endpoint.
/// </summary>
public partial class AzurermPrivateDnsResolverInboundEndpointDataSource(string name) : TerraformDataSource("azurerm_private_dns_resolver_inbound_endpoint", name)
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
    /// The ip_configurations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfigurations
        => AsReference("ip_configurations");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsResolverInboundEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsResolverInboundEndpointDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
