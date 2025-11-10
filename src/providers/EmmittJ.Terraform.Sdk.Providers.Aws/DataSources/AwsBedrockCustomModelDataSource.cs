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
    public required TerraformProperty<TerraformProperty<string>> ModelId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The base_model_arn attribute.
    /// </summary>
    [TerraformPropertyName("base_model_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BaseModelArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "base_model_arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [TerraformPropertyName("hyperparameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Hyperparameters => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "hyperparameters");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    [TerraformPropertyName("job_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_arn");

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [TerraformPropertyName("job_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_name");

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    [TerraformPropertyName("job_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> JobTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "job_tags");

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [TerraformPropertyName("model_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModelArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model_arn");

    /// <summary>
    /// The model_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("model_kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModelKmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model_kms_key_arn");

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [TerraformPropertyName("model_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModelName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model_name");

    /// <summary>
    /// The model_tags attribute.
    /// </summary>
    [TerraformPropertyName("model_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ModelTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "model_tags");

    /// <summary>
    /// The output_data_config attribute.
    /// </summary>
    [TerraformPropertyName("output_data_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OutputDataConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "output_data_config");

    /// <summary>
    /// The training_data_config attribute.
    /// </summary>
    [TerraformPropertyName("training_data_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrainingDataConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "training_data_config");

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    [TerraformPropertyName("training_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrainingMetrics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "training_metrics");

    /// <summary>
    /// The validation_data_config attribute.
    /// </summary>
    [TerraformPropertyName("validation_data_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ValidationDataConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validation_data_config");

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    [TerraformPropertyName("validation_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ValidationMetrics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validation_metrics");

}
