using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_imagebuilder_container_recipe resource.
/// </summary>
public class AwsImagebuilderContainerRecipe : TerraformResource
{
    public AwsImagebuilderContainerRecipe(string name) : base("aws_imagebuilder_container_recipe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("owner");
        this.DeclareOutput("platform");
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerType
    {
        get => GetProperty<TerraformProperty<string>>("container_type");
        set => this.WithProperty("container_type", value);
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
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformProperty<string>? DockerfileTemplateData
    {
        get => GetProperty<TerraformProperty<string>>("dockerfile_template_data");
        set => this.WithProperty("dockerfile_template_data", value);
    }

    /// <summary>
    /// The dockerfile_template_uri attribute.
    /// </summary>
    public TerraformProperty<string>? DockerfileTemplateUri
    {
        get => GetProperty<TerraformProperty<string>>("dockerfile_template_uri");
        set => this.WithProperty("dockerfile_template_uri", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
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
    /// The parent_image attribute.
    /// </summary>
    public TerraformProperty<string>? ParentImage
    {
        get => GetProperty<TerraformProperty<string>>("parent_image");
        set => this.WithProperty("parent_image", value);
    }

    /// <summary>
    /// The platform_override attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformOverride
    {
        get => GetProperty<TerraformProperty<string>>("platform_override");
        set => this.WithProperty("platform_override", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformProperty<string>? WorkingDirectory
    {
        get => GetProperty<TerraformProperty<string>>("working_directory");
        set => this.WithProperty("working_directory", value);
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
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

}
