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
        this.DeclareOutput("component");
        this.DeclareOutput("container_type");
        this.DeclareOutput("date_created");
        this.DeclareOutput("description");
        this.DeclareOutput("dockerfile_template_data");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("instance_configuration");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("name");
        this.DeclareOutput("owner");
        this.DeclareOutput("parent_image");
        this.DeclareOutput("platform");
        this.DeclareOutput("target_repository");
        this.DeclareOutput("version");
        this.DeclareOutput("working_directory");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
