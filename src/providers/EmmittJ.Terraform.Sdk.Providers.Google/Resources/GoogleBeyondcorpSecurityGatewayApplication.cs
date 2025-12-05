using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matchers in GoogleBeyondcorpSecurityGatewayApplication.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_matchers";

    /// <summary>
    /// Required. Hostname of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Optional. Ports of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    public TerraformList<double>? Ports
    {
        get => GetArgument<TerraformList<double>>("ports");
        set => SetArgument("ports", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBeyondcorpSecurityGatewayApplication.
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock : TerraformBlock
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
/// Block type for upstreams in GoogleBeyondcorpSecurityGatewayApplication.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upstreams";

    /// <summary>
    /// EgressPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressPolicy block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockEgressPolicyBlock>? EgressPolicy
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockEgressPolicyBlock>>("egress_policy");
        set => SetArgument("egress_policy", value);
    }

    /// <summary>
    /// External block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 External block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlock>? External
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlock>>("external");
        set => SetArgument("external", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockNetworkBlock>? Network
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// ProxyProtocol block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyProtocol block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlock>? ProxyProtocol
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlock>>("proxy_protocol");
        set => SetArgument("proxy_protocol", value);
    }

}

/// <summary>
/// Block type for egress_policy in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockEgressPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_policy";

    /// <summary>
    /// Required. List of regions where the application sends traffic to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public TerraformList<string>? Regions
    {
        get => GetArgument<TerraformList<string>>("regions");
        set => SetArgument("regions", value);
    }

}

/// <summary>
/// Block type for external in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external";

    /// <summary>
    /// Endpoints block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoints is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoints block(s) required")]
    public required TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlockEndpointsBlock> Endpoints
    {
        get => GetRequiredArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlockEndpointsBlock>>("endpoints");
        set => SetArgument("endpoints", value);
    }

}

/// <summary>
/// Block type for endpoints in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockExternalBlockEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoints";

    /// <summary>
    /// Hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Port of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for network in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network";

    /// <summary>
    /// Required. Network name is of the format:
    /// &#39;projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for proxy_protocol in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_protocol";

    /// <summary>
    /// The configuration for the proxy.
    /// </summary>
    public TerraformList<string>? AllowedClientHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_client_headers");
        set => SetArgument("allowed_client_headers", value);
    }

    /// <summary>
    /// Client IP configuration. The client IP address is included if true.
    /// </summary>
    public TerraformValue<bool>? ClientIp
    {
        get => GetArgument<TerraformValue<bool>>("client_ip");
        set => SetArgument("client_ip", value);
    }

    /// <summary>
    /// Gateway identity configuration. Possible values: [&amp;quot;RESOURCE_NAME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? GatewayIdentity
    {
        get => GetArgument<TerraformValue<string>>("gateway_identity");
        set => SetArgument("gateway_identity", value);
    }

    /// <summary>
    /// Custom resource specific headers along with the values.
    /// The names should conform to RFC 9110:
    /// &amp;gt; Field names SHOULD constrain themselves to alphanumeric characters, &amp;quot;-&amp;quot;,
    ///   and &amp;quot;.&amp;quot;, and SHOULD begin with a letter.
    /// &amp;gt; Field values SHOULD contain only ASCII printable characters and tab.
    /// </summary>
    public TerraformMap<string>? MetadataHeaders
    {
        get => GetArgument<TerraformMap<string>>("metadata_headers");
        set => SetArgument("metadata_headers", value);
    }

    /// <summary>
    /// ContextualHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContextualHeaders block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlock>? ContextualHeaders
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlock>>("contextual_headers");
        set => SetArgument("contextual_headers", value);
    }

}

/// <summary>
/// Block type for contextual_headers in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contextual_headers";

    /// <summary>
    /// Default output type for all enabled headers. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OutputType
    {
        get => GetArgument<TerraformValue<string>>("output_type");
        set => SetArgument("output_type", value);
    }

    /// <summary>
    /// DeviceInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceInfo block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockDeviceInfoBlock>? DeviceInfo
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockDeviceInfoBlock>>("device_info");
        set => SetArgument("device_info", value);
    }

    /// <summary>
    /// GroupInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupInfo block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockGroupInfoBlock>? GroupInfo
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockGroupInfoBlock>>("group_info");
        set => SetArgument("group_info", value);
    }

    /// <summary>
    /// UserInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserInfo block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockUserInfoBlock>? UserInfo
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockUserInfoBlock>>("user_info");
        set => SetArgument("user_info", value);
    }

}

/// <summary>
/// Block type for device_info in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockDeviceInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "device_info";

    /// <summary>
    /// The output type of the delegated device info. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OutputType
    {
        get => GetArgument<TerraformValue<string>>("output_type");
        set => SetArgument("output_type", value);
    }

}

/// <summary>
/// Block type for group_info in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockGroupInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_info";

    /// <summary>
    /// The output type of the delegated group info. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OutputType
    {
        get => GetArgument<TerraformValue<string>>("output_type");
        set => SetArgument("output_type", value);
    }

}

/// <summary>
/// Block type for user_info in GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlockProxyProtocolBlockContextualHeadersBlockUserInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_info";

    /// <summary>
    /// The output type of the delegated user info. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OutputType
    {
        get => GetArgument<TerraformValue<string>>("output_type");
        set => SetArgument("output_type", value);
    }

}


/// <summary>
/// Represents a google_beyondcorp_security_gateway_application Terraform resource.
/// Manages a google_beyondcorp_security_gateway_application resource.
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayApplication(string name) : TerraformResource("google_beyondcorp_security_gateway_application", name)
{
    /// <summary>
    /// User-settable Application resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the Application resource.
    /// Cannot exceed 64 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Type of the external application. Possible values: [&amp;quot;PROXY_GATEWAY&amp;quot;, &amp;quot;API_GATEWAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// ID of the Security Gateway resource this belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    public required TerraformValue<string> SecurityGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("security_gateway_id");
        set => SetArgument("security_gateway_id", value);
    }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// EndpointMatchers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock>? EndpointMatchers
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock>>("endpoint_matchers");
        set => SetArgument("endpoint_matchers", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Upstreams block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock>? Upstreams
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock>>("upstreams");
        set => SetArgument("upstreams", value);
    }

}
