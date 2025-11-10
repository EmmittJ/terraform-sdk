using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageScanningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageScanningEnabled
    {
        set => SetProperty("image_scanning_enabled", value);
    }

}

/// <summary>
/// Block type for image_tests_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageTestsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageTestsEnabled
    {
        set => SetProperty("image_tests_enabled", value);
    }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutMinutes
    {
        set => SetProperty("timeout_minutes", value);
    }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The pipeline_execution_start_condition attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineExecutionStartCondition
    {
        set => SetProperty("pipeline_execution_start_condition", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        set => SetProperty("schedule_expression", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        set => SetProperty("timezone", value);
    }

}

/// <summary>
/// Block type for workflow in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineWorkflowBlock : TerraformBlock
{
    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformProperty<string>? OnFailure
    {
        set => SetProperty("on_failure", value);
    }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    public TerraformProperty<string>? ParallelGroup
    {
        set => SetProperty("parallel_group", value);
    }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    public required TerraformProperty<string> WorkflowArn
    {
        set => SetProperty("workflow_arn", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_image_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderImagePipeline : TerraformResource
{
    public AwsImagebuilderImagePipeline(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("date_created");
        SetOutput("date_last_run");
        SetOutput("date_next_run");
        SetOutput("date_updated");
        SetOutput("platform");
        SetOutput("container_recipe_arn");
        SetOutput("description");
        SetOutput("distribution_configuration_arn");
        SetOutput("enhanced_image_metadata_enabled");
        SetOutput("execution_role");
        SetOutput("id");
        SetOutput("image_recipe_arn");
        SetOutput("infrastructure_configuration_arn");
        SetOutput("name");
        SetOutput("region");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformProperty<string> ContainerRecipeArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_recipe_arn");
        set => SetProperty("container_recipe_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string> DistributionConfigurationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("distribution_configuration_arn");
        set => SetProperty("distribution_configuration_arn", value);
    }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EnhancedImageMetadataEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enhanced_image_metadata_enabled");
        set => SetProperty("enhanced_image_metadata_enabled", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformProperty<string> ExecutionRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role");
        set => SetProperty("execution_role", value);
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
    /// The image_recipe_arn attribute.
    /// </summary>
    public TerraformProperty<string> ImageRecipeArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_recipe_arn");
        set => SetProperty("image_recipe_arn", value);
    }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    public required TerraformProperty<string> InfrastructureConfigurationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("infrastructure_configuration_arn");
        set => SetProperty("infrastructure_configuration_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    public List<AwsImagebuilderImagePipelineImageScanningConfigurationBlock>? ImageScanningConfiguration
    {
        set => SetProperty("image_scanning_configuration", value);
    }

    /// <summary>
    /// Block for image_tests_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    public List<AwsImagebuilderImagePipelineImageTestsConfigurationBlock>? ImageTestsConfiguration
    {
        set => SetProperty("image_tests_configuration", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AwsImagebuilderImagePipelineScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for workflow.
    /// Nesting mode: list
    /// </summary>
    public List<AwsImagebuilderImagePipelineWorkflowBlock>? Workflow
    {
        set => SetProperty("workflow", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The date_last_run attribute.
    /// </summary>
    public TerraformExpression DateLastRun => this["date_last_run"];

    /// <summary>
    /// The date_next_run attribute.
    /// </summary>
    public TerraformExpression DateNextRun => this["date_next_run"];

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformExpression DateUpdated => this["date_updated"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

}
