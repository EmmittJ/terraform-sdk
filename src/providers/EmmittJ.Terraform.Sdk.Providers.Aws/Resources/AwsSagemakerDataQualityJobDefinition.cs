using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_quality_app_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock() : TerraformBlock("data_quality_app_specification")
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    [TerraformProperty("image_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageUri { get; set; }

    /// <summary>
    /// The post_analytics_processor_source_uri attribute.
    /// </summary>
    [TerraformProperty("post_analytics_processor_source_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostAnalyticsProcessorSourceUri { get; set; }

    /// <summary>
    /// The record_preprocessor_source_uri attribute.
    /// </summary>
    [TerraformProperty("record_preprocessor_source_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RecordPreprocessorSourceUri { get; set; }

}

/// <summary>
/// Block type for data_quality_baseline_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock() : TerraformBlock("data_quality_baseline_config")
{
}

/// <summary>
/// Block type for data_quality_job_input in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock() : TerraformBlock("data_quality_job_input")
{
}

/// <summary>
/// Block type for data_quality_job_output_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock() : TerraformBlock("data_quality_job_output_config")
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for job_resources in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionJobResourcesBlock() : TerraformBlock("job_resources")
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock() : TerraformBlock("network_config")
{
    /// <summary>
    /// The enable_inter_container_traffic_encryption attribute.
    /// </summary>
    [TerraformProperty("enable_inter_container_traffic_encryption")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableInterContainerTrafficEncryption { get; set; }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    [TerraformProperty("enable_network_isolation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNetworkIsolation { get; set; }

}

/// <summary>
/// Block type for stopping_condition in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock() : TerraformBlock("stopping_condition")
{
    /// <summary>
    /// The max_runtime_in_seconds attribute.
    /// </summary>
    [TerraformProperty("max_runtime_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxRuntimeInSeconds { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_data_quality_job_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerDataQualityJobDefinition : TerraformResource
{
    public AwsSagemakerDataQualityJobDefinition(string name) : base("aws_sagemaker_data_quality_job_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for data_quality_app_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityAppSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityAppSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityAppSpecification block(s) allowed")]
    [TerraformProperty("data_quality_app_specification")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock> DataQualityAppSpecification { get; set; } = new();

    /// <summary>
    /// Block for data_quality_baseline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityBaselineConfig block(s) allowed")]
    [TerraformProperty("data_quality_baseline_config")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock> DataQualityBaselineConfig { get; set; } = new();

    /// <summary>
    /// Block for data_quality_job_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobInput is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobInput block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobInput block(s) allowed")]
    [TerraformProperty("data_quality_job_input")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock> DataQualityJobInput { get; set; } = new();

    /// <summary>
    /// Block for data_quality_job_output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobOutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobOutputConfig block(s) allowed")]
    [TerraformProperty("data_quality_job_output_config")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock> DataQualityJobOutputConfig { get; set; } = new();

    /// <summary>
    /// Block for job_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobResources block(s) allowed")]
    [TerraformProperty("job_resources")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock> JobResources { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock> NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for stopping_condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoppingCondition block(s) allowed")]
    [TerraformProperty("stopping_condition")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock> StoppingCondition { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
