using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_custom_model.
/// </summary>
public partial class AwsBedrockCustomModelDataSource : TerraformDataSource
{
    public AwsBedrockCustomModelDataSource(string name) : base("aws_bedrock_custom_model", name)
    {
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    [TerraformProperty("model_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ModelId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The base_model_arn attribute.
    /// </summary>
    [TerraformProperty("base_model_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BaseModelArn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [TerraformProperty("hyperparameters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Hyperparameters { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    [TerraformProperty("job_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobArn { get; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [TerraformProperty("job_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobName { get; }

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    [TerraformProperty("job_tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> JobTags { get; }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [TerraformProperty("model_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModelArn { get; }

    /// <summary>
    /// The model_kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("model_kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModelKmsKeyArn { get; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [TerraformProperty("model_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModelName { get; }

    /// <summary>
    /// The model_tags attribute.
    /// </summary>
    [TerraformProperty("model_tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> ModelTags { get; }

    /// <summary>
    /// The output_data_config attribute.
    /// </summary>
    [TerraformProperty("output_data_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OutputDataConfig { get; }

    /// <summary>
    /// The training_data_config attribute.
    /// </summary>
    [TerraformProperty("training_data_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TrainingDataConfig { get; }

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    [TerraformProperty("training_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TrainingMetrics { get; }

    /// <summary>
    /// The validation_data_config attribute.
    /// </summary>
    [TerraformProperty("validation_data_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ValidationDataConfig { get; }

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    [TerraformProperty("validation_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ValidationMetrics { get; }

}
