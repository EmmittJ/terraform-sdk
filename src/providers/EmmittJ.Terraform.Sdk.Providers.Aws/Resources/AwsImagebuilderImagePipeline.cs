using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in AwsImagebuilderImagePipeline.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageScanningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_scanning_configuration";

    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ImageScanningEnabled
    {
        get => new TerraformReference<bool>(this, "image_scanning_enabled");
        set => SetArgument("image_scanning_enabled", value);
    }

    /// <summary>
    /// EcrConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcrConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderImagePipelineImageScanningConfigurationBlockEcrConfigurationBlock>? EcrConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderImagePipelineImageScanningConfigurationBlockEcrConfigurationBlock>>("ecr_configuration");
        set => SetArgument("ecr_configuration", value);
    }

}

/// <summary>
/// Block type for ecr_configuration in AwsImagebuilderImagePipelineImageScanningConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageScanningConfigurationBlockEcrConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_configuration";

    /// <summary>
    /// The container_tags attribute.
    /// </summary>
    public TerraformSet<string>? ContainerTags
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "container_tags").ResolveNodes(ctx));
        set => SetArgument("container_tags", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    public TerraformValue<string>? RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

}


/// <summary>
/// Block type for image_tests_configuration in AwsImagebuilderImagePipeline.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageTestsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_tests_configuration";

    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ImageTestsEnabled
    {
        get => new TerraformReference<bool>(this, "image_tests_enabled");
        set => SetArgument("image_tests_enabled", value);
    }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutMinutes
    {
        get => new TerraformReference<double>(this, "timeout_minutes");
        set => SetArgument("timeout_minutes", value);
    }

}


/// <summary>
/// Block type for schedule in AwsImagebuilderImagePipeline.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The pipeline_execution_start_condition attribute.
    /// </summary>
    public TerraformValue<string>? PipelineExecutionStartCondition
    {
        get => new TerraformReference<string>(this, "pipeline_execution_start_condition");
        set => SetArgument("pipeline_execution_start_condition", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

}


/// <summary>
/// Block type for workflow in AwsImagebuilderImagePipeline.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineWorkflowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workflow";

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformValue<string>? OnFailure
    {
        get => new TerraformReference<string>(this, "on_failure");
        set => SetArgument("on_failure", value);
    }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    public TerraformValue<string>? ParallelGroup
    {
        get => new TerraformReference<string>(this, "parallel_group");
        set => SetArgument("parallel_group", value);
    }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    public required TerraformValue<string> WorkflowArn
    {
        get => new TerraformReference<string>(this, "workflow_arn");
        set => SetArgument("workflow_arn", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderImagePipelineWorkflowBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsImagebuilderImagePipelineWorkflowBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsImagebuilderImagePipelineWorkflowBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImagePipelineWorkflowBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_image_pipeline Terraform resource.
/// Manages a aws_imagebuilder_image_pipeline resource.
/// </summary>
public partial class AwsImagebuilderImagePipeline(string name) : TerraformResource("aws_imagebuilder_image_pipeline", name)
{
    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformValue<string>? ContainerRecipeArn
    {
        get => new TerraformReference<string>(this, "container_recipe_arn");
        set => SetArgument("container_recipe_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string>? DistributionConfigurationArn
    {
        get => new TerraformReference<string>(this, "distribution_configuration_arn");
        set => SetArgument("distribution_configuration_arn", value);
    }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EnhancedImageMetadataEnabled
    {
        get => new TerraformReference<bool>(this, "enhanced_image_metadata_enabled");
        set => SetArgument("enhanced_image_metadata_enabled", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRole
    {
        get => new TerraformReference<string>(this, "execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    public TerraformValue<string>? ImageRecipeArn
    {
        get => new TerraformReference<string>(this, "image_recipe_arn");
        set => SetArgument("image_recipe_arn", value);
    }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    public required TerraformValue<string> InfrastructureConfigurationArn
    {
        get => new TerraformReference<string>(this, "infrastructure_configuration_arn");
        set => SetArgument("infrastructure_configuration_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
    {
        get => new TerraformReference<string>(this, "date_created");
    }

    /// <summary>
    /// The date_last_run attribute.
    /// </summary>
    public TerraformValue<string> DateLastRun
    {
        get => new TerraformReference<string>(this, "date_last_run");
    }

    /// <summary>
    /// The date_next_run attribute.
    /// </summary>
    public TerraformValue<string> DateNextRun
    {
        get => new TerraformReference<string>(this, "date_next_run");
    }

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformValue<string> DateUpdated
    {
        get => new TerraformReference<string>(this, "date_updated");
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// ImageScanningConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderImagePipelineImageScanningConfigurationBlock>? ImageScanningConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderImagePipelineImageScanningConfigurationBlock>>("image_scanning_configuration");
        set => SetArgument("image_scanning_configuration", value);
    }

    /// <summary>
    /// ImageTestsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderImagePipelineImageTestsConfigurationBlock>? ImageTestsConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderImagePipelineImageTestsConfigurationBlock>>("image_tests_configuration");
        set => SetArgument("image_tests_configuration", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AwsImagebuilderImagePipelineScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AwsImagebuilderImagePipelineScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Workflow block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsImagebuilderImagePipelineWorkflowBlock>? Workflow
    {
        get => GetArgument<TerraformList<AwsImagebuilderImagePipelineWorkflowBlock>>("workflow");
        set => SetArgument("workflow", value);
    }

}
