using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_imagebuilder_image_pipeline Terraform data source.
/// Retrieves information about a aws_imagebuilder_image_pipeline.
/// </summary>
public partial class AwsImagebuilderImagePipelineDataSource(string name) : TerraformDataSource("aws_imagebuilder_image_pipeline", name)
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
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
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Schedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
