using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookies_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyCookiesConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cookie_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBehavior is required")]
    public required TerraformProperty<string> CookieBehavior
    {
        get => GetProperty<TerraformProperty<string>>("cookie_behavior");
        set => WithProperty("cookie_behavior", value);
    }

}

/// <summary>
/// Block type for headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// The header_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? HeaderBehavior
    {
        get => GetProperty<TerraformProperty<string>>("header_behavior");
        set => WithProperty("header_behavior", value);
    }

}

/// <summary>
/// Block type for query_strings_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The query_string_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringBehavior is required")]
    public required TerraformProperty<string> QueryStringBehavior
    {
        get => GetProperty<TerraformProperty<string>>("query_string_behavior");
        set => WithProperty("query_string_behavior", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_origin_request_policy resource.
/// </summary>
public class AwsCloudfrontOriginRequestPolicy : TerraformResource
{
    public AwsCloudfrontOriginRequestPolicy(string name) : base("aws_cloudfront_origin_request_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for cookies_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CookiesConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CookiesConfig block(s) allowed")]
    public List<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock>? CookiesConfig
    {
        get => GetProperty<List<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock>>("cookies_config");
        set => this.WithProperty("cookies_config", value);
    }

    /// <summary>
    /// Block for headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadersConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadersConfig block(s) allowed")]
    public List<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock>? HeadersConfig
    {
        get => GetProperty<List<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock>>("headers_config");
        set => this.WithProperty("headers_config", value);
    }

    /// <summary>
    /// Block for query_strings_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryStringsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStringsConfig block(s) allowed")]
    public List<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock>? QueryStringsConfig
    {
        get => GetProperty<List<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock>>("query_strings_config");
        set => this.WithProperty("query_strings_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
