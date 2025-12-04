using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for extension_chains in GoogleNetworkServicesLbRouteExtension.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension_chains";

    /// <summary>
    /// The name for this extension chain. The name is logged as part of the HTTP request logs.
    /// The name must conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens,
    /// and can have a maximum length of 63 characters. Additionally, the first character must be a letter
    /// and the last character must be a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Extensions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extensions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Extensions block(s) required")]
    public required TerraformList<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlockExtensionsBlock> Extensions
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlockExtensionsBlock>>("extensions");
        set => SetArgument("extensions", value);
    }

    /// <summary>
    /// MatchCondition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchCondition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchCondition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MatchCondition block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlockMatchConditionBlock> MatchCondition
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlockMatchConditionBlock>>("match_condition");
        set => SetArgument("match_condition", value);
    }

}

/// <summary>
/// Block type for extensions in GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesLbRouteExtensionExtensionChainsBlockExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extensions";

    /// <summary>
    /// The :authority header in the gRPC request sent from Envoy to the extension service.
    /// </summary>
    public TerraformValue<string>? Authority
    {
        get => GetArgument<TerraformValue<string>>("authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// Determines how the proxy behaves if the call to the extension fails or times out.
    /// When set to TRUE, request or response processing continues without error.
    /// Any subsequent extensions in the extension chain are also executed.
    /// When set to FALSE: * If response headers have not been delivered to the downstream client,
    /// a generic 500 error is returned to the client. The error response can be tailored by
    /// configuring a custom error response in the load balancer.
    /// </summary>
    public TerraformValue<bool>? FailOpen
    {
        get => GetArgument<TerraformValue<bool>>("fail_open");
        set => SetArgument("fail_open", value);
    }

    /// <summary>
    /// List of the HTTP headers to forward to the extension (from the client or backend).
    /// If omitted, all headers are sent. Each element is a string indicating the header name.
    /// </summary>
    public TerraformList<string>? ForwardHeaders
    {
        get => GetArgument<TerraformList<string>>("forward_headers");
        set => SetArgument("forward_headers", value);
    }

    /// <summary>
    /// The name for this extension. The name is logged as part of the HTTP request logs.
    /// The name must conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens,
    /// and can have a maximum length of 63 characters. Additionally, the first character must be a letter
    /// and the last a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The reference to the service that runs the extension.
    /// 
    /// * To configure a callout extension, service must be a fully-qualified reference to a backend service.
    /// * To configure a plugin extension, service must be a reference to a WasmPlugin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Specifies the timeout for each individual message on the stream. The timeout must be between 10-1000 milliseconds.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for match_condition in GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesLbRouteExtensionExtensionChainsBlockMatchConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_condition";

    /// <summary>
    /// A Common Expression Language (CEL) expression that is used to match requests for which the extension chain is executed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CelExpression is required")]
    public required TerraformValue<string> CelExpression
    {
        get => GetRequiredArgument<TerraformValue<string>>("cel_expression");
        set => SetArgument("cel_expression", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesLbRouteExtension.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesLbRouteExtensionTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_services_lb_route_extension Terraform resource.
/// Manages a google_network_services_lb_route_extension resource.
/// </summary>
public partial class GoogleNetworkServicesLbRouteExtension(string name) : TerraformResource("google_network_services_lb_route_extension", name)
{
    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A list of references to the forwarding rules to which this service extension is attached to.
    /// At least one forwarding rule is required. There can be only one LbRouteExtension resource per forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRules is required")]
    public TerraformList<string>? ForwardingRules
    {
        get => GetArgument<TerraformList<string>>("forwarding_rules");
        set => SetArgument("forwarding_rules", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set of labels associated with the LbRouteExtension resource.
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
    /// All backend services and forwarding rules referenced by this extension must share the same load balancing scheme.
    /// For more information, refer to [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service) and
    /// [Supported application load balancers](https://cloud.google.com/service-extensions/docs/callouts-overview#supported-lbs). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformValue<string> LoadBalancingScheme
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancing_scheme");
        set => SetArgument("load_balancing_scheme", value);
    }

    /// <summary>
    /// The location of the route extension
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the LbRouteExtension resource in the following format: projects/{project}/locations/{location}/lbRouteExtensions/{lbRouteExtension}
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
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// ExtensionChains block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionChains is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExtensionChains block(s) required")]
    public required TerraformList<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock> ExtensionChains
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesLbRouteExtensionExtensionChainsBlock>>("extension_chains");
        set => SetArgument("extension_chains", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesLbRouteExtensionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesLbRouteExtensionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
