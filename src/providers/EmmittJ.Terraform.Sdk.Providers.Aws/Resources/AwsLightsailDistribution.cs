using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_behavior in AwsLightsailDistribution.
/// Nesting mode: set
/// </summary>
public class AwsLightsailDistributionCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_behavior";

    /// <summary>
    /// The cache behavior for the specified path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => new TerraformReference<string>(this, "behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// The path to a directory or file to cached, or not cache. Use an asterisk symbol to specify wildcard directories (path/to/assets/*), and file types (*.html, *jpg, *js). Directories and file paths are case-sensitive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for cache_behavior_settings in AwsLightsailDistribution.
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionCacheBehaviorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_behavior_settings";

    /// <summary>
    /// The HTTP methods that are processed and forwarded to the distribution&#39;s origin.
    /// </summary>
    public TerraformValue<string>? AllowedHttpMethods
    {
        get => new TerraformReference<string>(this, "allowed_http_methods");
        set => SetArgument("allowed_http_methods", value);
    }

    /// <summary>
    /// The HTTP method responses that are cached by your distribution.
    /// </summary>
    public TerraformValue<string>? CachedHttpMethods
    {
        get => new TerraformReference<string>(this, "cached_http_methods");
        set => SetArgument("cached_http_methods", value);
    }

    /// <summary>
    /// The default amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the content has been updated.
    /// </summary>
    public TerraformValue<double>? DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The maximum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    public TerraformValue<double>? MaximumTtl
    {
        get => new TerraformReference<double>(this, "maximum_ttl");
        set => SetArgument("maximum_ttl", value);
    }

    /// <summary>
    /// The minimum amount of time that objects stay in the distribution&#39;s cache before the distribution forwards another request to the origin to determine whether the object has been updated.
    /// </summary>
    public TerraformValue<double>? MinimumTtl
    {
        get => new TerraformReference<double>(this, "minimum_ttl");
        set => SetArgument("minimum_ttl", value);
    }

    /// <summary>
    /// ForwardedCookies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardedCookies block(s) allowed")]
    public TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedCookiesBlock>? ForwardedCookies
    {
        get => GetArgument<TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedCookiesBlock>>("forwarded_cookies");
        set => SetArgument("forwarded_cookies", value);
    }

    /// <summary>
    /// ForwardedHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardedHeaders block(s) allowed")]
    public TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedHeadersBlock>? ForwardedHeaders
    {
        get => GetArgument<TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedHeadersBlock>>("forwarded_headers");
        set => SetArgument("forwarded_headers", value);
    }

    /// <summary>
    /// ForwardedQueryStrings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardedQueryStrings block(s) allowed")]
    public TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedQueryStringsBlock>? ForwardedQueryStrings
    {
        get => GetArgument<TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedQueryStringsBlock>>("forwarded_query_strings");
        set => SetArgument("forwarded_query_strings", value);
    }

}

/// <summary>
/// Block type for forwarded_cookies in AwsLightsailDistributionCacheBehaviorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedCookiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarded_cookies";

    /// <summary>
    /// The specific cookies to forward to your distribution&#39;s origin.
    /// </summary>
    public TerraformSet<string>? CookiesAllowList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cookies_allow_list").ResolveNodes(ctx));
        set => SetArgument("cookies_allow_list", value);
    }

    /// <summary>
    /// Specifies which cookies to forward to the distribution&#39;s origin for a cache behavior: all, none, or allow-list to forward only the cookies specified in the cookiesAllowList parameter.
    /// </summary>
    public TerraformValue<string>? Option
    {
        get => new TerraformReference<string>(this, "option");
        set => SetArgument("option", value);
    }

}

/// <summary>
/// Block type for forwarded_headers in AwsLightsailDistributionCacheBehaviorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarded_headers";

    /// <summary>
    /// The specific headers to forward to your distribution&#39;s origin.
    /// </summary>
    public TerraformSet<string>? HeadersAllowList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers_allow_list").ResolveNodes(ctx));
        set => SetArgument("headers_allow_list", value);
    }

    /// <summary>
    /// The headers that you want your distribution to forward to your origin and base caching on.
    /// </summary>
    public TerraformValue<string>? Option
    {
        get => new TerraformReference<string>(this, "option");
        set => SetArgument("option", value);
    }

}

/// <summary>
/// Block type for forwarded_query_strings in AwsLightsailDistributionCacheBehaviorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionCacheBehaviorSettingsBlockForwardedQueryStringsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarded_query_strings";

    /// <summary>
    /// Indicates whether the distribution forwards and caches based on query strings.
    /// </summary>
    public TerraformValue<bool>? Option
    {
        get => new TerraformReference<bool>(this, "option");
        set => SetArgument("option", value);
    }

    /// <summary>
    /// The specific query strings that the distribution forwards to the origin.
    /// </summary>
    public TerraformSet<string>? QueryStringsAllowedList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "query_strings_allowed_list").ResolveNodes(ctx));
        set => SetArgument("query_strings_allowed_list", value);
    }

}


