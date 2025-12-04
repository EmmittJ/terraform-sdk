using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for content_matchers in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigContentMatchersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_matchers";

    /// <summary>
    /// String or regex content to match (max 1024 bytes)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetRequiredArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The type of content matcher that will be applied to the server output, compared to the content string when the check is run. Default value: &amp;quot;CONTAINS_STRING&amp;quot; Possible values: [&amp;quot;CONTAINS_STRING&amp;quot;, &amp;quot;NOT_CONTAINS_STRING&amp;quot;, &amp;quot;MATCHES_REGEX&amp;quot;, &amp;quot;NOT_MATCHES_REGEX&amp;quot;, &amp;quot;MATCHES_JSON_PATH&amp;quot;, &amp;quot;NOT_MATCHES_JSON_PATH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Matcher
    {
        get => GetArgument<TerraformValue<string>>("matcher");
        set => SetArgument("matcher", value);
    }

    /// <summary>
    /// JsonPathMatcher block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonPathMatcher block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigContentMatchersBlockJsonPathMatcherBlock>? JsonPathMatcher
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigContentMatchersBlockJsonPathMatcherBlock>>("json_path_matcher");
        set => SetArgument("json_path_matcher", value);
    }

}

/// <summary>
/// Block type for json_path_matcher in GoogleMonitoringUptimeCheckConfigContentMatchersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigContentMatchersBlockJsonPathMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_path_matcher";

    /// <summary>
    /// Options to perform JSONPath content matching. Default value: &amp;quot;EXACT_MATCH&amp;quot; Possible values: [&amp;quot;EXACT_MATCH&amp;quot;, &amp;quot;REGEX_MATCH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? JsonMatcher
    {
        get => GetArgument<TerraformValue<string>>("json_matcher");
        set => SetArgument("json_matcher", value);
    }

    /// <summary>
    /// JSONPath within the response output pointing to the expected &#39;ContentMatcher::content&#39; to match against.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    public required TerraformValue<string> JsonPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("json_path");
        set => SetArgument("json_path", value);
    }

}


