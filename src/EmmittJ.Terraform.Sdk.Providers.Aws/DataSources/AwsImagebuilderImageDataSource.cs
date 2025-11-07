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
        this.DeclareOutput("build_version_arn");
        this.DeclareOutput("container_recipe_arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("distribution_configuration_arn");
        this.DeclareOutput("enhanced_image_metadata_enabled");
        this.DeclareOutput("image_recipe_arn");
        this.DeclareOutput("image_scanning_configuration");
        this.DeclareOutput("image_tests_configuration");
        this.DeclareOutput("infrastructure_configuration_arn");
        this.DeclareOutput("name");
        this.DeclareOutput("os_version");
        this.DeclareOutput("output_resources");
        this.DeclareOutput("platform");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
