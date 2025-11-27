using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeRegionNetworkEndpoint.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkEndpointTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_region_network_endpoint Terraform resource.
/// Manages a google_compute_region_network_endpoint resource.
/// </summary>
public partial class GoogleComputeRegionNetworkEndpoint(string name) : TerraformResource("google_compute_region_network_endpoint", name)
{
    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    public TerraformValue<string>? Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
        set => SetArgument("fqdn", value);
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
    /// IPv4 address external endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_IP_PORT.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// Port number of network endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where the containing network endpoint group is located.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The network endpoint group this endpoint is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionNetworkEndpointGroup is required")]
    public required TerraformValue<string> RegionNetworkEndpointGroup
    {
        get => new TerraformReference<string>(this, "region_network_endpoint_group");
        set => SetArgument("region_network_endpoint_group", value);
    }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> NetworkEndpointId
    {
        get => new TerraformReference<double>(this, "network_endpoint_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionNetworkEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionNetworkEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
