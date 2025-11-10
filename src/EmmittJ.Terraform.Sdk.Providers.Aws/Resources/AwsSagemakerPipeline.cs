using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parallelism_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelineParallelismConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_parallel_execution_steps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxParallelExecutionSteps is required")]
    public required TerraformProperty<double> MaxParallelExecutionSteps
    {
        get => GetProperty<TerraformProperty<double>>("max_parallel_execution_steps");
        set => WithProperty("max_parallel_execution_steps", value);
    }

}

/// <summary>
/// Block type for pipeline_definition_s3_location in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelinePipelineDefinitionS3LocationBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectKey is required")]
    public required TerraformProperty<string> ObjectKey
    {
        get => GetProperty<TerraformProperty<string>>("object_key");
        set => WithProperty("object_key", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => WithProperty("version_id", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_pipeline resource.
/// </summary>
public class AwsSagemakerPipeline : TerraformResource
{
    public AwsSagemakerPipeline(string name) : base("aws_sagemaker_pipeline", name)
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
    /// The pipeline_definition attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineDefinition
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_definition");
        set => this.WithProperty("pipeline_definition", value);
    }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineDescription
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_description");
        set => this.WithProperty("pipeline_description", value);
    }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineDisplayName is required")]
    public required TerraformProperty<string> PipelineDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_display_name");
        set => this.WithProperty("pipeline_display_name", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    public required TerraformProperty<string> PipelineName
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_name");
        set => this.WithProperty("pipeline_name", value);
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
    public TerraformProperty<string>? RoleArn
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
    /// Block for parallelism_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    public List<AwsSagemakerPipelineParallelismConfigurationBlock>? ParallelismConfiguration
    {
        get => GetProperty<List<AwsSagemakerPipelineParallelismConfigurationBlock>>("parallelism_configuration");
        set => this.WithProperty("parallelism_configuration", value);
    }

    /// <summary>
    /// Block for pipeline_definition_s3_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineDefinitionS3Location block(s) allowed")]
    public List<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>? PipelineDefinitionS3Location
    {
        get => GetProperty<List<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>>("pipeline_definition_s3_location");
        set => this.WithProperty("pipeline_definition_s3_location", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
