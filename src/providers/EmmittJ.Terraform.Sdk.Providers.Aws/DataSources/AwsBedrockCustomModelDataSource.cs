using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_custom_model.
/// </summary>
public class AwsBedrockCustomModelDataSource : TerraformDataSource
{
    public AwsBedrockCustomModelDataSource(string name) : base("aws_bedrock_custom_model", name)
    {
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    [TerraformPropertyName("model_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ModelId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The base_model_arn attribute.
    /// </summary>
    [TerraformPropertyName("base_model_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BaseModelArn => new TerraformReference(this, "base_model_arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [TerraformPropertyName("hyperparameters")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Hyperparameters => new TerraformReference(this, "hyperparameters");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    [TerraformPropertyName("job_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobArn => new TerraformReference(this, "job_arn");

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [TerraformPropertyName("job_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobName => new TerraformReference(this, "job_name");

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    [TerraformPropertyName("job_tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> JobTags => new TerraformReference(this, "job_tags");

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [TerraformPropertyName("model_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModelArn => new TerraformReference(this, "model_arn");

    /// <summary>
    /// The model_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("model_kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModelKmsKeyArn => new TerraformReference(this, "model_kms_key_arn");

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [TerraformPropertyName("model_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModelName => new TerraformReference(this, "model_name");

    /// <summary>
    /// The model_tags attribute.
    /// </summary>
    [TerraformPropertyName("model_tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ModelTags => new TerraformReference(this, "model_tags");

    /// <summary>
    /// The output_data_config attribute.
    /// </summary>
    [TerraformPropertyName("output_data_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OutputDataConfig => new TerraformReference(this, "output_data_config");

    /// <summary>
    /// The training_data_config attribute.
    /// </summary>
    [TerraformPropertyName("training_data_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrainingDataConfig => new TerraformReference(this, "training_data_config");

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    [TerraformPropertyName("training_metrics")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrainingMetrics => new TerraformReference(this, "training_metrics");

    /// <summary>
    /// The validation_data_config attribute.
    /// </summary>
    [TerraformPropertyName("validation_data_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ValidationDataConfig => new TerraformReference(this, "validation_data_config");

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    [TerraformPropertyName("validation_metrics")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ValidationMetrics => new TerraformReference(this, "validation_metrics");

}
