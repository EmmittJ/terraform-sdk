using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Provides a WAFv2 API Key resource.
/// </summary>
public class AwsWafv2ApiKey : TerraformResource
{
    public AwsWafv2ApiKey(string name) : base("aws_wafv2_api_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key");
    }

    /// <summary>
    /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains.
    /// </summary>
    public HashSet<string>? TokenDomains
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("token_domains")?.Value;
        set => this.WithProperty("token_domains", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The API key value. This is sensitive and not included in responses.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
