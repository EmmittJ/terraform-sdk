using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_custom_error_response_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock
{
    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// 
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// 
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [TerraformPropertyName("error_service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ErrorService { get; set; }

}

/// <summary>
/// Block type for default_route_action in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlock
{
}

/// <summary>
/// Block type for default_url_redirect in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultUrlRedirectBlock
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    [TerraformPropertyName("host_redirect")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    [TerraformPropertyName("https_redirect")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("path_redirect")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    [TerraformPropertyName("prefix_redirect")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrefixRedirect { get; set; }

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
    [TerraformPropertyName("redirect_response_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained. The default is set to false.
    ///  This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StripQuery is required")]
    [TerraformPropertyName("strip_query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> StripQuery { get; set; }

}

/// <summary>
/// Block type for header_action in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapHeaderActionBlock
{
    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [TerraformPropertyName("request_headers_to_remove")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [TerraformPropertyName("response_headers_to_remove")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ResponseHeadersToRemove { get; set; }

}

/// <summary>
/// Block type for host_rule in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeUrlMapHostRuleBlock
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid hostnames, except * will
    /// match any string of ([a-z0-9-.]*). In that case, * must be the first character
    /// and must be followed in the pattern by either - or ..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hosts is required")]
    [TerraformPropertyName("hosts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of the URL if the
    /// hostRule matches the URL&#39;s host portion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    [TerraformPropertyName("path_matcher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PathMatcher { get; set; }

}

/// <summary>
/// Block type for path_matcher in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlock
{
    /// <summary>
    /// The backend service or backend bucket to use when none of the given paths match.
    /// </summary>
    [TerraformPropertyName("default_service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultService { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name to which this PathMatcher is referred by the HostRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for test in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapTestBlock
{
    /// <summary>
    /// Description of this test case.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters.
    /// 
    /// For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl&#39;s scheme is ignored.
    /// 
    /// For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer&#39;s redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters.
    /// 
    /// expectedOutputUrl is optional when service is specified.
    /// </summary>
    [TerraformPropertyName("expected_output_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpectedOutputUrl { get; set; }

    /// <summary>
    /// For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer&#39;s redirect response.
    /// 
    /// expectedRedirectResponseCode cannot be set when service is set.
    /// </summary>
    [TerraformPropertyName("expected_redirect_response_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExpectedRedirectResponseCode { get; set; }

    /// <summary>
    /// Host portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformPropertyName("host")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Host { get; set; }

    /// <summary>
    /// Path portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The backend service or backend bucket link that should be matched by this test.
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Service { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeUrlMapTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_url_map resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeUrlMap : TerraformResource
{
    public GoogleComputeUrlMap(string name) : base("google_compute_url_map", name)
    {
    }

    /// <summary>
    /// The backend service or backend bucket to use when none of the given rules match.
    /// </summary>
    [TerraformPropertyName("default_service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultService { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The
    /// name must be 1-63 characters long, and comply with RFC1035. Specifically, the
    /// name must be 1-63 characters long and match the regular expression
    /// &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character must be a lowercase
    /// letter, and all following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for default_custom_error_response_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCustomErrorResponsePolicy block(s) allowed")]
    [TerraformPropertyName("default_custom_error_response_policy")]
    public TerraformList<TerraformBlock<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock>>? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// Block for default_route_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    [TerraformPropertyName("default_route_action")]
    public TerraformList<TerraformBlock<GoogleComputeUrlMapDefaultRouteActionBlock>>? DefaultRouteAction { get; set; }

    /// <summary>
    /// Block for default_url_redirect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    [TerraformPropertyName("default_url_redirect")]
    public TerraformList<TerraformBlock<GoogleComputeUrlMapDefaultUrlRedirectBlock>>? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// Block for header_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    [TerraformPropertyName("header_action")]
    public TerraformList<TerraformBlock<GoogleComputeUrlMapHeaderActionBlock>>? HeaderAction { get; set; }

    /// <summary>
    /// Block for host_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("host_rule")]
    public TerraformSet<TerraformBlock<GoogleComputeUrlMapHostRuleBlock>>? HostRule { get; set; }

    /// <summary>
    /// Block for path_matcher.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("path_matcher")]
    public TerraformList<TerraformBlock<GoogleComputeUrlMapPathMatcherBlock>>? PathMatcher { get; set; }

    /// <summary>
    /// Block for test.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("test")]
    public TerraformList<TerraformBlock<GoogleComputeUrlMapTestBlock>>? Test { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeUrlMapTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This
    /// field is used in optimistic locking.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fingerprint => new TerraformReference(this, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("map_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MapId => new TerraformReference(this, "map_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

}
