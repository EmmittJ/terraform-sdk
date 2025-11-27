using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookies_config in AwsCloudfrontOriginRequestPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyCookiesConfigBlock : TerraformBlock
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
    public TerraformList<AwsCloudfrontOriginRequestPolicyCookiesConfigBlockCookiesBlock>? Cookies
    {
        get => GetArgument<TerraformList<AwsCloudfrontOriginRequestPolicyCookiesConfigBlockCookiesBlock>>("cookies");
        set => SetArgument("cookies", value);
    }

}

/// <summary>
/// Block type for cookies in AwsCloudfrontOriginRequestPolicyCookiesConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyCookiesConfigBlockCookiesBlock : TerraformBlock
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
/// Block type for headers_config in AwsCloudfrontOriginRequestPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyHeadersConfigBlock : TerraformBlock
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
    public TerraformList<AwsCloudfrontOriginRequestPolicyHeadersConfigBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<AwsCloudfrontOriginRequestPolicyHeadersConfigBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

}

/// <summary>
/// Block type for headers in AwsCloudfrontOriginRequestPolicyHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyHeadersConfigBlockHeadersBlock : TerraformBlock
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
/// Block type for query_strings_config in AwsCloudfrontOriginRequestPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock : TerraformBlock
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
    public TerraformList<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlockQueryStringsBlock>? QueryStrings
    {
        get => GetArgument<TerraformList<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlockQueryStringsBlock>>("query_strings");
        set => SetArgument("query_strings", value);
    }

}

/// <summary>
/// Block type for query_strings in AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlockQueryStringsBlock : TerraformBlock
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
/// Represents a aws_cloudfront_origin_request_policy Terraform resource.
/// Manages a aws_cloudfront_origin_request_policy resource.
/// </summary>
public partial class AwsCloudfrontOriginRequestPolicy(string name) : TerraformResource("aws_cloudfront_origin_request_policy", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// CookiesConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookiesConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CookiesConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CookiesConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock> CookiesConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock>>("cookies_config");
        set => SetArgument("cookies_config", value);
    }

    /// <summary>
    /// HeadersConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadersConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadersConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadersConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock> HeadersConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock>>("headers_config");
        set => SetArgument("headers_config", value);
    }

    /// <summary>
    /// QueryStringsConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryStringsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStringsConfig block(s) allowed")]
    public required TerraformList<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock> QueryStringsConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock>>("query_strings_config");
        set => SetArgument("query_strings_config", value);
    }

}
