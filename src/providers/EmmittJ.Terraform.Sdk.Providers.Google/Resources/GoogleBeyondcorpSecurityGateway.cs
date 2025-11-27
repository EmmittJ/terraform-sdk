using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hubs in GoogleBeyondcorpSecurityGateway.
/// Nesting mode: set
/// </summary>
public class GoogleBeyondcorpSecurityGatewayHubsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hubs";

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// InternetGateway block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetGateway block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayHubsBlockInternetGatewayBlock>? InternetGateway
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayHubsBlockInternetGatewayBlock>>("internet_gateway");
        set => SetArgument("internet_gateway", value);
    }

}

/// <summary>
/// Block type for internet_gateway in GoogleBeyondcorpSecurityGatewayHubsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayHubsBlockInternetGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internet_gateway";

    /// <summary>
    /// Output only. List of IP addresses assigned to the Cloud NAT.
    /// </summary>
    public TerraformList<string> AssignedIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "assigned_ips").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for proxy_protocol_config in GoogleBeyondcorpSecurityGateway.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_protocol_config";

    /// <summary>
    /// The configuration for the proxy.
    /// </summary>
    public TerraformList<string>? AllowedClientHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_client_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_client_headers", value);
    }

    /// <summary>
    /// Client IP configuration. The client IP address is included if true.
    /// </summary>
    public TerraformValue<bool>? ClientIp
    {
        get => new TerraformReference<bool>(this, "client_ip");
        set => SetArgument("client_ip", value);
    }

    /// <summary>
    /// Gateway identity configuration. Possible values: [&amp;quot;RESOURCE_NAME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? GatewayIdentity
    {
        get => new TerraformReference<string>(this, "gateway_identity");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata_headers").ResolveNodes(ctx));
        set => SetArgument("metadata_headers", value);
    }

    /// <summary>
    /// ContextualHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContextualHeaders block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlock>? ContextualHeaders
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlock>>("contextual_headers");
        set => SetArgument("contextual_headers", value);
    }

}

/// <summary>
/// Block type for contextual_headers in GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "output_type");
        set => SetArgument("output_type", value);
    }

    /// <summary>
    /// DeviceInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceInfo block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockDeviceInfoBlock>? DeviceInfo
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockDeviceInfoBlock>>("device_info");
        set => SetArgument("device_info", value);
    }

    /// <summary>
    /// GroupInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupInfo block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockGroupInfoBlock>? GroupInfo
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockGroupInfoBlock>>("group_info");
        set => SetArgument("group_info", value);
    }

    /// <summary>
    /// UserInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserInfo block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockUserInfoBlock>? UserInfo
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockUserInfoBlock>>("user_info");
        set => SetArgument("user_info", value);
    }

}

/// <summary>
/// Block type for device_info in GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockDeviceInfoBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "output_type");
        set => SetArgument("output_type", value);
    }

}

/// <summary>
/// Block type for group_info in GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockGroupInfoBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "output_type");
        set => SetArgument("output_type", value);
    }

}

/// <summary>
/// Block type for user_info in GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlockContextualHeadersBlockUserInfoBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "output_type");
        set => SetArgument("output_type", value);
    }

}


/// <summary>
/// Block type for service_discovery in GoogleBeyondcorpSecurityGateway.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_discovery";

    /// <summary>
    /// ApiGateway block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiGateway block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlock>? ApiGateway
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlock>>("api_gateway");
        set => SetArgument("api_gateway", value);
    }

}

/// <summary>
/// Block type for api_gateway in GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_gateway";

    /// <summary>
    /// ResourceOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceOverride block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlockResourceOverrideBlock>? ResourceOverride
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlockResourceOverrideBlock>>("resource_override");
        set => SetArgument("resource_override", value);
    }

}

/// <summary>
/// Block type for resource_override in GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlockApiGatewayBlockResourceOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_override";

    /// <summary>
    /// Contains uri path fragment where HTTP request is sent.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBeyondcorpSecurityGateway.
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayTimeoutsBlock : TerraformBlock
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
/// Represents a google_beyondcorp_security_gateway Terraform resource.
/// Manages a google_beyondcorp_security_gateway resource.
/// </summary>
public partial class GoogleBeyondcorpSecurityGateway(string name) : TerraformResource("google_beyondcorp_security_gateway", name)
{
    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    public required TerraformValue<string> SecurityGatewayId
    {
        get => new TerraformReference<string>(this, "security_gateway_id");
        set => SetArgument("security_gateway_id", value);
    }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    public TerraformValue<string> DelegatingServiceAccount
    {
        get => new TerraformReference<string>(this, "delegating_service_account");
    }

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    public TerraformList<string> ExternalIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The operational state of the SecurityGateway.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// UPDATING
    /// DELETING
    /// RUNNING
    /// DOWN
    /// ERROR
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Hubs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleBeyondcorpSecurityGatewayHubsBlock>? Hubs
    {
        get => GetArgument<TerraformSet<GoogleBeyondcorpSecurityGatewayHubsBlock>>("hubs");
        set => SetArgument("hubs", value);
    }

    /// <summary>
    /// ProxyProtocolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyProtocolConfig block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock>? ProxyProtocolConfig
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock>>("proxy_protocol_config");
        set => SetArgument("proxy_protocol_config", value);
    }

    /// <summary>
    /// ServiceDiscovery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDiscovery block(s) allowed")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock>? ServiceDiscovery
    {
        get => GetArgument<TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock>>("service_discovery");
        set => SetArgument("service_discovery", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBeyondcorpSecurityGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBeyondcorpSecurityGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
