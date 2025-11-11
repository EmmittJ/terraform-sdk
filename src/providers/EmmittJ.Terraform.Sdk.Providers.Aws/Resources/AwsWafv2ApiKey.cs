using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Provides a WAFv2 API Key resource.
/// </summary>
public partial class AwsWafv2ApiKey : TerraformResource
{
    public AwsWafv2ApiKey(string name) : base("aws_wafv2_api_key", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenDomains is required")]
    [TerraformProperty("token_domains")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> TokenDomains { get; set; }

    /// <summary>
    /// The API key value. This is sensitive and not included in responses.
    /// </summary>
    [TerraformProperty("api_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiKey { get; }

}
