using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_imagebuilder_image Terraform data source.
/// Retrieves information about a aws_imagebuilder_image.
/// </summary>
public partial class AwsImagebuilderImageDataSource(string name) : TerraformDataSource("aws_imagebuilder_image", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The build_version_arn attribute.
    /// </summary>
    public TerraformValue<string> BuildVersionArn
        => AsReference("build_version_arn");

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformValue<string> ContainerRecipeArn
        => AsReference("container_recipe_arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => AsReference("date_created");

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> DistributionConfigurationArn
        => AsReference("distribution_configuration_arn");

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedImageMetadataEnabled
        => AsReference("enhanced_image_metadata_enabled");

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    public TerraformValue<string> ImageRecipeArn
        => AsReference("image_recipe_arn");

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageScanningConfiguration
        => AsReference("image_scanning_configuration");

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageTestsConfiguration
        => AsReference("image_tests_configuration");

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> InfrastructureConfigurationArn
        => AsReference("infrastructure_configuration_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformValue<string> OsVersion
        => AsReference("os_version");

    /// <summary>
    /// The output_resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutputResources
        => AsReference("output_resources");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
        => AsReference("platform");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}
