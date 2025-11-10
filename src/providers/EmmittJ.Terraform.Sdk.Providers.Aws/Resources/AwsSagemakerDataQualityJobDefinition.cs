using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_quality_app_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Environment { get; set; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    [TerraformPropertyName("image_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImageUri { get; set; }

    /// <summary>
    /// The post_analytics_processor_source_uri attribute.
    /// </summary>
    [TerraformPropertyName("post_analytics_processor_source_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostAnalyticsProcessorSourceUri { get; set; }

    /// <summary>
    /// The record_preprocessor_source_uri attribute.
    /// </summary>
    [TerraformPropertyName("record_preprocessor_source_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecordPreprocessorSourceUri { get; set; }

}

/// <summary>
/// Block type for data_quality_baseline_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for data_quality_job_input in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for data_quality_job_output_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for job_resources in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionJobResourcesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_inter_container_traffic_encryption attribute.
    /// </summary>
    [TerraformPropertyName("enable_inter_container_traffic_encryption")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableInterContainerTrafficEncryption { get; set; }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_isolation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableNetworkIsolation { get; set; }

}

/// <summary>
/// Block type for stopping_condition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock : ITerraformBlock
{
    /// <summary>
    /// The max_runtime_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_runtime_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxRuntimeInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_runtime_in_seconds");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for data_quality_app_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityAppSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityAppSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityAppSpecification block(s) allowed")]
    [TerraformPropertyName("data_quality_app_specification")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock>>? DataQualityAppSpecification { get; set; } = new();

    /// <summary>
    /// Block for data_quality_baseline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityBaselineConfig block(s) allowed")]
    [TerraformPropertyName("data_quality_baseline_config")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock>>? DataQualityBaselineConfig { get; set; } = new();

    /// <summary>
    /// Block for data_quality_job_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobInput is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobInput block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobInput block(s) allowed")]
    [TerraformPropertyName("data_quality_job_input")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock>>? DataQualityJobInput { get; set; } = new();

    /// <summary>
    /// Block for data_quality_job_output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobOutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobOutputConfig block(s) allowed")]
    [TerraformPropertyName("data_quality_job_output_config")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock>>? DataQualityJobOutputConfig { get; set; } = new();

    /// <summary>
    /// Block for job_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobResources block(s) allowed")]
    [TerraformPropertyName("job_resources")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock>>? JobResources { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for stopping_condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoppingCondition block(s) allowed")]
    [TerraformPropertyName("stopping_condition")]
    public TerraformList<TerraformBlock<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock>>? StoppingCondition { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