/// <summary>
/// Block type for http_check in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigHttpCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_check";

    /// <summary>
    /// The request body associated with the HTTP POST request. If &#39;content_type&#39; is &#39;URL_ENCODED&#39;, the body passed in must be URL-encoded. Users can provide a &#39;Content-Length&#39; header via the &#39;headers&#39; field or the API will do so. If the &#39;request_method&#39; is &#39;GET&#39; and &#39;body&#39; is not empty, the API will return an error. The maximum byte size is 1 megabyte. Note - As with all bytes fields JSON representations are base64 encoded. e.g. &#39;foo=bar&#39; in URL-encoded form is &#39;foo%3Dbar&#39; and in base64 encoding is &#39;Zm9vJTI1M0RiYXI=&#39;.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The content type to use for the check. Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;URL_ENCODED&amp;quot;, &amp;quot;USER_PROVIDED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// A user provided content type header to use for the check. The invalid configurations outlined in the &#39;content_type&#39; field apply to custom_content_type&#39;, as well as the following 1. &#39;content_type&#39; is &#39;URL_ENCODED&#39; and &#39;custom_content_type&#39; is set. 2. &#39;content_type&#39; is &#39;USER_PROVIDED&#39; and &#39;custom_content_type&#39; is not set.
    /// </summary>
    public TerraformValue<string>? CustomContentType
    {
        get => GetArgument<TerraformValue<string>>("custom_content_type");
        set => SetArgument("custom_content_type", value);
    }

    /// <summary>
    /// The list of headers to send as part of the uptime check request. If two headers have the same key and different values, they should be entered as a single header, with the value being a comma-separated list of all the desired values as described in [RFC 2616 (page 31)](https://www.w3.org/Protocols/rfc2616/rfc2616.txt). Entering two separate headers with the same key in a Create call will cause the first to be overwritten by the second. The maximum number of headers allowed is 100.
    /// </summary>
    public TerraformMap<string> Headers
    {
        get => GetArgument<TerraformMap<string>>("headers") ?? AsReference("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers related to authentication that you do not wish to be seen when retrieving the configuration. The server will be responsible for encrypting the headers. On Get/List calls, if &#39;mask_headers&#39; is set to &#39;true&#39; then the headers will be obscured with &#39;******&#39;.
    /// </summary>
    public TerraformValue<bool>? MaskHeaders
    {
        get => GetArgument<TerraformValue<bool>>("mask_headers");
        set => SetArgument("mask_headers", value);
    }

    /// <summary>
    /// The path to the page to run the check against. Will be combined with the host (specified within the MonitoredResource) and port to construct the full URL. If the provided path does not begin with &#39;/&#39;, a &#39;/&#39; will be prepended automatically. Optional (defaults to &#39;/&#39;).
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port to the page to run the check against. Will be combined with &#39;host&#39; (specified within the [&#39;monitored_resource&#39;](#nested_monitored_resource)) and path to construct the full URL. Optional (defaults to 80 without SSL, or 443 with SSL).
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The HTTP request method to use for the check. If set to &#39;METHOD_UNSPECIFIED&#39; then &#39;request_method&#39; defaults to &#39;GET&#39;. Default value: &amp;quot;GET&amp;quot; Possible values: [&amp;quot;METHOD_UNSPECIFIED&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;POST&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RequestMethod
    {
        get => GetArgument<TerraformValue<string>>("request_method");
        set => SetArgument("request_method", value);
    }

    /// <summary>
    /// If true, use HTTPS instead of HTTP to run the check.
    /// </summary>
    public TerraformValue<bool>? UseSsl
    {
        get => GetArgument<TerraformValue<bool>>("use_ssl");
        set => SetArgument("use_ssl", value);
    }

    /// <summary>
    /// Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies to checks where &#39;monitored_resource&#39; is set to &#39;uptime_url&#39;. If &#39;use_ssl&#39; is &#39;false&#39;, setting &#39;validate_ssl&#39; to &#39;true&#39; has no effect.
    /// </summary>
    public TerraformValue<bool>? ValidateSsl
    {
        get => GetArgument<TerraformValue<bool>>("validate_ssl");
        set => SetArgument("validate_ssl", value);
    }

    /// <summary>
    /// AcceptedResponseStatusCodes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockAcceptedResponseStatusCodesBlock>? AcceptedResponseStatusCodes
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockAcceptedResponseStatusCodesBlock>>("accepted_response_status_codes");
        set => SetArgument("accepted_response_status_codes", value);
    }

    /// <summary>
    /// AuthInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthInfo block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockAuthInfoBlock>? AuthInfo
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockAuthInfoBlock>>("auth_info");
        set => SetArgument("auth_info", value);
    }

    /// <summary>
    /// PingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PingConfig block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockPingConfigBlock>? PingConfig
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockPingConfigBlock>>("ping_config");
        set => SetArgument("ping_config", value);
    }

    /// <summary>
    /// ServiceAgentAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAgentAuthentication block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockServiceAgentAuthenticationBlock>? ServiceAgentAuthentication
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlockServiceAgentAuthenticationBlock>>("service_agent_authentication");
        set => SetArgument("service_agent_authentication", value);
    }

}

/// <summary>
/// Block type for accepted_response_status_codes in GoogleMonitoringUptimeCheckConfigHttpCheckBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigHttpCheckBlockAcceptedResponseStatusCodesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accepted_response_status_codes";

    /// <summary>
    /// A class of status codes to accept. Possible values: [&amp;quot;STATUS_CLASS_1XX&amp;quot;, &amp;quot;STATUS_CLASS_2XX&amp;quot;, &amp;quot;STATUS_CLASS_3XX&amp;quot;, &amp;quot;STATUS_CLASS_4XX&amp;quot;, &amp;quot;STATUS_CLASS_5XX&amp;quot;, &amp;quot;STATUS_CLASS_ANY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? StatusClass
    {
        get => GetArgument<TerraformValue<string>>("status_class");
        set => SetArgument("status_class", value);
    }

    /// <summary>
    /// A status code to accept.
    /// </summary>
    public TerraformValue<double>? StatusValue
    {
        get => GetArgument<TerraformValue<double>>("status_value");
        set => SetArgument("status_value", value);
    }

}

