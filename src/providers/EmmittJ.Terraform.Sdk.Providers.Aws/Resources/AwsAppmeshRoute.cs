using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshRoute.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// GrpcRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcRoute block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlock>? GrpcRoute
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlock>>("grpc_route");
        set => SetArgument("grpc_route", value);
    }

    /// <summary>
    /// Http2Route block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2Route block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlock>? Http2Route
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlock>>("http2_route");
        set => SetArgument("http2_route", value);
    }

    /// <summary>
    /// HttpRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpRoute block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlock>? HttpRoute
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlock>>("http_route");
        set => SetArgument("http_route", value);
    }

    /// <summary>
    /// TcpRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpRoute block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlock>? TcpRoute
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlock>>("tcp_route");
        set => SetArgument("tcp_route", value);
    }

}

/// <summary>
/// Block type for grpc_route in AwsAppmeshRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_route";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshRouteSpecBlockGrpcRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// WeightedTarget block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeightedTarget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WeightedTarget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 WeightedTarget block(s) allowed")]
    public required TerraformSet<AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlockWeightedTargetBlock> WeightedTarget
    {
        get => GetRequiredArgument<TerraformSet<AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlockWeightedTargetBlock>>("weighted_target");
        set => SetArgument("weighted_target", value);
    }

}

/// <summary>
/// Block type for weighted_target in AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockActionBlockWeightedTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The virtual_node attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNode is required")]
    public required TerraformValue<string> VirtualNode
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_node");
        set => SetArgument("virtual_node", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockGrpcRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The method_name attribute.
    /// </summary>
    public TerraformValue<string>? MethodName
    {
        get => GetArgument<TerraformValue<string>>("method_name");
        set => SetArgument("method_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Metadata block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Metadata block(s) allowed")]
    public TerraformSet<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformSet<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

}

