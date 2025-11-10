using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allow in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionAllowBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for condition_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionConditionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A list of accessTokens. Limit 1000 per action.
    /// </summary>
    [TerraformPropertyName("access_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AccessTokens { get; set; }

    /// <summary>
    /// A list of API keys. Limit 1000 per action.
    /// </summary>
    [TerraformPropertyName("api_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ApiKeys { get; set; }

    /// <summary>
    /// A list of API Products. Limit 1000 per action.
    /// </summary>
    [TerraformPropertyName("api_products")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ApiProducts { get; set; }

    /// <summary>
    /// A list of ASN numbers to act on, e.g. 23. https://en.wikipedia.org/wiki/Autonomous_system_(Internet)
    /// This uses int64 instead of uint32 because of https://linter.aip.dev/141/forbidden-types.
    /// </summary>
    [TerraformPropertyName("asns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Asns { get; set; }

    /// <summary>
    /// A list of Bot Reasons. Current options: Flooder, Brute Guessor, Static Content Scraper,
    /// OAuth Abuser, Robot Abuser, TorListRule, Advanced Anomaly Detection, Advanced API Scraper,
    /// Search Engine Crawlers, Public Clouds, Public Cloud AWS, Public Cloud Azure, and Public Cloud Google.
    /// </summary>
    [TerraformPropertyName("bot_reasons")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? BotReasons { get; set; }

    /// <summary>
    /// A list of developer apps. Limit 1000 per action.
    /// </summary>
    [TerraformPropertyName("developer_apps")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DeveloperApps { get; set; }

    /// <summary>
    /// A list of developers. Limit 1000 per action.
    /// </summary>
    [TerraformPropertyName("developers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Developers { get; set; }

    /// <summary>
    /// Act only on particular HTTP methods. E.g. A read-only API can block POST/PUT/DELETE methods.
    /// Accepted values are: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE and PATCH.
    /// </summary>
    [TerraformPropertyName("http_methods")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? HttpMethods { get; set; }

    /// <summary>
    /// A list of IP addresses. This could be either IPv4 or IPv6. Limited to 100 per action.
    /// </summary>
    [TerraformPropertyName("ip_address_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IpAddressRanges { get; set; }

    /// <summary>
    /// A list of countries/region codes to act on, e.g. US. This follows https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2.
    /// </summary>
    [TerraformPropertyName("region_codes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? RegionCodes { get; set; }

    /// <summary>
    /// A list of user agents to deny. We look for exact matches. Limit 50 per action.
    /// </summary>
    [TerraformPropertyName("user_agents")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? UserAgents { get; set; }

}

/// <summary>
/// Block type for deny in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionDenyBlock : ITerraformBlock
{
    /// <summary>
    /// The HTTP response code if the Action = DENY.
    /// </summary>
    [TerraformPropertyName("response_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ResponseCode { get; set; }

}

/// <summary>
/// Block type for flag in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionFlagBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityActionTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_apigee_security_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeSecurityAction : TerraformResource
{
    public GoogleApigeeSecurityAction(string name) : base("google_apigee_security_action", name)
    {
    }

    /// <summary>
    /// If unset, this would apply to all proxies in the environment.
    /// If set, this action is enforced only if at least one proxy in the repeated
    /// list is deployed at the time of enforcement. If set, several restrictions are enforced on SecurityActions.
    /// There can be at most 100 enabled actions with proxies set in an env.
    /// Several other restrictions apply on conditions and are detailed later.
    /// </summary>
    [TerraformPropertyName("api_proxies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ApiProxies { get; set; }

    /// <summary>
    /// An optional user provided description of the SecurityAction.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The Apigee environment that this security action applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    [TerraformPropertyName("env_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnvId { get; set; }

    /// <summary>
    /// The expiration for this SecurityAction.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9
    /// fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpireTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The organization that this security action applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// The ID to use for the SecurityAction, which will become the final component of the action&#39;s resource name.
    /// This value should be 0-61 characters, and valid format is (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityActionId is required")]
    [TerraformPropertyName("security_action_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityActionId { get; set; }

    /// <summary>
    /// Only an ENABLED SecurityAction is enforced. An ENABLED SecurityAction past its expiration time will not be enforced. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> State { get; set; }

    /// <summary>
    /// The TTL for this SecurityAction.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ttl { get; set; }

    /// <summary>
    /// Block for allow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Allow block(s) allowed")]
    [TerraformPropertyName("allow")]
    public TerraformList<TerraformBlock<GoogleApigeeSecurityActionAllowBlock>>? Allow { get; set; } = new();

    /// <summary>
    /// Block for condition_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConditionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionConfig block(s) allowed")]
    [TerraformPropertyName("condition_config")]
    public TerraformList<TerraformBlock<GoogleApigeeSecurityActionConditionConfigBlock>>? ConditionConfig { get; set; } = new();

    /// <summary>
    /// Block for deny.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deny block(s) allowed")]
    [TerraformPropertyName("deny")]
    public TerraformList<TerraformBlock<GoogleApigeeSecurityActionDenyBlock>>? Deny { get; set; } = new();

    /// <summary>
    /// Block for flag.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flag block(s) allowed")]
    [TerraformPropertyName("flag")]
    public TerraformList<TerraformBlock<GoogleApigeeSecurityActionFlagBlock>>? Flag { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeSecurityActionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The create time for this SecurityAction.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The update time for this SecurityAction. This reflects when this SecurityAction changed states.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