/// <summary>
/// Block type for auth_info in GoogleMonitoringUptimeCheckConfigHttpCheckBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigHttpCheckBlockAuthInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_info";

    /// <summary>
    /// The password to authenticate.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The password to authenticate.
    /// </summary>
    public TerraformValue<string>? PasswordWo
    {
        get => GetArgument<TerraformValue<string>>("password_wo");
        set => SetArgument("password_wo", value);
    }

    /// <summary>
    /// The password write-only version.
    /// </summary>
    public TerraformValue<string>? PasswordWoVersion
    {
        get => GetArgument<TerraformValue<string>>("password_wo_version");
        set => SetArgument("password_wo_version", value);
    }

    /// <summary>
    /// The username to authenticate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for ping_config in GoogleMonitoringUptimeCheckConfigHttpCheckBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigHttpCheckBlockPingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ping_config";

    /// <summary>
    /// Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PingsCount is required")]
    public required TerraformValue<double> PingsCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("pings_count");
        set => SetArgument("pings_count", value);
    }

}

/// <summary>
/// Block type for service_agent_authentication in GoogleMonitoringUptimeCheckConfigHttpCheckBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigHttpCheckBlockServiceAgentAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_agent_authentication";

    /// <summary>
    /// The type of authentication to use. Possible values: [&amp;quot;SERVICE_AGENT_AUTHENTICATION_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;OIDC_TOKEN&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for monitored_resource in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigMonitoredResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitored_resource";

    /// <summary>
    /// Values for all of the labels listed in the associated monitored resource descriptor. For example, Compute Engine VM instances use the labels &#39;project_id&#39;, &#39;instance_id&#39;, and &#39;zone&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Labels is required")]
    public required TerraformMap<string> Labels
    {
        get => GetRequiredArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The monitored resource type. This field must match the type field of a [&#39;MonitoredResourceDescriptor&#39;](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.monitoredResourceDescriptors#MonitoredResourceDescriptor) object. For example, the type of a Compute Engine VM instance is &#39;gce_instance&#39;. For a list of types, see [Monitoring resource types](https://cloud.google.com/monitoring/api/resources) and [Logging resource types](https://cloud.google.com/logging/docs/api/v2/resource-list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for resource_group in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigResourceGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_group";

    /// <summary>
    /// The group of resources being monitored. Should be the &#39;name&#39; of a group
    /// </summary>
    public TerraformValue<string>? GroupId
    {
        get => GetArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The resource type of the group members. Possible values: [&amp;quot;RESOURCE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;INSTANCE&amp;quot;, &amp;quot;AWS_ELB_LOAD_BALANCER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

}


/// <summary>
/// Block type for synthetic_monitor in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "synthetic_monitor";

    /// <summary>
    /// CloudFunctionV2 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudFunctionV2 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CloudFunctionV2 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudFunctionV2 block(s) allowed")]
    public required TerraformList<GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlockCloudFunctionV2Block> CloudFunctionV2
    {
        get => GetRequiredArgument<TerraformList<GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlockCloudFunctionV2Block>>("cloud_function_v2");
        set => SetArgument("cloud_function_v2", value);
    }

}

/// <summary>
/// Block type for cloud_function_v2 in GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlockCloudFunctionV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_function_v2";

    /// <summary>
    /// The fully qualified name of the cloud function resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for tcp_check in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigTcpCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_check";

    /// <summary>
    /// The port to the page to run the check against. Will be combined with host (specified within the &#39;monitored_resource&#39;) to construct the full URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// PingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PingConfig block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigTcpCheckBlockPingConfigBlock>? PingConfig
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigTcpCheckBlockPingConfigBlock>>("ping_config");
        set => SetArgument("ping_config", value);
    }

}

