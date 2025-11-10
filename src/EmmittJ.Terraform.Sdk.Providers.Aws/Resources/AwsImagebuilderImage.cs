using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageImageScanningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageScanningEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("image_scanning_enabled");
        set => WithProperty("image_scanning_enabled", value);
    }

}

/// <summary>
/// Block type for image_tests_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageImageTestsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageTestsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("image_tests_enabled");
        set => WithProperty("image_tests_enabled", value);
    }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutMinutes
    {
        get => GetProperty<TerraformProperty<double>>("timeout_minutes");
        set => WithProperty("timeout_minutes", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsImagebuilderImageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Block type for workflow in .
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImageWorkflowBlock : TerraformBlock
{
    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformProperty<string>? OnFailure
    {
        get => GetProperty<TerraformProperty<string>>("on_failure");
        set => WithProperty("on_failure", value);
    }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    public TerraformProperty<string>? ParallelGroup
    {
        get => GetProperty<TerraformProperty<string>>("parallel_group");
        set => WithProperty("parallel_group", value);
    }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    public required TerraformProperty<string> WorkflowArn
    {
        get => GetProperty<TerraformProperty<string>>("workflow_arn");
        set => WithProperty("workflow_arn", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderImage : TerraformResource
{
    public AwsImagebuilderImage(string name) : base("aws_imagebuilder_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("name");
        this.DeclareOutput("os_version");
        this.DeclareOutput("output_resources");
        this.DeclareOutput("platform");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRecipeArn
    {
        get => GetProperty<TerraformProperty<string>>("container_recipe_arn");
        set => this.WithProperty("container_recipe_arn", value);
    }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DistributionConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("distribution_configuration_arn");
        set => this.WithProperty("distribution_configuration_arn", value);
    }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EnhancedImageMetadataEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("enhanced_image_metadata_enabled");
        set => this.WithProperty("enhanced_image_metadata_enabled", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => this.WithProperty("execution_role", value);
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
    /// The image_recipe_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ImageRecipeArn
    {
        get => GetProperty<TerraformProperty<string>>("image_recipe_arn");
        set => this.WithProperty("image_recipe_arn", value);
    }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    public required TerraformProperty<string> InfrastructureConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("infrastructure_configuration_arn");
        set => this.WithProperty("infrastructure_configuration_arn", value);
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
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    public List<AwsImagebuilderImageImageScanningConfigurationBlock>? ImageScanningConfiguration
    {
        get => GetProperty<List<AwsImagebuilderImageImageScanningConfigurationBlock>>("image_scanning_configuration");
        set => this.WithProperty("image_scanning_configuration", value);
    }

    /// <summary>
    /// Block for image_tests_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    public List<AwsImagebuilderImageImageTestsConfigurationBlock>? ImageTestsConfiguration
    {
        get => GetProperty<List<AwsImagebuilderImageImageTestsConfigurationBlock>>("image_tests_configuration");
        set => this.WithProperty("image_tests_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsImagebuilderImageTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsImagebuilderImageTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workflow.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsImagebuilderImageWorkflowBlock>? Workflow
    {
        get => GetProperty<HashSet<AwsImagebuilderImageWorkflowBlock>>("workflow");
        set => this.WithProperty("workflow", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformExpression OsVersion => this["os_version"];

    /// <summary>
    /// The output_resources attribute.
    /// </summary>
    public TerraformExpression OutputResources => this["output_resources"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
