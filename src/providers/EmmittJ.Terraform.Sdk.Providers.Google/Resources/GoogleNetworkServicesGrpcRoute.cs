using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleNetworkServicesGrpcRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Matches block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlock>? Matches
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlock>>("matches");
        set => SetArgument("matches", value);
    }

}

/// <summary>
/// Block type for action in GoogleNetworkServicesGrpcRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Specifies the timeout for selected route.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockDestinationsBlock>? Destinations
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

}

/// <summary>
/// Block type for destinations in GoogleNetworkServicesGrpcRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockActionBlockDestinationsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for fault_injection_policy in GoogleNetworkServicesGrpcRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort";

    /// <summary>
    /// The HTTP status code used to abort the request.
    /// </summary>
    public TerraformValue<double>? HttpStatus
    {
        get => new TerraformReference<double>(this, "http_status");
        set => SetArgument("http_status", value);
    }

    /// <summary>
    /// The percentage of traffic which will be aborted.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => new TerraformReference<double>(this, "percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for delay in GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delay";

    /// <summary>
    /// Specify a fixed delay before forwarding the request.
    /// </summary>
    public TerraformValue<string>? FixedDelay
    {
        get => new TerraformReference<string>(this, "fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

    /// <summary>
    /// The percentage of traffic on which delay will be injected.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => new TerraformReference<double>(this, "percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleNetworkServicesGrpcRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockActionBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// Specifies the allowed number of retries.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => new TerraformReference<double>(this, "num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Specifies one or more conditions when this retry policy applies. Possible values: [&amp;quot;connect-failure&amp;quot;, &amp;quot;refused-stream&amp;quot;, &amp;quot;cancelled&amp;quot;, &amp;quot;deadline-exceeded&amp;quot;, &amp;quot;resource-exhausted&amp;quot;, &amp;quot;unavailable&amp;quot;]
    /// </summary>
    public TerraformList<string>? RetryConditions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "retry_conditions").ResolveNodes(ctx));
        set => SetArgument("retry_conditions", value);
    }

}

/// <summary>
/// Block type for matches in GoogleNetworkServicesGrpcRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matches";

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// Method block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Method block(s) allowed")]
    public TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlockMethodBlock>? Method
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlockMethodBlock>>("method");
        set => SetArgument("method", value);
    }

}

/// <summary>
/// Block type for headers in GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// Required. The key of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type of match. Default value: &amp;quot;EXACT&amp;quot; Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;EXACT&amp;quot;, &amp;quot;REGULAR_EXPRESSION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Required. The value of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for method in GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlockMatchesBlockMethodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "method";

    /// <summary>
    /// Specifies that matches are case sensitive. The default value is true.
    /// </summary>
    public TerraformValue<bool>? CaseSensitive
    {
        get => new TerraformReference<bool>(this, "case_sensitive");
        set => SetArgument("case_sensitive", value);
    }

    /// <summary>
    /// Required. Name of the method to match against.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrpcMethod is required")]
    public required TerraformValue<string> GrpcMethod
    {
        get => new TerraformReference<string>(this, "grpc_method");
        set => SetArgument("grpc_method", value);
    }

    /// <summary>
    /// Required. Name of the service to match against.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrpcService is required")]
    public required TerraformValue<string> GrpcService
    {
        get => new TerraformReference<string>(this, "grpc_service");
        set => SetArgument("grpc_service", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesGrpcRoute.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesGrpcRouteTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_services_grpc_route Terraform resource.
/// Manages a google_network_services_grpc_route resource.
/// </summary>
public partial class GoogleNetworkServicesGrpcRoute(string name) : TerraformResource("google_network_services_grpc_route", name)
{
    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// List of gateways this GrpcRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// </summary>
    public TerraformList<string>? Gateways
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gateways").ResolveNodes(ctx));
        set => SetArgument("gateways", value);
    }

    /// <summary>
    /// Required. Service hostnames with an optional port for which this route describes traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostnames is required")]
    public TerraformList<string>? Hostnames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "hostnames").ResolveNodes(ctx));
        set => SetArgument("hostnames", value);
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
    /// Set of label tags associated with the GrpcRoute resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location (region) of the GRPCRoute resource to be created. Only the value &#39;global&#39; is currently allowed; defaults to &#39;global&#39; if omitted.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// List of meshes this GrpcRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// </summary>
    public TerraformList<string>? Meshes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "meshes").ResolveNodes(ctx));
        set => SetArgument("meshes", value);
    }

    /// <summary>
    /// Name of the GrpcRoute resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// Time the GrpcRoute was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time the GrpcRoute was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleNetworkServicesGrpcRouteRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesGrpcRouteRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesGrpcRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesGrpcRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
