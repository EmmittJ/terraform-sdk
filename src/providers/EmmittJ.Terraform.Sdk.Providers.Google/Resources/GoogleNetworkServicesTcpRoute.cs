using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleNetworkServicesTcpRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTcpRouteRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesTcpRouteRulesBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesTcpRouteRulesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Matches block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesTcpRouteRulesBlockMatchesBlock>? Matches
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesTcpRouteRulesBlockMatchesBlock>>("matches");
        set => SetArgument("matches", value);
    }

}

/// <summary>
/// Block type for action in GoogleNetworkServicesTcpRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTcpRouteRulesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Specifies the idle timeout for the selected route. The idle timeout is defined as the period in which there are no bytes sent or received on either the upstream or downstream connection. If not set, the default idle timeout is 30 seconds. If set to 0s, the timeout will be disabled.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? IdleTimeout
    {
        get => GetArgument<TerraformValue<string>>("idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

    /// <summary>
    /// If true, Router will use the destination IP and port of the original connection as the destination of the request.
    /// </summary>
    public TerraformValue<bool>? OriginalDestination
    {
        get => GetArgument<TerraformValue<bool>>("original_destination");
        set => SetArgument("original_destination", value);
    }

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesTcpRouteRulesBlockActionBlockDestinationsBlock>? Destinations
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesTcpRouteRulesBlockActionBlockDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

}

/// <summary>
/// Block type for destinations in GoogleNetworkServicesTcpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTcpRouteRulesBlockActionBlockDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// The URL of a BackendService to route traffic to.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports.
    /// If only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend.
    /// If weights are specified for any one service name, they need to be specified for all of them.
    /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for matches in GoogleNetworkServicesTcpRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTcpRouteRulesBlockMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matches";

    /// <summary>
    /// Must be specified in the CIDR range format. A CIDR range consists of an IP Address and a prefix length to construct the subnet mask.
    /// By default, the prefix length is 32 (i.e. matches a single IP address). Only IPV4 addresses are supported. Examples: &amp;quot;10.0.0.1&amp;quot; - matches against this exact IP address. &amp;quot;10.0.0.0/8&amp;quot; - matches against any IP address within the 10.0.0.0 subnet and 255.255.255.0 mask. &amp;quot;0.0.0.0/0&amp;quot; - matches against any IP address&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetRequiredArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// Specifies the destination port to match against.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<string> Port
    {
        get => GetRequiredArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesTcpRoute.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesTcpRouteTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_services_tcp_route Terraform resource.
/// Manages a google_network_services_tcp_route resource.
/// </summary>
public partial class GoogleNetworkServicesTcpRoute(string name) : TerraformResource("google_network_services_tcp_route", name)
{
    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Gateways defines a list of gateways this TcpRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// Each gateway reference should match the pattern: projects/*/locations/global/gateways/&amp;lt;gateway_name&amp;gt;
    /// </summary>
    public TerraformList<string>? Gateways
    {
        get => GetArgument<TerraformList<string>>("gateways");
        set => SetArgument("gateways", value);
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
    /// Set of label tags associated with the TcpRoute resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Meshes defines a list of meshes this TcpRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// Each mesh reference should match the pattern: projects/*/locations/global/meshes/&amp;lt;mesh_name&amp;gt;
    /// The attached Mesh should be of a type SIDECAR
    /// </summary>
    public TerraformList<string>? Meshes
    {
        get => GetArgument<TerraformList<string>>("meshes");
        set => SetArgument("meshes", value);
    }

    /// <summary>
    /// Name of the TcpRoute resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Time the TcpRoute was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Time the TcpRoute was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleNetworkServicesTcpRouteRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesTcpRouteRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesTcpRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesTcpRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
