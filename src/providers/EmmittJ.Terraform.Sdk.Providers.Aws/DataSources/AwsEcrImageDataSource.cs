using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_image.
/// </summary>
public class AwsEcrImageDataSource : TerraformDataSource
{
    public AwsEcrImageDataSource(string name) : base("aws_ecr_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("image_pushed_at");
        this.WithOutput("image_size_in_bytes");
        this.WithOutput("image_tags");
        this.WithOutput("image_uri");
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
    /// The image_digest attribute.
    /// </summary>
    public TerraformProperty<string>? ImageDigest
    {
        get => GetProperty<TerraformProperty<string>>("image_digest");
        set => this.WithProperty("image_digest", value);
    }

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ImageTag
    {
        get => GetProperty<TerraformProperty<string>>("image_tag");
        set => this.WithProperty("image_tag", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
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
    /// The registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? RegistryId
    {
        get => GetProperty<TerraformProperty<string>>("registry_id");
        set => this.WithProperty("registry_id", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// The image_pushed_at attribute.
    /// </summary>
    public TerraformExpression ImagePushedAt => this["image_pushed_at"];

    /// <summary>
    /// The image_size_in_bytes attribute.
    /// </summary>
    public TerraformExpression ImageSizeInBytes => this["image_size_in_bytes"];

    /// <summary>
    /// The image_tags attribute.
    /// </summary>
    public TerraformExpression ImageTags => this["image_tags"];

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformExpression ImageUri => this["image_uri"];

}
