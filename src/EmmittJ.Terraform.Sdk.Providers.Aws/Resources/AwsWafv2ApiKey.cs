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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TokenDomains
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("token_domains");
        set => this.WithProperty("token_domains", value);
    }

    /// <summary>
    /// The API key value. This is sensitive and not included in responses.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
