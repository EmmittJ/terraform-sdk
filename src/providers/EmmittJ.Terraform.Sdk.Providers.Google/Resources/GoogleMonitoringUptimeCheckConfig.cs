using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for content_matchers in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigContentMatchersBlock : ITerraformBlock
{
    /// <summary>
    /// String or regex content to match (max 1024 bytes)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The type of content matcher that will be applied to the server output, compared to the content string when the check is run. Default value: &amp;quot;CONTAINS_STRING&amp;quot; Possible values: [&amp;quot;CONTAINS_STRING&amp;quot;, &amp;quot;NOT_CONTAINS_STRING&amp;quot;, &amp;quot;MATCHES_REGEX&amp;quot;, &amp;quot;NOT_MATCHES_REGEX&amp;quot;, &amp;quot;MATCHES_JSON_PATH&amp;quot;, &amp;quot;NOT_MATCHES_JSON_PATH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("matcher")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Matcher { get; set; }

}

/// <summary>
/// Block type for http_check in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigHttpCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The request body associated with the HTTP POST request. If &#39;content_type&#39; is &#39;URL_ENCODED&#39;, the body passed in must be URL-encoded. Users can provide a &#39;Content-Length&#39; header via the &#39;headers&#39; field or the API will do so. If the &#39;request_method&#39; is &#39;GET&#39; and &#39;body&#39; is not empty, the API will return an error. The maximum byte size is 1 megabyte. Note - As with all bytes fields JSON representations are base64 encoded. e.g. &#39;foo=bar&#39; in URL-encoded form is &#39;foo%3Dbar&#39; and in base64 encoding is &#39;Zm9vJTI1M0RiYXI=&#39;.
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Body { get; set; }

    /// <summary>
    /// The content type to use for the check. Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;URL_ENCODED&amp;quot;, &amp;quot;USER_PROVIDED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentType { get; set; }

    /// <summary>
    /// A user provided content type header to use for the check. The invalid configurations outlined in the &#39;content_type&#39; field apply to custom_content_type&#39;, as well as the following 1. &#39;content_type&#39; is &#39;URL_ENCODED&#39; and &#39;custom_content_type&#39; is set. 2. &#39;content_type&#39; is &#39;USER_PROVIDED&#39; and &#39;custom_content_type&#39; is not set.
    /// </summary>
    [TerraformPropertyName("custom_content_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomContentType { get; set; }

    /// <summary>
    /// The list of headers to send as part of the uptime check request. If two headers have the same key and different values, they should be entered as a single header, with the value being a comma-separated list of all the desired values as described in [RFC 2616 (page 31)](https://www.w3.org/Protocols/rfc2616/rfc2616.txt). Entering two separate headers with the same key in a Create call will cause the first to be overwritten by the second. The maximum number of headers allowed is 100.
    /// </summary>
    [TerraformPropertyName("headers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Headers { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "headers");

    /// <summary>
    /// Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers related to authentication that you do not wish to be seen when retrieving the configuration. The server will be responsible for encrypting the headers. On Get/List calls, if &#39;mask_headers&#39; is set to &#39;true&#39; then the headers will be obscured with &#39;******&#39;.
    /// </summary>
    [TerraformPropertyName("mask_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MaskHeaders { get; set; }

    /// <summary>
    /// The path to the page to run the check against. Will be combined with the host (specified within the MonitoredResource) and port to construct the full URL. If the provided path does not begin with &#39;/&#39;, a &#39;/&#39; will be prepended automatically. Optional (defaults to &#39;/&#39;).
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The port to the page to run the check against. Will be combined with &#39;host&#39; (specified within the [&#39;monitored_resource&#39;](#nested_monitored_resource)) and path to construct the full URL. Optional (defaults to 80 without SSL, or 443 with SSL).
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Port { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "port");

    /// <summary>
    /// The HTTP request method to use for the check. If set to &#39;METHOD_UNSPECIFIED&#39; then &#39;request_method&#39; defaults to &#39;GET&#39;. Default value: &amp;quot;GET&amp;quot; Possible values: [&amp;quot;METHOD_UNSPECIFIED&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;POST&amp;quot;]
    /// </summary>
    [TerraformPropertyName("request_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestMethod { get; set; }

    /// <summary>
    /// If true, use HTTPS instead of HTTP to run the check.
    /// </summary>
    [TerraformPropertyName("use_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseSsl { get; set; }

    /// <summary>
    /// Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies to checks where &#39;monitored_resource&#39; is set to &#39;uptime_url&#39;. If &#39;use_ssl&#39; is &#39;false&#39;, setting &#39;validate_ssl&#39; to &#39;true&#39; has no effect.
    /// </summary>
    [TerraformPropertyName("validate_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ValidateSsl { get; set; }

}

/// <summary>
/// Block type for monitored_resource in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigMonitoredResourceBlock : ITerraformBlock
{
    /// <summary>
    /// Values for all of the labels listed in the associated monitored resource descriptor. For example, Compute Engine VM instances use the labels &#39;project_id&#39;, &#39;instance_id&#39;, and &#39;zone&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Labels is required")]
    [TerraformPropertyName("labels")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The monitored resource type. This field must match the type field of a [&#39;MonitoredResourceDescriptor&#39;](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.monitoredResourceDescriptors#MonitoredResourceDescriptor) object. For example, the type of a Compute Engine VM instance is &#39;gce_instance&#39;. For a list of types, see [Monitoring resource types](https://cloud.google.com/monitoring/api/resources) and [Logging resource types](https://cloud.google.com/logging/docs/api/v2/resource-list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for resource_group in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigResourceGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The group of resources being monitored. Should be the &#39;name&#39; of a group
    /// </summary>
    [TerraformPropertyName("group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GroupId { get; set; }

    /// <summary>
    /// The resource type of the group members. Possible values: [&amp;quot;RESOURCE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;INSTANCE&amp;quot;, &amp;quot;AWS_ELB_LOAD_BALANCER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceType { get; set; }

}

/// <summary>
/// Block type for synthetic_monitor in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for tcp_check in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringUptimeCheckConfigTcpCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The port to the page to run the check against. Will be combined with host (specified within the &#39;monitored_resource&#39;) to construct the full URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringUptimeCheckConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_monitoring_uptime_check_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringUptimeCheckConfig : TerraformResource
{
    public GoogleMonitoringUptimeCheckConfig(string name) : base("google_monitoring_uptime_check_config", name)
    {
    }

    /// <summary>
    /// The checker type to use for the check. If the monitored resource type is &#39;servicedirectory_service&#39;, &#39;checker_type&#39; must be set to &#39;VPC_CHECKERS&#39;. Possible values: [&amp;quot;STATIC_IP_CHECKERS&amp;quot;, &amp;quot;VPC_CHECKERS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("checker_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CheckerType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checker_type");

    /// <summary>
    /// A human-friendly name for the uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Specifies whether to log the results of failed probes to Cloud Logging.
    /// </summary>
    [TerraformPropertyName("log_check_failures")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LogCheckFailures { get; set; }

    /// <summary>
    /// How often, in seconds, the uptime check is performed. Currently, the only supported values are 60s (1 minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 300s.
    /// </summary>
    [TerraformPropertyName("period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Period { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions to include a minimum of 3 locations must be provided, or an error message is returned. Not specifying this field will result in uptime checks running from all regions.
    /// </summary>
    [TerraformPropertyName("selected_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SelectedRegions { get; set; }

    /// <summary>
    /// The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). [See the accepted formats]( https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Duration)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformPropertyName("timeout")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Timeout { get; set; }

    /// <summary>
    /// User-supplied key/value data to be used for organizing and identifying the &#39;UptimeCheckConfig&#39; objects. The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    [TerraformPropertyName("user_labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? UserLabels { get; set; }

    /// <summary>
    /// Block for content_matchers.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("content_matchers")]
    public TerraformList<TerraformBlock<GoogleMonitoringUptimeCheckConfigContentMatchersBlock>>? ContentMatchers { get; set; } = new();

    /// <summary>
    /// Block for http_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpCheck block(s) allowed")]
    [TerraformPropertyName("http_check")]
    public TerraformList<TerraformBlock<GoogleMonitoringUptimeCheckConfigHttpCheckBlock>>? HttpCheck { get; set; } = new();

    /// <summary>
    /// Block for monitored_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoredResource block(s) allowed")]
    [TerraformPropertyName("monitored_resource")]
    public TerraformList<TerraformBlock<GoogleMonitoringUptimeCheckConfigMonitoredResourceBlock>>? MonitoredResource { get; set; } = new();

    /// <summary>
    /// Block for resource_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceGroup block(s) allowed")]
    [TerraformPropertyName("resource_group")]
    public TerraformList<TerraformBlock<GoogleMonitoringUptimeCheckConfigResourceGroupBlock>>? ResourceGroup { get; set; } = new();

    /// <summary>
    /// Block for synthetic_monitor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyntheticMonitor block(s) allowed")]
    [TerraformPropertyName("synthetic_monitor")]
    public TerraformList<TerraformBlock<GoogleMonitoringUptimeCheckConfigSyntheticMonitorBlock>>? SyntheticMonitor { get; set; } = new();

    /// <summary>
    /// Block for tcp_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpCheck block(s) allowed")]
    [TerraformPropertyName("tcp_check")]
    public TerraformList<TerraformBlock<GoogleMonitoringUptimeCheckConfigTcpCheckBlock>>? TcpCheck { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleMonitoringUptimeCheckConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// A unique resource name for this UptimeCheckConfig. The format is &#39;projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The id of the uptime check
    /// </summary>
    [TerraformPropertyName("uptime_check_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UptimeCheckId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uptime_check_id");

}
