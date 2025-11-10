using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelOutputDataConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    [TerraformPropertyName("s3_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockCustomModelTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Block type for training_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelTrainingDataConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    [TerraformPropertyName("s3_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Uri { get; set; }

}

/// <summary>
/// Block type for validation_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelValidationDataConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_bedrock_custom_model resource.
/// </summary>
public class AwsBedrockCustomModel : TerraformResource
{
    public AwsBedrockCustomModel(string name) : base("aws_bedrock_custom_model", name)
    {
    }

    /// <summary>
    /// The base_model_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelIdentifier is required")]
    [TerraformPropertyName("base_model_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BaseModelIdentifier { get; set; }

    /// <summary>
    /// The custom_model_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_model_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomModelKmsKeyId { get; set; }

    /// <summary>
    /// The custom_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomModelName is required")]
    [TerraformPropertyName("custom_model_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomModelName { get; set; }

    /// <summary>
    /// The customization_type attribute.
    /// </summary>
    [TerraformPropertyName("customization_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomizationType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customization_type");

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hyperparameters is required")]
    [TerraformPropertyName("hyperparameters")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Hyperparameters { get; set; }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    [TerraformPropertyName("job_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JobName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for output_data_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("output_data_config")]
    public TerraformList<TerraformBlock<AwsBedrockCustomModelOutputDataConfigBlock>>? OutputDataConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockCustomModelTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for training_data_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("training_data_config")]
    public TerraformList<TerraformBlock<AwsBedrockCustomModelTrainingDataConfigBlock>>? TrainingDataConfig { get; set; } = new();

    /// <summary>
    /// Block for validation_data_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("validation_data_config")]
    public TerraformList<TerraformBlock<AwsBedrockCustomModelValidationDataConfigBlock>>? ValidationDataConfig { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsBedrockCustomModelVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// The custom_model_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_model_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomModelArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_model_arn");

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
    /// The job_status attribute.
    /// </summary>
    [TerraformPropertyName("job_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    [TerraformPropertyName("training_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrainingMetrics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "training_metrics");

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    [TerraformPropertyName("validation_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ValidationMetrics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validation_metrics");

}
