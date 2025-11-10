using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image_pipeline.
/// </summary>
public class AwsImagebuilderImagePipelineDataSource : TerraformDataSource
{
    public AwsImagebuilderImagePipelineDataSource(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("container_recipe_arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("date_last_run");
        this.DeclareOutput("date_next_run");
        this.DeclareOutput("date_updated");
        this.DeclareOutput("description");
        this.DeclareOutput("distribution_configuration_arn");
        this.DeclareOutput("enhanced_image_metadata_enabled");
        this.DeclareOutput("image_recipe_arn");
        this.DeclareOutput("image_scanning_configuration");
        this.DeclareOutput("image_tests_configuration");
        this.DeclareOutput("infrastructure_configuration_arn");
        this.DeclareOutput("name");
        this.DeclareOutput("platform");
        this.DeclareOutput("schedule");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformExpression ContainerRecipeArn => this["container_recipe_arn"];

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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public TerraformExpression DistributionConfigurationArn => this["distribution_configuration_arn"];

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public TerraformExpression EnhancedImageMetadataEnabled => this["enhanced_image_metadata_enabled"];

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    public TerraformExpression ImageRecipeArn => this["image_recipe_arn"];

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    public TerraformExpression ImageScanningConfiguration => this["image_scanning_configuration"];

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    public TerraformExpression ImageTestsConfiguration => this["image_tests_configuration"];

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    public TerraformExpression InfrastructureConfigurationArn => this["infrastructure_configuration_arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformExpression Schedule => this["schedule"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