/// <summary>
/// Block type for ping_config in GoogleMonitoringUptimeCheckConfigTcpCheckBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigTcpCheckBlockPingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ping_config";

    /// <summary>
    /// Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PingsCount is required")]
    public required TerraformValue<double> PingsCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("pings_count");
        set => SetArgument("pings_count", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMonitoringUptimeCheckConfig.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringUptimeCheckConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_monitoring_uptime_check_config Terraform resource.
/// Manages a google_monitoring_uptime_check_config resource.
/// </summary>
public partial class GoogleMonitoringUptimeCheckConfig(string name) : TerraformResource("google_monitoring_uptime_check_config", name)
{
    /// <summary>
    /// The checker type to use for the check. If the monitored resource type is &#39;servicedirectory_service&#39;, &#39;checker_type&#39; must be set to &#39;VPC_CHECKERS&#39;. Possible values: [&amp;quot;STATIC_IP_CHECKERS&amp;quot;, &amp;quot;VPC_CHECKERS&amp;quot;]
    /// </summary>
    public TerraformValue<string> CheckerType
    {
        get => GetArgument<TerraformValue<string>>("checker_type") ?? AsReference("checker_type");
        set => SetArgument("checker_type", value);
    }

    /// <summary>
    /// A human-friendly name for the uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// Specifies whether to log the results of failed probes to Cloud Logging.
    /// </summary>
    public TerraformValue<bool>? LogCheckFailures
    {
        get => GetArgument<TerraformValue<bool>>("log_check_failures");
        set => SetArgument("log_check_failures", value);
    }

    /// <summary>
    /// How often, in seconds, the uptime check is performed. Currently, the only supported values are 60s (1 minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 300s.
    /// </summary>
    public TerraformValue<string>? Period
    {
        get => GetArgument<TerraformValue<string>>("period");
        set => SetArgument("period", value);
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
    /// The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions to include a minimum of 3 locations must be provided, or an error message is returned. Not specifying this field will result in uptime checks running from all regions.
    /// </summary>
    public TerraformList<string>? SelectedRegions
    {
        get => GetArgument<TerraformList<string>>("selected_regions");
        set => SetArgument("selected_regions", value);
    }

    /// <summary>
    /// The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). [See the accepted formats]( https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Duration)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformValue<string> Timeout
    {
        get => GetRequiredArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// User-supplied key/value data to be used for organizing and identifying the &#39;UptimeCheckConfig&#39; objects. The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    public TerraformMap<string>? UserLabels
    {
        get => GetArgument<TerraformMap<string>>("user_labels");
        set => SetArgument("user_labels", value);
    }

    /// <summary>
    /// A unique resource name for this UptimeCheckConfig. The format is &#39;projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The id of the uptime check
    /// </summary>
    public TerraformValue<string> UptimeCheckId
        => AsReference("uptime_check_id");

    /// <summary>
    /// ContentMatchers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringUptimeCheckConfigContentMatchersBlock>? ContentMatchers
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigContentMatchersBlock>>("content_matchers");
        set => SetArgument("content_matchers", value);
    }

    /// <summary>
    /// HttpCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpCheck block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlock>? HttpCheck
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigHttpCheckBlock>>("http_check");
        set => SetArgument("http_check", value);
    }

    /// <summary>
    /// MonitoredResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoredResource block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigMonitoredResourceBlock>? MonitoredResource
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigMonitoredResourceBlock>>("monitored_resource");
        set => SetArgument("monitored_resource", value);
    }

    /// <summary>
    /// ResourceGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceGroup block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigResourceGroupBlock>? ResourceGroup
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigResourceGroupBlock>>("resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// SyntheticMonitor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyntheticMonitor block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlock>? SyntheticMonitor
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlock>>("synthetic_monitor");
        set => SetArgument("synthetic_monitor", value);
    }

    /// <summary>
    /// TcpCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpCheck block(s) allowed")]
    public TerraformList<GoogleMonitoringUptimeCheckConfigTcpCheckBlock>? TcpCheck
    {
        get => GetArgument<TerraformList<GoogleMonitoringUptimeCheckConfigTcpCheckBlock>>("tcp_check");
        set => SetArgument("tcp_check", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringUptimeCheckConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringUptimeCheckConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
