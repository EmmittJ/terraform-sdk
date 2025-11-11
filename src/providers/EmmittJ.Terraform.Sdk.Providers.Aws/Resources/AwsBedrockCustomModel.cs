using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_data_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockCustomModelOutputDataConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    [TerraformProperty("s3_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockCustomModelTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Block type for training_data_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockCustomModelTrainingDataConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    [TerraformProperty("s3_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3Uri { get; set; }

}

/// <summary>
/// Block type for validation_data_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockCustomModelValidationDataConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockCustomModelVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_bedrock_custom_model resource.
/// </summary>
public partial class AwsBedrockCustomModel : TerraformResource
{
    public AwsBedrockCustomModel(string name) : base("aws_bedrock_custom_model", name)
    {
    }

    /// <summary>
    /// The base_model_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelIdentifier is required")]
    [TerraformProperty("base_model_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BaseModelIdentifier { get; set; }

    /// <summary>
    /// The custom_model_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("custom_model_kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomModelKmsKeyId { get; set; }

    /// <summary>
    /// The custom_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomModelName is required")]
    [TerraformProperty("custom_model_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomModelName { get; set; }

    /// <summary>
    /// The customization_type attribute.
    /// </summary>
    [TerraformProperty("customization_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CustomizationType { get; set; }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hyperparameters is required")]
    [TerraformProperty("hyperparameters")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> Hyperparameters { get; set; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    [TerraformProperty("job_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for output_data_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("output_data_config")]
    public partial TerraformList<TerraformBlock<AwsBedrockCustomModelOutputDataConfigBlock>>? OutputDataConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsBedrockCustomModelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for training_data_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("training_data_config")]
    public partial TerraformList<TerraformBlock<AwsBedrockCustomModelTrainingDataConfigBlock>>? TrainingDataConfig { get; set; }

    /// <summary>
    /// Block for validation_data_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("validation_data_config")]
    public partial TerraformList<TerraformBlock<AwsBedrockCustomModelValidationDataConfigBlock>>? ValidationDataConfig { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("vpc_config")]
    public partial TerraformList<TerraformBlock<AwsBedrockCustomModelVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The custom_model_arn attribute.
    /// </summary>
    [TerraformProperty("custom_model_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomModelArn { get; }

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
    /// The job_status attribute.
    /// </summary>
    [TerraformProperty("job_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobStatus { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    [TerraformProperty("training_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TrainingMetrics { get; }

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    [TerraformProperty("validation_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ValidationMetrics { get; }

}
