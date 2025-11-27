using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allow in GoogleApigeeSecurityAction.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionAllowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow";

}


/// <summary>
/// Block type for condition_config in GoogleApigeeSecurityAction.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionConditionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_config";

    /// <summary>
    /// A list of accessTokens. Limit 1000 per action.
    /// </summary>
    public TerraformList<string>? AccessTokens
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "access_tokens").ResolveNodes(ctx));
        set => SetArgument("access_tokens", value);
    }

    /// <summary>
    /// A list of API keys. Limit 1000 per action.
    /// </summary>
    public TerraformList<string>? ApiKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "api_keys").ResolveNodes(ctx));
        set => SetArgument("api_keys", value);
    }

    /// <summary>
    /// A list of API Products. Limit 1000 per action.
    /// </summary>
    public TerraformList<string>? ApiProducts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "api_products").ResolveNodes(ctx));
        set => SetArgument("api_products", value);
    }

    /// <summary>
    /// A list of ASN numbers to act on, e.g. 23. https://en.wikipedia.org/wiki/Autonomous_system_(Internet)
    /// This uses int64 instead of uint32 because of https://linter.aip.dev/141/forbidden-types.
    /// </summary>
    public TerraformList<string>? Asns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "asns").ResolveNodes(ctx));
        set => SetArgument("asns", value);
    }

    /// <summary>
    /// A list of Bot Reasons. Current options: Flooder, Brute Guessor, Static Content Scraper,
    /// OAuth Abuser, Robot Abuser, TorListRule, Advanced Anomaly Detection, Advanced API Scraper,
    /// Search Engine Crawlers, Public Clouds, Public Cloud AWS, Public Cloud Azure, and Public Cloud Google.
    /// </summary>
    public TerraformList<string>? BotReasons
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "bot_reasons").ResolveNodes(ctx));
        set => SetArgument("bot_reasons", value);
    }

    /// <summary>
    /// A list of developer apps. Limit 1000 per action.
    /// </summary>
    public TerraformList<string>? DeveloperApps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "developer_apps").ResolveNodes(ctx));
        set => SetArgument("developer_apps", value);
    }

    /// <summary>
    /// A list of developers. Limit 1000 per action.
    /// </summary>
    public TerraformList<string>? Developers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "developers").ResolveNodes(ctx));
        set => SetArgument("developers", value);
    }

    /// <summary>
    /// Act only on particular HTTP methods. E.g. A read-only API can block POST/PUT/DELETE methods.
    /// Accepted values are: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE and PATCH.
    /// </summary>
    public TerraformList<string>? HttpMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "http_methods").ResolveNodes(ctx));
        set => SetArgument("http_methods", value);
    }

    /// <summary>
    /// A list of IP addresses. This could be either IPv4 or IPv6. Limited to 100 per action.
    /// </summary>
    public TerraformList<string>? IpAddressRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_address_ranges").ResolveNodes(ctx));
        set => SetArgument("ip_address_ranges", value);
    }

    /// <summary>
    /// A list of countries/region codes to act on, e.g. US. This follows https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2.
    /// </summary>
    public TerraformList<string>? RegionCodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "region_codes").ResolveNodes(ctx));
        set => SetArgument("region_codes", value);
    }

    /// <summary>
    /// A list of user agents to deny. We look for exact matches. Limit 50 per action.
    /// </summary>
    public TerraformList<string>? UserAgents
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_agents").ResolveNodes(ctx));
        set => SetArgument("user_agents", value);
    }

}


/// <summary>
/// Block type for deny in GoogleApigeeSecurityAction.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionDenyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deny";

    /// <summary>
    /// The HTTP response code if the Action = DENY.
    /// </summary>
    public TerraformValue<double>? ResponseCode
    {
        get => new TerraformReference<double>(this, "response_code");
        set => SetArgument("response_code", value);
    }

}


/// <summary>
/// Block type for flag in GoogleApigeeSecurityAction.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionFlagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flag";

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeSecurityActionFlagBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<GoogleApigeeSecurityActionFlagBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

}

/// <summary>
/// Block type for headers in GoogleApigeeSecurityActionFlagBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityActionFlagBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// The header name to be sent to the target.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header value to be sent to the target.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeSecurityAction.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityActionTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_apigee_security_action Terraform resource.
/// Manages a google_apigee_security_action resource.
/// </summary>
public partial class GoogleApigeeSecurityAction(string name) : TerraformResource("google_apigee_security_action", name)
{
    /// <summary>
    /// If unset, this would apply to all proxies in the environment.
    /// If set, this action is enforced only if at least one proxy in the repeated
    /// list is deployed at the time of enforcement. If set, several restrictions are enforced on SecurityActions.
    /// There can be at most 100 enabled actions with proxies set in an env.
    /// Several other restrictions apply on conditions and are detailed later.
    /// </summary>
    public TerraformList<string>? ApiProxies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "api_proxies").ResolveNodes(ctx));
        set => SetArgument("api_proxies", value);
    }

    /// <summary>
    /// An optional user provided description of the SecurityAction.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The Apigee environment that this security action applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformValue<string> EnvId
    {
        get => new TerraformReference<string>(this, "env_id");
        set => SetArgument("env_id", value);
    }

    /// <summary>
    /// The expiration for this SecurityAction.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9
    /// fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
        set => SetArgument("expire_time", value);
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
    /// The organization that this security action applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The ID to use for the SecurityAction, which will become the final component of the action&#39;s resource name.
    /// This value should be 0-61 characters, and valid format is (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityActionId is required")]
    public required TerraformValue<string> SecurityActionId
    {
        get => new TerraformReference<string>(this, "security_action_id");
        set => SetArgument("security_action_id", value);
    }

    /// <summary>
    /// Only an ENABLED SecurityAction is enforced. An ENABLED SecurityAction past its expiration time will not be enforced. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The TTL for this SecurityAction.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => new TerraformReference<string>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The create time for this SecurityAction.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The update time for this SecurityAction. This reflects when this SecurityAction changed states.
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits.
    /// Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Allow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Allow block(s) allowed")]
    public TerraformList<GoogleApigeeSecurityActionAllowBlock>? Allow
    {
        get => GetArgument<TerraformList<GoogleApigeeSecurityActionAllowBlock>>("allow");
        set => SetArgument("allow", value);
    }

    /// <summary>
    /// ConditionConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConditionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionConfig block(s) allowed")]
    public required TerraformList<GoogleApigeeSecurityActionConditionConfigBlock> ConditionConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleApigeeSecurityActionConditionConfigBlock>>("condition_config");
        set => SetArgument("condition_config", value);
    }

    /// <summary>
    /// Deny block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deny block(s) allowed")]
    public TerraformList<GoogleApigeeSecurityActionDenyBlock>? Deny
    {
        get => GetArgument<TerraformList<GoogleApigeeSecurityActionDenyBlock>>("deny");
        set => SetArgument("deny", value);
    }

    /// <summary>
    /// Flag block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flag block(s) allowed")]
    public TerraformList<GoogleApigeeSecurityActionFlagBlock>? Flag
    {
        get => GetArgument<TerraformList<GoogleApigeeSecurityActionFlagBlock>>("flag");
        set => SetArgument("flag", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeSecurityActionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeSecurityActionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
