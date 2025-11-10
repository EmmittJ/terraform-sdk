using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Provides a WAFv2 API Key resource.
/// </summary>
public class AwsWafv2ApiKey : TerraformResource
{
    public AwsWafv2ApiKey(string name) : base("aws_wafv2_api_key", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenDomains is required")]
    [TerraformPropertyName("token_domains")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TokenDomains { get; set; }

    /// <summary>
    /// The API key value. This is sensitive and not included in responses.
    /// </summary>
    [TerraformPropertyName("api_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key");

}
