using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_quality_app_specification in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment");
        set => WithProperty("environment", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    public required TerraformProperty<string> ImageUri
    {
        get => GetProperty<TerraformProperty<string>>("image_uri");
        set => WithProperty("image_uri", value);
    }

    /// <summary>
    /// The post_analytics_processor_source_uri attribute.
    /// </summary>
    public TerraformProperty<string>? PostAnalyticsProcessorSourceUri
    {
        get => GetProperty<TerraformProperty<string>>("post_analytics_processor_source_uri");
        set => WithProperty("post_analytics_processor_source_uri", value);
    }

    /// <summary>
    /// The record_preprocessor_source_uri attribute.
    /// </summary>
    public TerraformProperty<string>? RecordPreprocessorSourceUri
    {
        get => GetProperty<TerraformProperty<string>>("record_preprocessor_source_uri");
        set => WithProperty("record_preprocessor_source_uri", value);
    }

}

/// <summary>
/// Block type for data_quality_baseline_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for data_quality_job_input in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock : TerraformBlock
{
}

/// <summary>
/// Block type for data_quality_job_output_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for job_resources in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionJobResourcesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enable_inter_container_traffic_encryption attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableInterContainerTrafficEncryption
    {
        get => GetProperty<TerraformProperty<bool>>("enable_inter_container_traffic_encryption");
        set => WithProperty("enable_inter_container_traffic_encryption", value);
    }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableNetworkIsolation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_network_isolation");
        set => WithProperty("enable_network_isolation", value);
    }

}

/// <summary>
/// Block type for stopping_condition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock : TerraformBlock
{
    /// <summary>
    /// The max_runtime_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRuntimeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_runtime_in_seconds");
        set => WithProperty("max_runtime_in_seconds", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_data_quality_job_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerDataQualityJobDefinition : TerraformResource
{
    public AwsSagemakerDataQualityJobDefinition(string name) : base("aws_sagemaker_data_quality_job_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for data_quality_app_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityAppSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityAppSpecification block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock>? DataQualityAppSpecification
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock>>("data_quality_app_specification");
        set => this.WithProperty("data_quality_app_specification", value);
    }

    /// <summary>
    /// Block for data_quality_baseline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityBaselineConfig block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock>? DataQualityBaselineConfig
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock>>("data_quality_baseline_config");
        set => this.WithProperty("data_quality_baseline_config", value);
    }

    /// <summary>
    /// Block for data_quality_job_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobInput block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobInput block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock>? DataQualityJobInput
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock>>("data_quality_job_input");
        set => this.WithProperty("data_quality_job_input", value);
    }

    /// <summary>
    /// Block for data_quality_job_output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobOutputConfig block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock>? DataQualityJobOutputConfig
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock>>("data_quality_job_output_config");
        set => this.WithProperty("data_quality_job_output_config", value);
    }

    /// <summary>
    /// Block for job_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobResources block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock>? JobResources
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock>>("job_resources");
        set => this.WithProperty("job_resources", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for stopping_condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoppingCondition block(s) allowed")]
    public List<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock>? StoppingCondition
    {
        get => GetProperty<List<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock>>("stopping_condition");
        set => this.WithProperty("stopping_condition", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
