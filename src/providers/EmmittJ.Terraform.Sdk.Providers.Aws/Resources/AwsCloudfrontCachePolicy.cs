using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters_in_cache_key_and_forwarded_to_origin in AwsCloudfrontCachePolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters_in_cache_key_and_forwarded_to_origin";

    /// <summary>
    /// The enable_accept_encoding_brotli attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAcceptEncodingBrotli
    {
        get => new TerraformReference<bool>(this, "enable_accept_encoding_brotli");
        set => SetArgument("enable_accept_encoding_brotli", value);
    }

    /// <summary>
    /// The enable_accept_encoding_gzip attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAcceptEncodingGzip
    {
        get => new TerraformReference<bool>(this, "enable_accept_encoding_gzip");
        set => SetArgument("enable_accept_encoding_gzip", value);
    }

    /// <summary>
    /// CookiesConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookiesConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CookiesConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CookiesConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlock> CookiesConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlock>>("cookies_config");
        set => SetArgument("cookies_config", value);
    }

    /// <summary>
    /// HeadersConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadersConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadersConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadersConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlock> HeadersConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlock>>("headers_config");
        set => SetArgument("headers_config", value);
    }

    /// <summary>
    /// QueryStringsConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryStringsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStringsConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlock> QueryStringsConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlock>>("query_strings_config");
        set => SetArgument("query_strings_config", value);
    }

}

/// <summary>
/// Block type for cookies_config in AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookies_config";

    /// <summary>
    /// The cookie_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBehavior is required")]
    public required TerraformValue<string> CookieBehavior
    {
        get => new TerraformReference<string>(this, "cookie_behavior");
        set => SetArgument("cookie_behavior", value);
    }

    /// <summary>
    /// Cookies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cookies block(s) allowed")]
    public TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlockCookiesBlock>? Cookies
    {
        get => GetArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlockCookiesBlock>>("cookies");
        set => SetArgument("cookies", value);
    }

}

/// <summary>
/// Block type for cookies in AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockCookiesConfigBlockCookiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookies";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "items").ResolveNodes(ctx));
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for headers_config in AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers_config";

    /// <summary>
    /// The header_behavior attribute.
    /// </summary>
    public TerraformValue<string>? HeaderBehavior
    {
        get => new TerraformReference<string>(this, "header_behavior");
        set => SetArgument("header_behavior", value);
    }

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Headers block(s) allowed")]
    public TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

}

/// <summary>
/// Block type for headers in AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockHeadersConfigBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "items").ResolveNodes(ctx));
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for query_strings_config in AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_strings_config";

    /// <summary>
    /// The query_string_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringBehavior is required")]
    public required TerraformValue<string> QueryStringBehavior
    {
        get => new TerraformReference<string>(this, "query_string_behavior");
        set => SetArgument("query_string_behavior", value);
    }

    /// <summary>
    /// QueryStrings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStrings block(s) allowed")]
    public TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlockQueryStringsBlock>? QueryStrings
    {
        get => GetArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlockQueryStringsBlock>>("query_strings");
        set => SetArgument("query_strings", value);
    }

}

/// <summary>
/// Block type for query_strings in AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlockQueryStringsConfigBlockQueryStringsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_strings";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "items").ResolveNodes(ctx));
        set => SetArgument("items", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_cache_policy Terraform resource.
/// Manages a aws_cloudfront_cache_policy resource.
/// </summary>
public partial class AwsCloudfrontCachePolicy(string name) : TerraformResource("aws_cloudfront_cache_policy", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
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
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MaxTtl
    {
        get => new TerraformReference<double>(this, "max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinTtl
    {
        get => new TerraformReference<double>(this, "min_ttl");
        set => SetArgument("min_ttl", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// ParametersInCacheKeyAndForwardedToOrigin block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParametersInCacheKeyAndForwardedToOrigin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ParametersInCacheKeyAndForwardedToOrigin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParametersInCacheKeyAndForwardedToOrigin block(s) allowed")]
    public required TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock> ParametersInCacheKeyAndForwardedToOrigin
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock>>("parameters_in_cache_key_and_forwarded_to_origin");
        set => SetArgument("parameters_in_cache_key_and_forwarded_to_origin", value);
    }

}