/// <summary>
/// Block type for metadata in AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// The invert attribute.
    /// </summary>
    public TerraformValue<bool>? Invert
    {
        get => GetArgument<TerraformValue<bool>>("invert");
        set => SetArgument("invert", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlockRangeBlock>? Range
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockMatchBlockMetadataBlockMatchBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<double> End
    {
        get => GetRequiredArgument<TerraformValue<double>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<double> Start
    {
        get => GetRequiredArgument<TerraformValue<double>>("start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Block type for retry_policy in AwsAppmeshRouteSpecBlockGrpcRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The grpc_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? GrpcRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("grpc_retry_events");
        set => SetArgument("grpc_retry_events", value);
    }

    /// <summary>
    /// The http_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? HttpRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("http_retry_events");
        set => SetArgument("http_retry_events", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetries is required")]
    public required TerraformValue<double> MaxRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The tcp_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? TcpRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("tcp_retry_events");
        set => SetArgument("tcp_retry_events", value);
    }

    /// <summary>
    /// PerRetryTimeout block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerRetryTimeout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PerRetryTimeout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRetryTimeout block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlockPerRetryTimeoutBlock> PerRetryTimeout
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlockPerRetryTimeoutBlock>>("per_retry_timeout");
        set => SetArgument("per_retry_timeout", value);
    }

}

/// <summary>
/// Block type for per_retry_timeout in AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockRetryPolicyBlockPerRetryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_retry_timeout";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timeout in AwsAppmeshRouteSpecBlockGrpcRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

    /// <summary>
    /// PerRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRequest block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlockPerRequestBlock>? PerRequest
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlockPerRequestBlock>>("per_request");
        set => SetArgument("per_request", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for per_request in AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockGrpcRouteBlockTimeoutBlockPerRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_request";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for http2_route in AwsAppmeshRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http2_route";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshRouteSpecBlockHttp2RouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// WeightedTarget block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeightedTarget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WeightedTarget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 WeightedTarget block(s) allowed")]
    public required TerraformSet<AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlockWeightedTargetBlock> WeightedTarget
    {
        get => GetRequiredArgument<TerraformSet<AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlockWeightedTargetBlock>>("weighted_target");
        set => SetArgument("weighted_target", value);
    }

}

/// <summary>
/// Block type for weighted_target in AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockActionBlockWeightedTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The virtual_node attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNode is required")]
    public required TerraformValue<string> VirtualNode
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_node");
        set => SetArgument("virtual_node", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockHttp2RouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => GetArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The scheme attribute.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

    /// <summary>
    /// Header block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Header block(s) allowed")]
    public TerraformSet<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformSet<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// Path block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Path block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockPathBlock>? Path
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockPathBlock>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// QueryParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 QueryParameter block(s) allowed")]
    public TerraformSet<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock>? QueryParameter
    {
        get => GetArgument<TerraformSet<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock>>("query_parameter");
        set => SetArgument("query_parameter", value);
    }

}

/// <summary>
/// Block type for header in AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The invert attribute.
    /// </summary>
    public TerraformValue<bool>? Invert
    {
        get => GetArgument<TerraformValue<bool>>("invert");
        set => SetArgument("invert", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>? Range
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<double> End
    {
        get => GetRequiredArgument<TerraformValue<double>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<double> Start
    {
        get => GetRequiredArgument<TerraformValue<double>>("start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Block type for path in AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

}

/// <summary>
/// Block type for query_parameter in AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for retry_policy in AwsAppmeshRouteSpecBlockHttp2RouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The http_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? HttpRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("http_retry_events");
        set => SetArgument("http_retry_events", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetries is required")]
    public required TerraformValue<double> MaxRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The tcp_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? TcpRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("tcp_retry_events");
        set => SetArgument("tcp_retry_events", value);
    }

    /// <summary>
    /// PerRetryTimeout block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerRetryTimeout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PerRetryTimeout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRetryTimeout block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlockPerRetryTimeoutBlock> PerRetryTimeout
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlockPerRetryTimeoutBlock>>("per_retry_timeout");
        set => SetArgument("per_retry_timeout", value);
    }

}

/// <summary>
/// Block type for per_retry_timeout in AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockRetryPolicyBlockPerRetryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_retry_timeout";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timeout in AwsAppmeshRouteSpecBlockHttp2RouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

    /// <summary>
    /// PerRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRequest block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlockPerRequestBlock>? PerRequest
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlockPerRequestBlock>>("per_request");
        set => SetArgument("per_request", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for per_request in AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttp2RouteBlockTimeoutBlockPerRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_request";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for http_route in AwsAppmeshRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_route";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshRouteSpecBlockHttpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// WeightedTarget block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeightedTarget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WeightedTarget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 WeightedTarget block(s) allowed")]
    public required TerraformSet<AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlockWeightedTargetBlock> WeightedTarget
    {
        get => GetRequiredArgument<TerraformSet<AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlockWeightedTargetBlock>>("weighted_target");
        set => SetArgument("weighted_target", value);
    }

}

/// <summary>
/// Block type for weighted_target in AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockActionBlockWeightedTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The virtual_node attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNode is required")]
    public required TerraformValue<string> VirtualNode
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_node");
        set => SetArgument("virtual_node", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockHttpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => GetArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The scheme attribute.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

    /// <summary>
    /// Header block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Header block(s) allowed")]
    public TerraformSet<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformSet<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// Path block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Path block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockPathBlock>? Path
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockPathBlock>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// QueryParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 QueryParameter block(s) allowed")]
    public TerraformSet<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock>? QueryParameter
    {
        get => GetArgument<TerraformSet<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock>>("query_parameter");
        set => SetArgument("query_parameter", value);
    }

}

/// <summary>
/// Block type for header in AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The invert attribute.
    /// </summary>
    public TerraformValue<bool>? Invert
    {
        get => GetArgument<TerraformValue<bool>>("invert");
        set => SetArgument("invert", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>? Range
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<double> End
    {
        get => GetRequiredArgument<TerraformValue<double>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<double> Start
    {
        get => GetRequiredArgument<TerraformValue<double>>("start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Block type for path in AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => GetArgument<TerraformValue<string>>("regex");
        set => SetArgument("regex", value);
    }

}

/// <summary>
/// Block type for query_parameter in AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for retry_policy in AwsAppmeshRouteSpecBlockHttpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The http_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? HttpRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("http_retry_events");
        set => SetArgument("http_retry_events", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetries is required")]
    public required TerraformValue<double> MaxRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The tcp_retry_events attribute.
    /// </summary>
    public TerraformSet<string>? TcpRetryEvents
    {
        get => GetArgument<TerraformSet<string>>("tcp_retry_events");
        set => SetArgument("tcp_retry_events", value);
    }

    /// <summary>
    /// PerRetryTimeout block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerRetryTimeout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PerRetryTimeout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRetryTimeout block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlockPerRetryTimeoutBlock> PerRetryTimeout
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlockPerRetryTimeoutBlock>>("per_retry_timeout");
        set => SetArgument("per_retry_timeout", value);
    }

}

/// <summary>
/// Block type for per_retry_timeout in AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockRetryPolicyBlockPerRetryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_retry_timeout";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timeout in AwsAppmeshRouteSpecBlockHttpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

    /// <summary>
    /// PerRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRequest block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlockPerRequestBlock>? PerRequest
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlockPerRequestBlock>>("per_request");
        set => SetArgument("per_request", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for per_request in AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockHttpRouteBlockTimeoutBlockPerRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_request";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_route in AwsAppmeshRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockTcpRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_route";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshRouteSpecBlockTcpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// WeightedTarget block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeightedTarget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WeightedTarget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 WeightedTarget block(s) allowed")]
    public required TerraformSet<AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlockWeightedTargetBlock> WeightedTarget
    {
        get => GetRequiredArgument<TerraformSet<AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlockWeightedTargetBlock>>("weighted_target");
        set => SetArgument("weighted_target", value);
    }

}

/// <summary>
/// Block type for weighted_target in AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshRouteSpecBlockTcpRouteBlockActionBlockWeightedTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The virtual_node attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNode is required")]
    public required TerraformValue<string> VirtualNode
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_node");
        set => SetArgument("virtual_node", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshRouteSpecBlockTcpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockTcpRouteBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for timeout in AwsAppmeshRouteSpecBlockTcpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshRouteSpecBlockTcpRouteBlockTimeoutBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_appmesh_route Terraform resource.
/// Manages a aws_appmesh_route resource.
/// </summary>
public partial class AwsAppmeshRoute(string name) : TerraformResource("aws_appmesh_route", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mesh_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshName is required")]
    public required TerraformValue<string> MeshName
    {
        get => GetRequiredArgument<TerraformValue<string>>("mesh_name");
        set => SetArgument("mesh_name", value);
    }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformValue<string> MeshOwner
    {
        get => GetArgument<TerraformValue<string>>("mesh_owner") ?? AsReference("mesh_owner");
        set => SetArgument("mesh_owner", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The virtual_router_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualRouterName is required")]
    public required TerraformValue<string> VirtualRouterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_router_name");
        set => SetArgument("virtual_router_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => AsReference("last_updated_date");

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
        => AsReference("resource_owner");

    /// <summary>
    /// Spec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public required TerraformList<AwsAppmeshRouteSpecBlock> Spec
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshRouteSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
