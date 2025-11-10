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
        set => SetProperty("cookie_behavior", value);
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
        set => SetProperty("header_behavior", value);
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
        set => SetProperty("query_string_behavior", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_origin_request_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontOriginRequestPolicy : TerraformResource
{
    public AwsCloudfrontOriginRequestPolicy(string name) : base("aws_cloudfront_origin_request_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("etag");
        SetOutput("comment");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for cookies_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookiesConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CookiesConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CookiesConfig block(s) allowed")]
    public List<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock>? CookiesConfig
    {
        set => SetProperty("cookies_config", value);
    }

    /// <summary>
    /// Block for headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadersConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadersConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadersConfig block(s) allowed")]
    public List<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock>? HeadersConfig
    {
        set => SetProperty("headers_config", value);
    }

    /// <summary>
    /// Block for query_strings_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryStringsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStringsConfig block(s) allowed")]
    public List<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock>? QueryStringsConfig
    {
        set => SetProperty("query_strings_config", value);
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
