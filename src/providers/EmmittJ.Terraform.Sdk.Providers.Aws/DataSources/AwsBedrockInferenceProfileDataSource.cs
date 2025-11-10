using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_inference_profile.
/// </summary>
public class AwsBedrockInferenceProfileDataSource : TerraformDataSource
{
    public AwsBedrockInferenceProfileDataSource(string name) : base("aws_bedrock_inference_profile", name)
    {
    }

    /// <summary>
    /// The inference_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InferenceProfileId is required")]
    [TerraformPropertyName("inference_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InferenceProfileId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The inference_profile_arn attribute.
    /// </summary>
    [TerraformPropertyName("inference_profile_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InferenceProfileArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "inference_profile_arn");

    /// <summary>
    /// The inference_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("inference_profile_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InferenceProfileName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "inference_profile_name");

    /// <summary>
    /// The models attribute.
    /// </summary>
    [TerraformPropertyName("models")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Models => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "models");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
