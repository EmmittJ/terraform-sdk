using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_ids in .
/// Nesting mode: list
/// </summary>
public class AwsEcrpublicImagesDataSourceImageIdsBlock : TerraformBlock
{
    /// <summary>
    /// Image digest.
    /// </summary>
    public TerraformProperty<string>? ImageDigest
    {
        get => GetProperty<TerraformProperty<string>>("image_digest");
        set => WithProperty("image_digest", value);
    }

    /// <summary>
    /// Image tag.
    /// </summary>
    public TerraformProperty<string>? ImageTag
    {
        get => GetProperty<TerraformProperty<string>>("image_tag");
        set => WithProperty("image_tag", value);
    }

}

/// <summary>
/// Provides details about AWS ECR Public Images in a public repository.
/// </summary>
public class AwsEcrpublicImagesDataSource : TerraformDataSource
{
    public AwsEcrpublicImagesDataSource(string name) : base("aws_ecrpublic_images", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("images");
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
    /// AWS account ID associated with the public registry that contains the repository. If not specified, the default public registry is assumed.
    /// </summary>
    public TerraformProperty<string>? RegistryId
    {
        get => GetProperty<TerraformProperty<string>>("registry_id");
        set => this.WithProperty("registry_id", value);
    }

    /// <summary>
    /// Name of the public repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetProperty<TerraformProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// Block for image_ids.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEcrpublicImagesDataSourceImageIdsBlock>? ImageIds
    {
        get => GetProperty<List<AwsEcrpublicImagesDataSourceImageIdsBlock>>("image_ids");
        set => this.WithProperty("image_ids", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
