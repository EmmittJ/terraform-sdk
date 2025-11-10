using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_custom_error_response_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock : TerraformBlock
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
    public TerraformProperty<string>? ErrorService
    {
        get => GetProperty<TerraformProperty<string>>("error_service");
        set => WithProperty("error_service", value);
    }

}

/// <summary>
/// Block type for default_route_action in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for default_url_redirect in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    public TerraformProperty<string>? HostRedirect
    {
        get => GetProperty<TerraformProperty<string>>("host_redirect");
        set => WithProperty("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    public TerraformProperty<bool>? HttpsRedirect
    {
        get => GetProperty<TerraformProperty<bool>>("https_redirect");
        set => WithProperty("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    public TerraformProperty<string>? PathRedirect
    {
        get => GetProperty<TerraformProperty<string>>("path_redirect");
        set => WithProperty("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformProperty<string>? PrefixRedirect
    {
        get => GetProperty<TerraformProperty<string>>("prefix_redirect");
        set => WithProperty("prefix_redirect", value);
    }

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
    public TerraformProperty<string>? RedirectResponseCode
    {
        get => GetProperty<TerraformProperty<string>>("redirect_response_code");
        set => WithProperty("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained. The default is set to false.
    ///  This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StripQuery is required")]
    public required TerraformProperty<bool> StripQuery
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("strip_query");
        set => WithProperty("strip_query", value);
    }

}

/// <summary>
/// Block type for header_action in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    public List<TerraformProperty<string>>? RequestHeadersToRemove
    {
        get => GetProperty<List<TerraformProperty<string>>>("request_headers_to_remove");
        set => WithProperty("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    public List<TerraformProperty<string>>? ResponseHeadersToRemove
    {
        get => GetProperty<List<TerraformProperty<string>>>("response_headers_to_remove");
        set => WithProperty("response_headers_to_remove", value);
    }

}

/// <summary>
/// Block type for host_rule in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeUrlMapHostRuleBlock : TerraformBlock
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The list of host patterns to match. They must be valid hostnames, except * will
    /// match any string of ([a-z0-9-.]*). In that case, * must be the first character
    /// and must be followed in the pattern by either - or ..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hosts is required")]
    public HashSet<TerraformProperty<string>>? Hosts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("hosts");
        set => WithProperty("hosts", value);
    }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of the URL if the
    /// hostRule matches the URL&#39;s host portion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    public required TerraformProperty<string> PathMatcher
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path_matcher");
        set => WithProperty("path_matcher", value);
    }

}

/// <summary>
/// Block type for path_matcher in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlock : TerraformBlock
{
    /// <summary>
    /// The backend service or backend bucket to use when none of the given paths match.
    /// </summary>
    public TerraformProperty<string>? DefaultService
    {
        get => GetProperty<TerraformProperty<string>>("default_service");
        set => WithProperty("default_service", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name to which this PathMatcher is referred by the HostRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for test in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapTestBlock : TerraformBlock
{
    /// <summary>
    /// Description of this test case.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters.
    /// 
    /// For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl&#39;s scheme is ignored.
    /// 
    /// For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer&#39;s redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters.
    /// 
    /// expectedOutputUrl is optional when service is specified.
    /// </summary>
    public TerraformProperty<string>? ExpectedOutputUrl
    {
        get => GetProperty<TerraformProperty<string>>("expected_output_url");
        set => WithProperty("expected_output_url", value);
    }

    /// <summary>
    /// For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer&#39;s redirect response.
    /// 
    /// expectedRedirectResponseCode cannot be set when service is set.
    /// </summary>
    public TerraformProperty<double>? ExpectedRedirectResponseCode
    {
        get => GetProperty<TerraformProperty<double>>("expected_redirect_response_code");
        set => WithProperty("expected_redirect_response_code", value);
    }

    /// <summary>
    /// Host portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetRequiredProperty<TerraformProperty<string>>("host");
        set => WithProperty("host", value);
    }

    /// <summary>
    /// Path portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The backend service or backend bucket link that should be matched by this test.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeUrlMapTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_url_map resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeUrlMap : TerraformResource
{
    public GoogleComputeUrlMap(string name) : base("google_compute_url_map", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("map_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// The backend service or backend bucket to use when none of the given rules match.
    /// </summary>
    public TerraformProperty<string>? DefaultService
    {
        get => GetProperty<TerraformProperty<string>>("default_service");
        set => this.WithProperty("default_service", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The
    /// name must be 1-63 characters long, and comply with RFC1035. Specifically, the
    /// name must be 1-63 characters long and match the regular expression
    /// &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character must be a lowercase
    /// letter, and all following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for default_custom_error_response_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCustomErrorResponsePolicy block(s) allowed")]
    public List<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock>? DefaultCustomErrorResponsePolicy
    {
        get => GetProperty<List<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock>>("default_custom_error_response_policy");
        set => this.WithProperty("default_custom_error_response_policy", value);
    }

    /// <summary>
    /// Block for default_route_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    public List<GoogleComputeUrlMapDefaultRouteActionBlock>? DefaultRouteAction
    {
        get => GetProperty<List<GoogleComputeUrlMapDefaultRouteActionBlock>>("default_route_action");
        set => this.WithProperty("default_route_action", value);
    }

    /// <summary>
    /// Block for default_url_redirect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    public List<GoogleComputeUrlMapDefaultUrlRedirectBlock>? DefaultUrlRedirect
    {
        get => GetProperty<List<GoogleComputeUrlMapDefaultUrlRedirectBlock>>("default_url_redirect");
        set => this.WithProperty("default_url_redirect", value);
    }

    /// <summary>
    /// Block for header_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public List<GoogleComputeUrlMapHeaderActionBlock>? HeaderAction
    {
        get => GetProperty<List<GoogleComputeUrlMapHeaderActionBlock>>("header_action");
        set => this.WithProperty("header_action", value);
    }

    /// <summary>
    /// Block for host_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeUrlMapHostRuleBlock>? HostRule
    {
        get => GetProperty<HashSet<GoogleComputeUrlMapHostRuleBlock>>("host_rule");
        set => this.WithProperty("host_rule", value);
    }

    /// <summary>
    /// Block for path_matcher.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeUrlMapPathMatcherBlock>? PathMatcher
    {
        get => GetProperty<List<GoogleComputeUrlMapPathMatcherBlock>>("path_matcher");
        set => this.WithProperty("path_matcher", value);
    }

    /// <summary>
    /// Block for test.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeUrlMapTestBlock>? Test
    {
        get => GetProperty<List<GoogleComputeUrlMapTestBlock>>("test");
        set => this.WithProperty("test", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeUrlMapTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeUrlMapTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This
    /// field is used in optimistic locking.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression MapId => this["map_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
