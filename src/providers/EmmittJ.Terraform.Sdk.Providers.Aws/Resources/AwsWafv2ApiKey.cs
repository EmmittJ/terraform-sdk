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
        SetOutput("api_key");
        SetOutput("region");
        SetOutput("scope");
        SetOutput("token_domains");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenDomains is required")]
    public HashSet<TerraformProperty<string>> TokenDomains
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("token_domains");
        set => SetProperty("token_domains", value);
    }

    /// <summary>
    /// The API key value. This is sensitive and not included in responses.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
