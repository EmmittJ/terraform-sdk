using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_imagebuilder_image_pipeline resource.
/// </summary>
public class AwsImagebuilderImagePipeline : TerraformResource
{
    public AwsImagebuilderImagePipeline(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("date_last_run");
        this.DeclareOutput("date_next_run");
        this.DeclareOutput("date_updated");
        this.DeclareOutput("platform");
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    public TerraformProperty<string>? InfrastructureConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("infrastructure_configuration_arn");
        set => this.WithProperty("infrastructure_configuration_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
