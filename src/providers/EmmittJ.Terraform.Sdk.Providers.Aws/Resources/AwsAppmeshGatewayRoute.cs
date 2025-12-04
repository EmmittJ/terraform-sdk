using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshGatewayRoute.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlock>? GrpcRoute
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlock>>("grpc_route");
        set => SetArgument("grpc_route", value);
    }

    /// <summary>
    /// Http2Route block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2Route block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlock>? Http2Route
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlock>>("http2_route");
        set => SetArgument("http2_route", value);
    }

    /// <summary>
    /// HttpRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpRoute block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlock>? HttpRoute
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlock>>("http_route");
        set => SetArgument("http_route", value);
    }

}

/// <summary>
/// Block type for grpc_route in AwsAppmeshGatewayRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for target in AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// VirtualService block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualService is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualService block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualService block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlockVirtualServiceBlock> VirtualService
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlockVirtualServiceBlock>>("virtual_service");
        set => SetArgument("virtual_service", value);
    }

}

/// <summary>
/// Block type for virtual_service in AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockActionBlockTargetBlockVirtualServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_service";

    /// <summary>
    /// The virtual_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualServiceName is required")]
    public required TerraformValue<string> VirtualServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_service_name");
        set => SetArgument("virtual_service_name", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockGrpcRouteBlockMatchBlock : TerraformBlock
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

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

}

/// <summary>
/// Block type for http2_route in AwsAppmeshGatewayRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rewrite block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite";

    /// <summary>
    /// Hostname block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hostname block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockHostnameBlock>? Hostname
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockHostnameBlock>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Path block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Path block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockPathBlock>? Path
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockPathBlock>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Prefix block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Prefix block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockPrefixBlock>? Prefix
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockPrefixBlock>>("prefix");
        set => SetArgument("prefix", value);
    }

}

/// <summary>
/// Block type for hostname in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockHostnameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hostname";

    /// <summary>
    /// The default_target_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultTargetHostname is required")]
    public required TerraformValue<string> DefaultTargetHostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_target_hostname");
        set => SetArgument("default_target_hostname", value);
    }

}

/// <summary>
/// Block type for path in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exact is required")]
    public required TerraformValue<string> Exact
    {
        get => GetRequiredArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for prefix in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockRewriteBlockPrefixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prefix";

    /// <summary>
    /// The default_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPrefix
    {
        get => GetArgument<TerraformValue<string>>("default_prefix");
        set => SetArgument("default_prefix", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for target in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// VirtualService block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualService is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualService block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualService block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlockVirtualServiceBlock> VirtualService
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlockVirtualServiceBlock>>("virtual_service");
        set => SetArgument("virtual_service", value);
    }

}

/// <summary>
/// Block type for virtual_service in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockActionBlockTargetBlockVirtualServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_service";

    /// <summary>
    /// The virtual_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualServiceName is required")]
    public required TerraformValue<string> VirtualServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_service_name");
        set => SetArgument("virtual_service_name", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock : TerraformBlock
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

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Header block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Header block(s) allowed")]
    public TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// Hostname block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hostname block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHostnameBlock>? Hostname
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHostnameBlock>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Path block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Path block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockPathBlock>? Path
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockPathBlock>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// QueryParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 QueryParameter block(s) allowed")]
    public TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock>? QueryParameter
    {
        get => GetArgument<TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock>>("query_parameter");
        set => SetArgument("query_parameter", value);
    }

}

/// <summary>
/// Block type for header in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>? Range
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock : TerraformBlock
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
/// Block type for hostname in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockHostnameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hostname";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for path in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockPathBlock : TerraformBlock
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
/// Block type for query_parameter in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttp2RouteBlockMatchBlockQueryParameterBlockMatchBlock : TerraformBlock
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
/// Block type for http_route in AwsAppmeshGatewayRouteSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for action in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Rewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rewrite block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlock>? Rewrite
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlock>>("rewrite");
        set => SetArgument("rewrite", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for rewrite in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite";

    /// <summary>
    /// Hostname block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hostname block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockHostnameBlock>? Hostname
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockHostnameBlock>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Path block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Path block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockPathBlock>? Path
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockPathBlock>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Prefix block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Prefix block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockPrefixBlock>? Prefix
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockPrefixBlock>>("prefix");
        set => SetArgument("prefix", value);
    }

}

/// <summary>
/// Block type for hostname in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockHostnameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hostname";

    /// <summary>
    /// The default_target_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultTargetHostname is required")]
    public required TerraformValue<string> DefaultTargetHostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_target_hostname");
        set => SetArgument("default_target_hostname", value);
    }

}

/// <summary>
/// Block type for path in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exact is required")]
    public required TerraformValue<string> Exact
    {
        get => GetRequiredArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for prefix in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockRewriteBlockPrefixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prefix";

    /// <summary>
    /// The default_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPrefix
    {
        get => GetArgument<TerraformValue<string>>("default_prefix");
        set => SetArgument("default_prefix", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for target in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// VirtualService block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualService is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualService block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualService block(s) allowed")]
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlockVirtualServiceBlock> VirtualService
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlockVirtualServiceBlock>>("virtual_service");
        set => SetArgument("virtual_service", value);
    }

}

/// <summary>
/// Block type for virtual_service in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockActionBlockTargetBlockVirtualServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_service";

    /// <summary>
    /// The virtual_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualServiceName is required")]
    public required TerraformValue<string> VirtualServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_service_name");
        set => SetArgument("virtual_service_name", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock : TerraformBlock
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

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Header block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Header block(s) allowed")]
    public TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// Hostname block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hostname block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHostnameBlock>? Hostname
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHostnameBlock>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Path block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Path block(s) allowed")]
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockPathBlock>? Path
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockPathBlock>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// QueryParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 QueryParameter block(s) allowed")]
    public TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock>? QueryParameter
    {
        get => GetArgument<TerraformSet<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock>>("query_parameter");
        set => SetArgument("query_parameter", value);
    }

}

/// <summary>
/// Block type for header in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>? Range
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHeaderBlockMatchBlockRangeBlock : TerraformBlock
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
/// Block type for hostname in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockHostnameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hostname";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for path in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockPathBlock : TerraformBlock
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
/// Block type for query_parameter in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlockMatchBlock>? Match
    {
        get => GetArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlockHttpRouteBlockMatchBlockQueryParameterBlockMatchBlock : TerraformBlock
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
/// Represents a aws_appmesh_gateway_route Terraform resource.
/// Manages a aws_appmesh_gateway_route resource.
/// </summary>
public partial class AwsAppmeshGatewayRoute(string name) : TerraformResource("aws_appmesh_gateway_route", name)
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
    /// The virtual_gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualGatewayName is required")]
    public required TerraformValue<string> VirtualGatewayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_gateway_name");
        set => SetArgument("virtual_gateway_name", value);
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
    public required TerraformList<AwsAppmeshGatewayRouteSpecBlock> Spec
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshGatewayRouteSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
