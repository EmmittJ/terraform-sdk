using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeGlobalNetworkEndpointGroup.
/// Nesting mode: single
/// </summary>
public class GoogleComputeGlobalNetworkEndpointGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_global_network_endpoint_group Terraform resource.
/// Manages a google_compute_global_network_endpoint_group resource.
/// </summary>
public partial class GoogleComputeGlobalNetworkEndpointGroup(string name) : TerraformResource("google_compute_global_network_endpoint_group", name)
{
    /// <summary>
    /// The default port used if the port number is not specified in the
    /// network endpoint.
    /// </summary>
    public TerraformValue<double>? DefaultPort
    {
        get => GetArgument<TerraformValue<double>>("default_port");
        set => SetArgument("default_port", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Possible values: [&amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkEndpointType is required")]
    public required TerraformValue<string> NetworkEndpointType
    {
        get => GetArgument<TerraformValue<string>>("network_endpoint_type");
        set => SetArgument("network_endpoint_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeGlobalNetworkEndpointGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeGlobalNetworkEndpointGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
