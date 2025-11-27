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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The build_version_arn attribute.
    /// </summary>
    public TerraformValue<string> BuildVersionArn
    {
        get => new TerraformReference<string>(this, "build_version_arn");
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    public TerraformValue<string> ContainerRecipeArn
    {
        get => new TerraformReference<string>(this, "container_recipe_arn");
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
    {
        get => new TerraformReference<string>(this, "date_created");
    }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> DistributionConfigurationArn
    {
        get => new TerraformReference<string>(this, "distribution_configuration_arn");
    }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedImageMetadataEnabled
    {
        get => new TerraformReference<bool>(this, "enhanced_image_metadata_enabled");
    }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    public TerraformValue<string> ImageRecipeArn
    {
        get => new TerraformReference<string>(this, "image_recipe_arn");
    }

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageScanningConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_scanning_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageTestsConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_tests_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> InfrastructureConfigurationArn
    {
        get => new TerraformReference<string>(this, "infrastructure_configuration_arn");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    public TerraformValue<string> OsVersion
    {
        get => new TerraformReference<string>(this, "os_version");
    }

    /// <summary>
    /// The output_resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutputResources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "output_resources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
