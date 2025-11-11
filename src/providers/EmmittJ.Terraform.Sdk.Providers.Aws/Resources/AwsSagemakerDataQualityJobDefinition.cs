using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_quality_app_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    [TerraformPropertyName("image_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageUri { get; set; }

    /// <summary>
    /// The post_analytics_processor_source_uri attribute.
    /// </summary>
    [TerraformPropertyName("post_analytics_processor_source_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PostAnalyticsProcessorSourceUri { get; set; }

    /// <summary>
    /// The record_preprocessor_source_uri attribute.
    /// </summary>
    [TerraformPropertyName("record_preprocessor_source_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecordPreprocessorSourceUri { get; set; }

}

/// <summary>
/// Block type for data_quality_baseline_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock
{
}

/// <summary>
/// Block type for data_quality_job_input in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock
{
}

/// <summary>
/// Block type for data_quality_job_output_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for job_resources in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionJobResourcesBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock
{
    /// <summary>
    /// The enable_inter_container_traffic_encryption attribute.
    /// </summary>
    [TerraformPropertyName("enable_inter_container_traffic_encryption")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableInterContainerTrafficEncryption { get; set; }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_isolation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableNetworkIsolation { get; set; }

}

/// <summary>
/// Block type for stopping_condition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock
{
    /// <summary>
    /// The max_runtime_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_runtime_in_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxRuntimeInSeconds { get; set; } = default!;

}

/// <summary>
/// Manages a aws_sagemaker_data_quality_job_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerDataQualityJobDefinition : TerraformResource
{
    public AwsSagemakerDataQualityJobDefinition(string name) : base("aws_sagemaker_data_quality_job_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for data_quality_app_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityAppSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityAppSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityAppSpecification block(s) allowed")]
    [TerraformPropertyName("data_quality_app_specification")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock>>? DataQualityAppSpecification { get; set; }

    /// <summary>
    /// Block for data_quality_baseline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityBaselineConfig block(s) allowed")]
    [TerraformPropertyName("data_quality_baseline_config")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock>>? DataQualityBaselineConfig { get; set; }

    /// <summary>
    /// Block for data_quality_job_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobInput is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobInput block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobInput block(s) allowed")]
    [TerraformPropertyName("data_quality_job_input")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock>>? DataQualityJobInput { get; set; }

    /// <summary>
    /// Block for data_quality_job_output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobOutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobOutputConfig block(s) allowed")]
    [TerraformPropertyName("data_quality_job_output_config")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock>>? DataQualityJobOutputConfig { get; set; }

    /// <summary>
    /// Block for job_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobResources block(s) allowed")]
    [TerraformPropertyName("job_resources")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock>>? JobResources { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for stopping_condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoppingCondition block(s) allowed")]
    [TerraformPropertyName("stopping_condition")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock>>? StoppingCondition { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
