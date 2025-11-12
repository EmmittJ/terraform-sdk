using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_route_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionUrlMapDefaultRouteActionBlock() : TerraformBlock("default_route_action")
{
}

/// <summary>
/// Block type for default_url_redirect in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionUrlMapDefaultUrlRedirectBlock() : TerraformBlock("default_url_redirect")
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    [TerraformProperty("host_redirect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    [TerraformProperty("https_redirect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    [TerraformProperty("path_redirect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    [TerraformProperty("prefix_redirect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrefixRedirect { get; set; }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction. Supported values are:
    /// 
    /// * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.
    /// 
    /// * FOUND, which corresponds to 302.
    /// 
    /// * SEE_OTHER which corresponds to 303.
    /// 
    /// * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method
    /// will be retained.
    /// 
    /// * PERMANENT_REDIRECT, which corresponds to 308. In this case,
    /// the request method will be retained. Possible values: [&amp;quot;FOUND&amp;quot;, &amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;]
    /// </summary>
    [TerraformProperty("redirect_response_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained.
    ///  This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StripQuery is required")]
    [TerraformProperty("strip_query")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> StripQuery { get; set; }

}

/// <summary>
/// Block type for header_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionUrlMapHeaderActionBlock() : TerraformBlock("header_action")
{
    /// <summary>
    /// A list of header names for headers that need to be removed from the request before forwarding the request to the backendService.
    /// </summary>
    [TerraformProperty("request_headers_to_remove")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response before sending the response back to the client.
    /// </summary>
    [TerraformProperty("response_headers_to_remove")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResponseHeadersToRemove { get; set; }

}

/// <summary>
/// Block type for host_rule in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeRegionUrlMapHostRuleBlock() : TerraformBlock("host_rule")
{
    /// <summary>
    /// An optional description of this HostRule. Provide this property
    /// when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid
    /// hostnames, except * will match any string of ([a-z0-9-.]*). In
    /// that case, * must be the first character and must be followed in
    /// the pattern by either - or ..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hosts is required")]
    [TerraformProperty("hosts")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of
    /// the URL if the hostRule matches the URL&#39;s host portion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    [TerraformProperty("path_matcher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PathMatcher { get; set; }

}

/// <summary>
/// Block type for path_matcher in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionUrlMapPathMatcherBlock() : TerraformBlock("path_matcher")
{
    /// <summary>
    /// A reference to a RegionBackendService resource. This will be used if
    /// none of the pathRules defined by this PathMatcher is matched by
    /// the URL&#39;s path portion.
    /// </summary>
    [TerraformProperty("default_service")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultService { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name to which this PathMatcher is referred by the HostRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for test in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionUrlMapTestBlock() : TerraformBlock("test")
{
    /// <summary>
    /// Description of this test case.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Host portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformProperty("host")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Host { get; set; }

    /// <summary>
    /// Path portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Path { get; set; }

    /// <summary>
    /// A reference to expected RegionBackendService resource the given URL should be mapped to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionUrlMapTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_region_url_map resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionUrlMap : TerraformResource
{
    public GoogleComputeRegionUrlMap(string name) : base("google_compute_region_url_map", name)
    {
    }

    /// <summary>
    /// The full or partial URL of the defaultService resource to which traffic is directed if
    /// none of the hostRules match. If defaultRouteAction is additionally specified, advanced
    /// routing actions like URL Rewrites, etc. take effect prior to sending the request to the
    /// backend. However, if defaultService is specified, defaultRouteAction cannot contain any
    /// weightedBackendServices. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified.  Only one of defaultService,
    /// defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.
    /// </summary>
    [TerraformProperty("default_service")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultService { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Region in which the url map should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for default_route_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    [TerraformProperty("default_route_action")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlock> DefaultRouteAction { get; set; } = new();

    /// <summary>
    /// Block for default_url_redirect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    [TerraformProperty("default_url_redirect")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultUrlRedirectBlock> DefaultUrlRedirect { get; set; } = new();

    /// <summary>
    /// Block for header_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    [TerraformProperty("header_action")]
    public TerraformList<GoogleComputeRegionUrlMapHeaderActionBlock> HeaderAction { get; set; } = new();

    /// <summary>
    /// Block for host_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("host_rule")]
    public TerraformSet<GoogleComputeRegionUrlMapHostRuleBlock> HostRule { get; set; } = new();

    /// <summary>
    /// Block for path_matcher.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("path_matcher")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlock> PathMatcher { get; set; } = new();

    /// <summary>
    /// Block for test.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("test")]
    public TerraformList<GoogleComputeRegionUrlMapTestBlock> Test { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeRegionUrlMapTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformProperty("map_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MapId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
