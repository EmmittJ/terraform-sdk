using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_authorizer resource.
/// </summary>
public partial class AwsIotAuthorizer : TerraformResource
{
    public AwsIotAuthorizer(string name) : base("aws_iot_authorizer", name)
    {
    }

    /// <summary>
    /// The authorizer_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerFunctionArn is required")]
    [TerraformProperty("authorizer_function_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthorizerFunctionArn { get; set; }

    /// <summary>
    /// The enable_caching_for_http attribute.
    /// </summary>
    [TerraformProperty("enable_caching_for_http")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableCachingForHttp { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The signing_disabled attribute.
    /// </summary>
    [TerraformProperty("signing_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SigningDisabled { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The token_key_name attribute.
    /// </summary>
    [TerraformProperty("token_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TokenKeyName { get; set; }

    /// <summary>
    /// The token_signing_public_keys attribute.
    /// </summary>
    [TerraformProperty("token_signing_public_keys")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? TokenSigningPublicKeys { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
