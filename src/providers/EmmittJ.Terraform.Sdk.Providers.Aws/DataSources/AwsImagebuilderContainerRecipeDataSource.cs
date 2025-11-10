using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_container_recipe.
/// </summary>
public class AwsImagebuilderContainerRecipeDataSource : TerraformDataSource
{
    public AwsImagebuilderContainerRecipeDataSource(string name) : base("aws_imagebuilder_container_recipe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("component");
        SetOutput("container_type");
        SetOutput("date_created");
        SetOutput("description");
        SetOutput("dockerfile_template_data");
        SetOutput("encrypted");
        SetOutput("instance_configuration");
        SetOutput("kms_key_id");
        SetOutput("name");
        SetOutput("owner");
        SetOutput("parent_image");
        SetOutput("platform");
        SetOutput("target_repository");
        SetOutput("version");
        SetOutput("working_directory");
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
    /// The component attribute.
    /// </summary>
    public TerraformExpression Component => this["component"];

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformExpression ContainerType => this["container_type"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformExpression DockerfileTemplateData => this["dockerfile_template_data"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    public TerraformExpression InstanceConfiguration => this["instance_configuration"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    public TerraformExpression ParentImage => this["parent_image"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The target_repository attribute.
    /// </summary>
    public TerraformExpression TargetRepository => this["target_repository"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformExpression WorkingDirectory => this["working_directory"];

}
