using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allow in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionAllowBlock : TerraformBlock
{
}

/// <summary>
/// Block type for condition_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionConditionConfigBlock : TerraformBlock
{
    /// <summary>
    /// A list of accessTokens. Limit 1000 per action.
    /// </summary>
    public List<TerraformProperty<string>>? AccessTokens
    {
        get => GetProperty<List<TerraformProperty<string>>>("access_tokens");
        set => WithProperty("access_tokens", value);
    }

    /// <summary>
    /// A list of API keys. Limit 1000 per action.
    /// </summary>
    public List<TerraformProperty<string>>? ApiKeys
    {
        get => GetProperty<List<TerraformProperty<string>>>("api_keys");
        set => WithProperty("api_keys", value);
    }

    /// <summary>
    /// A list of API Products. Limit 1000 per action.
    /// </summary>
    public List<TerraformProperty<string>>? ApiProducts
    {
        get => GetProperty<List<TerraformProperty<string>>>("api_products");
        set => WithProperty("api_products", value);
    }

    /// <summary>
    /// A list of ASN numbers to act on, e.g. 23. https://en.wikipedia.org/wiki/Autonomous_system_(Internet)
    /// This uses int64 instead of uint32 because of https://linter.aip.dev/141/forbidden-types.
    /// </summary>
    public List<TerraformProperty<string>>? Asns
    {
        get => GetProperty<List<TerraformProperty<string>>>("asns");
        set => WithProperty("asns", value);
    }

    /// <summary>
    /// A list of Bot Reasons. Current options: Flooder, Brute Guessor, Static Content Scraper,
    /// OAuth Abuser, Robot Abuser, TorListRule, Advanced Anomaly Detection, Advanced API Scraper,
    /// Search Engine Crawlers, Public Clouds, Public Cloud AWS, Public Cloud Azure, and Public Cloud Google.
    /// </summary>
    public List<TerraformProperty<string>>? BotReasons
    {
        get => GetProperty<List<TerraformProperty<string>>>("bot_reasons");
        set => WithProperty("bot_reasons", value);
    }

    /// <summary>
    /// A list of developer apps. Limit 1000 per action.
    /// </summary>
    public List<TerraformProperty<string>>? DeveloperApps
    {
        get => GetProperty<List<TerraformProperty<string>>>("developer_apps");
        set => WithProperty("developer_apps", value);
    }

    /// <summary>
    /// A list of developers. Limit 1000 per action.
    /// </summary>
    public List<TerraformProperty<string>>? Developers
    {
        get => GetProperty<List<TerraformProperty<string>>>("developers");
        set => WithProperty("developers", value);
    }

    /// <summary>
    /// Act only on particular HTTP methods. E.g. A read-only API can block POST/PUT/DELETE methods.
    /// Accepted values are: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE and PATCH.
    /// </summary>
    public List<TerraformProperty<string>>? HttpMethods
    {
        get => GetProperty<List<TerraformProperty<string>>>("http_methods");
        set => WithProperty("http_methods", value);
    }

    /// <summary>
    /// A list of IP addresses. This could be either IPv4 or IPv6. Limited to 100 per action.
    /// </summary>
    public List<TerraformProperty<string>>? IpAddressRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("ip_address_ranges");
        set => WithProperty("ip_address_ranges", value);
    }

    /// <summary>
    /// A list of countries/region codes to act on, e.g. US. This follows https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2.
    /// </summary>
    public List<TerraformProperty<string>>? RegionCodes
    {
        get => GetProperty<List<TerraformProperty<string>>>("region_codes");
        set => WithProperty("region_codes", value);
    }

    /// <summary>
    /// A list of user agents to deny. We look for exact matches. Limit 50 per action.
    /// </summary>
    public List<TerraformProperty<string>>? UserAgents
    {
        get => GetProperty<List<TerraformProperty<string>>>("user_agents");
        set => WithProperty("user_agents", value);
    }

}

/// <summary>
/// Block type for deny in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionDenyBlock : TerraformBlock
{
    /// <summary>
    /// The HTTP response code if the Action = DENY.
    /// </summary>
    public TerraformProperty<double>? ResponseCode
    {
        get => GetProperty<TerraformProperty<double>>("response_code");
        set => WithProperty("response_code", value);
    }

}

/// <summary>
/// Block type for flag in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionFlagBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityActionTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_apigee_security_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeSecurityAction : TerraformResource
{
    public GoogleApigeeSecurityAction(string name) : base("google_apigee_security_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// If unset, this would apply to all proxies in the environment.
    /// If set, this action is enforced only if at least one proxy in the repeated
    /// list is deployed at the time of enforcement. If set, several restrictions are enforced on SecurityActions.
    /// There can be at most 100 enabled actions with proxies set in an env.
    /// Several other restrictions apply on conditions and are detailed later.
    /// </summary>
    public List<TerraformProperty<string>>? ApiProxies
    {
        get => GetProperty<List<TerraformProperty<string>>>("api_proxies");
        set => this.WithProperty("api_proxies", value);
    }

    /// <summary>
    /// An optional user provided description of the SecurityAction.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The Apigee environment that this security action applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformProperty<string> EnvId
    {
        get => GetProperty<TerraformProperty<string>>("env_id");
        set => this.WithProperty("env_id", value);
    }

    /// <summary>
    /// The expiration for this SecurityAction.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9
    /// fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? ExpireTime
    {
        get => GetProperty<TerraformProperty<string>>("expire_time");
        set => this.WithProperty("expire_time", value);
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
    /// The organization that this security action applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// The ID to use for the SecurityAction, which will become the final component of the action&#39;s resource name.
    /// This value should be 0-61 characters, and valid format is (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityActionId is required")]
    public required TerraformProperty<string> SecurityActionId
    {
        get => GetProperty<TerraformProperty<string>>("security_action_id");
        set => this.WithProperty("security_action_id", value);
    }

    /// <summary>
    /// Only an ENABLED SecurityAction is enforced. An ENABLED SecurityAction past its expiration time will not be enforced. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The TTL for this SecurityAction.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Ttl
    {
        get => GetProperty<TerraformProperty<string>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// Block for allow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Allow block(s) allowed")]
    public List<GoogleApigeeSecurityActionAllowBlock>? Allow
    {
        get => GetProperty<List<GoogleApigeeSecurityActionAllowBlock>>("allow");
        set => this.WithProperty("allow", value);
    }

    /// <summary>
    /// Block for condition_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConditionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionConfig block(s) allowed")]
    public List<GoogleApigeeSecurityActionConditionConfigBlock>? ConditionConfig
    {
        get => GetProperty<List<GoogleApigeeSecurityActionConditionConfigBlock>>("condition_config");
        set => this.WithProperty("condition_config", value);
    }

    /// <summary>
    /// Block for deny.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deny block(s) allowed")]
    public List<GoogleApigeeSecurityActionDenyBlock>? Deny
    {
        get => GetProperty<List<GoogleApigeeSecurityActionDenyBlock>>("deny");
        set => this.WithProperty("deny", value);
    }

    /// <summary>
    /// Block for flag.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flag block(s) allowed")]
    public List<GoogleApigeeSecurityActionFlagBlock>? Flag
    {
        get => GetProperty<List<GoogleApigeeSecurityActionFlagBlock>>("flag");
        set => this.WithProperty("flag", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeSecurityActionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeSecurityActionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The create time for this SecurityAction.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The update time for this SecurityAction. This reflects when this SecurityAction changed states.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