/// <summary>
/// Block type for default_cache_behavior in AwsLightsailDistribution.
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionDefaultCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_cache_behavior";

    /// <summary>
    /// The cache behavior of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => new TerraformReference<string>(this, "behavior");
        set => SetArgument("behavior", value);
    }

}


/// <summary>
/// Block type for origin in AwsLightsailDistribution.
/// Nesting mode: list
/// </summary>
public class AwsLightsailDistributionOriginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin";

    /// <summary>
    /// The name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.
    /// </summary>
    public TerraformValue<string>? ProtocolPolicy
    {
        get => new TerraformReference<string>(this, "protocol_policy");
        set => SetArgument("protocol_policy", value);
    }

    /// <summary>
    /// The AWS Region name of the origin resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => new TerraformReference<string>(this, "region_name");
        set => SetArgument("region_name", value);
    }

    /// <summary>
    /// The resource type of the origin resource (e.g., Instance).
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

}


/// <summary>
/// Block type for timeouts in AwsLightsailDistribution.
/// Nesting mode: single
/// </summary>
public class AwsLightsailDistributionTimeoutsBlock : TerraformBlock
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
/// Represents a aws_lightsail_distribution Terraform resource.
/// Manages a aws_lightsail_distribution resource.
/// </summary>
public partial class AwsLightsailDistribution(string name) : TerraformResource("aws_lightsail_distribution", name)
{
    /// <summary>
    /// The bundle ID to use for the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformValue<string> BundleId
    {
        get => new TerraformReference<string>(this, "bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The name of the SSL/TLS certificate attached to the distribution, if any.
    /// </summary>
    public TerraformValue<string>? CertificateName
    {
        get => new TerraformReference<string>(this, "certificate_name");
        set => SetArgument("certificate_name", value);
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
    /// The IP address type of the distribution.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// Indicates whether the distribution is enabled.
    /// </summary>
    public TerraformValue<bool>? IsEnabled
    {
        get => new TerraformReference<bool>(this, "is_enabled");
        set => SetArgument("is_enabled", value);
    }

    /// <summary>
    /// The name of the distribution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The alternate domain names of the distribution.
    /// </summary>
    public TerraformList<string> AlternativeDomainNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "alternative_domain_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the distribution.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The timestamp when the distribution was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The domain name of the distribution.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// An object that describes the location of the distribution, such as the AWS Region and Availability Zone.
    /// </summary>
    public TerraformList<TerraformMap<object>> Location
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public DNS of the origin.
    /// </summary>
    public TerraformValue<string> OriginPublicDns
    {
        get => new TerraformReference<string>(this, "origin_public_dns");
    }

    /// <summary>
    /// The Lightsail resource type (e.g., Distribution).
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

    /// <summary>
    /// The status of the distribution.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The support code. Include this code in your email to support when you have questions about your Lightsail distribution. This code enables our support team to look up your Lightsail information more easily.
    /// </summary>
    public TerraformValue<string> SupportCode
    {
        get => new TerraformReference<string>(this, "support_code");
    }

    /// <summary>
    /// CacheBehavior block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLightsailDistributionCacheBehaviorBlock>? CacheBehavior
    {
        get => GetArgument<TerraformSet<AwsLightsailDistributionCacheBehaviorBlock>>("cache_behavior");
        set => SetArgument("cache_behavior", value);
    }

    /// <summary>
    /// CacheBehaviorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheBehaviorSettings block(s) allowed")]
    public TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlock>? CacheBehaviorSettings
    {
        get => GetArgument<TerraformList<AwsLightsailDistributionCacheBehaviorSettingsBlock>>("cache_behavior_settings");
        set => SetArgument("cache_behavior_settings", value);
    }

    /// <summary>
    /// DefaultCacheBehavior block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    public required TerraformList<AwsLightsailDistributionDefaultCacheBehaviorBlock> DefaultCacheBehavior
    {
        get => GetRequiredArgument<TerraformList<AwsLightsailDistributionDefaultCacheBehaviorBlock>>("default_cache_behavior");
        set => SetArgument("default_cache_behavior", value);
    }

    /// <summary>
    /// Origin block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Origin block(s) allowed")]
    public required TerraformList<AwsLightsailDistributionOriginBlock> Origin
    {
        get => GetRequiredArgument<TerraformList<AwsLightsailDistributionOriginBlock>>("origin");
        set => SetArgument("origin", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLightsailDistributionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLightsailDistributionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
