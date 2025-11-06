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
    public string? ContainerRecipeArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_recipe_arn")?.Value;
        set => this.WithProperty("container_recipe_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    public string? DistributionConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("distribution_configuration_arn")?.Value;
        set => this.WithProperty("distribution_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    public bool? EnhancedImageMetadataEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enhanced_image_metadata_enabled")?.Value;
        set => this.WithProperty("enhanced_image_metadata_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public string? ExecutionRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role")?.Value;
        set => this.WithProperty("execution_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    public string? ImageRecipeArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_recipe_arn")?.Value;
        set => this.WithProperty("image_recipe_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    public string? InfrastructureConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("infrastructure_configuration_arn")?.Value;
        set => this.WithProperty("infrastructure_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
