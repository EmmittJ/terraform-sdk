using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_wafv2_api_key Terraform resource.
/// Provides a WAFv2 API Key resource.
/// </summary>
public partial class AwsWafv2ApiKey(string name) : TerraformResource("aws_wafv2_api_key", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenDomains is required")]
    public required TerraformSet<string> TokenDomains
    {
        get => GetArgument<TerraformSet<string>>("token_domains");
        set => SetArgument("token_domains", value);
    }

    /// <summary>
    /// The API key value. This is sensitive and not included in responses.
    /// </summary>
    public TerraformValue<string> ApiKey
        => AsReference("api_key");

}
