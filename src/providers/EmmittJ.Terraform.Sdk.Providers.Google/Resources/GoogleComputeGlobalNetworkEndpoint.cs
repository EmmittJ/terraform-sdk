using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeGlobalNetworkEndpoint.
/// Nesting mode: single
/// </summary>
public class GoogleComputeGlobalNetworkEndpointTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_global_network_endpoint Terraform resource.
/// Manages a google_compute_global_network_endpoint resource.
/// </summary>
public partial class GoogleComputeGlobalNetworkEndpoint(string name) : TerraformResource("google_compute_global_network_endpoint", name)
{
    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    public TerraformValue<string>? Fqdn
    {
        get => GetArgument<TerraformValue<string>>("fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// The global network endpoint group this endpoint is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkEndpointGroup is required")]
    public required TerraformValue<string> GlobalNetworkEndpointGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("global_network_endpoint_group");
        set => SetArgument("global_network_endpoint_group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// IPv4 address external endpoint.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// Port number of the external endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeGlobalNetworkEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeGlobalNetworkEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
