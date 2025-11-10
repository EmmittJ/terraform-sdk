using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image.
/// </summary>
public class AwsImagebuilderImageDataSource : TerraformDataSource
{
    public AwsImagebuilderImageDataSource(string name) : base("aws_imagebuilder_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("build_version_arn");
        SetOutput("container_recipe_arn");
        SetOutput("date_created");
        SetOutput("distribution_configuration_arn");
        SetOutput("enhanced_image_metadata_enabled");
        SetOutput("image_recipe_arn");
        SetOutput("image_scanning_configuration");
        SetOutput("image_tests_configuration");
        SetOutput("infrastructure_configuration_arn");
        SetOutput("name");
        SetOutput("os_version");
        SetOutput("output_resources");
        SetOutput("platform");
        SetOutput("version");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The build_version_arn attribute.
    /// </summary>
    public TerraformExpression BuildVersionArn => this["build_version_arn"];

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformExpression ContainerRecipeArn => this["container_recipe_arn"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

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
