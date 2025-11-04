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
        this.DeclareOutput("image_pushed_at");
        this.DeclareOutput("image_size_in_bytes");
        this.DeclareOutput("image_tags");
        this.DeclareOutput("image_uri");
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
    /// The image_digest attribute.
    /// </summary>
    public string? ImageDigest
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_digest")?.Value;
        set => this.WithProperty("image_digest", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    public string? ImageTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_tag")?.Value;
        set => this.WithProperty("image_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent")?.Value;
        set => this.WithProperty("most_recent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public string? RegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_id")?.Value;
        set => this.WithProperty("registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    public string? RepositoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_name")?.Value;
        set => this.WithProperty("repository_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
