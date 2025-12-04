using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parallelism_configuration in AwsSagemakerPipeline.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelineParallelismConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parallelism_configuration";

    /// <summary>
    /// The max_parallel_execution_steps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxParallelExecutionSteps is required")]
    public required TerraformValue<double> MaxParallelExecutionSteps
    {
        get => GetArgument<TerraformValue<double>>("max_parallel_execution_steps");
        set => SetArgument("max_parallel_execution_steps", value);
    }

}


/// <summary>
/// Block type for pipeline_definition_s3_location in AwsSagemakerPipeline.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelinePipelineDefinitionS3LocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_definition_s3_location";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectKey is required")]
    public required TerraformValue<string> ObjectKey
    {
        get => GetArgument<TerraformValue<string>>("object_key");
        set => SetArgument("object_key", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string>? VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id");
        set => SetArgument("version_id", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_pipeline Terraform resource.
/// Manages a aws_sagemaker_pipeline resource.
/// </summary>
public partial class AwsSagemakerPipeline(string name) : TerraformResource("aws_sagemaker_pipeline", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pipeline_definition attribute.
    /// </summary>
    public TerraformValue<string>? PipelineDefinition
    {
        get => GetArgument<TerraformValue<string>>("pipeline_definition");
        set => SetArgument("pipeline_definition", value);
    }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    public TerraformValue<string>? PipelineDescription
    {
        get => GetArgument<TerraformValue<string>>("pipeline_description");
        set => SetArgument("pipeline_description", value);
    }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineDisplayName is required")]
    public required TerraformValue<string> PipelineDisplayName
    {
        get => GetArgument<TerraformValue<string>>("pipeline_display_name");
        set => SetArgument("pipeline_display_name", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    public required TerraformValue<string> PipelineName
    {
        get => GetArgument<TerraformValue<string>>("pipeline_name");
        set => SetArgument("pipeline_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// ParallelismConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    public TerraformList<AwsSagemakerPipelineParallelismConfigurationBlock>? ParallelismConfiguration
    {
        get => GetArgument<TerraformList<AwsSagemakerPipelineParallelismConfigurationBlock>>("parallelism_configuration");
        set => SetArgument("parallelism_configuration", value);
    }

    /// <summary>
    /// PipelineDefinitionS3Location block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineDefinitionS3Location block(s) allowed")]
    public TerraformList<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>? PipelineDefinitionS3Location
    {
        get => GetArgument<TerraformList<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>>("pipeline_definition_s3_location");
        set => SetArgument("pipeline_definition_s3_location", value);
    }

}
