using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_inference_profile.
/// </summary>
public partial class AwsBedrockInferenceProfileDataSource : TerraformDataSource
{
    public AwsBedrockInferenceProfileDataSource(string name) : base("aws_bedrock_inference_profile", name)
    {
    }

    /// <summary>
    /// The inference_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InferenceProfileId is required")]
    [TerraformProperty("inference_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InferenceProfileId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The inference_profile_arn attribute.
    /// </summary>
    [TerraformProperty("inference_profile_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InferenceProfileArn { get; }

    /// <summary>
    /// The inference_profile_name attribute.
    /// </summary>
    [TerraformProperty("inference_profile_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InferenceProfileName { get; }

    /// <summary>
    /// The models attribute.
    /// </summary>
    [TerraformProperty("models")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Models { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
