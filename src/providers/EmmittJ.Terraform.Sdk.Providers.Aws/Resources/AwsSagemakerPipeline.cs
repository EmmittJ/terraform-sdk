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
        set => SetProperty("max_parallel_execution_steps", value);
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
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectKey is required")]
    public required TerraformProperty<string> ObjectKey
    {
        set => SetProperty("object_key", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        set => SetProperty("version_id", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerPipeline : TerraformResource
{
    public AwsSagemakerPipeline(string name) : base("aws_sagemaker_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("pipeline_definition");
        SetOutput("pipeline_description");
        SetOutput("pipeline_display_name");
        SetOutput("pipeline_name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The pipeline_definition attribute.
    /// </summary>
    public TerraformProperty<string> PipelineDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_definition");
        set => SetProperty("pipeline_definition", value);
    }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    public TerraformProperty<string> PipelineDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_description");
        set => SetProperty("pipeline_description", value);
    }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineDisplayName is required")]
    public required TerraformProperty<string> PipelineDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_display_name");
        set => SetProperty("pipeline_display_name", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    public required TerraformProperty<string> PipelineName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_name");
        set => SetProperty("pipeline_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for parallelism_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    public List<AwsSagemakerPipelineParallelismConfigurationBlock>? ParallelismConfiguration
    {
        set => SetProperty("parallelism_configuration", value);
    }

    /// <summary>
    /// Block for pipeline_definition_s3_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineDefinitionS3Location block(s) allowed")]
    public List<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>? PipelineDefinitionS3Location
    {
        set => SetProperty("pipeline_definition_s3_location", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
