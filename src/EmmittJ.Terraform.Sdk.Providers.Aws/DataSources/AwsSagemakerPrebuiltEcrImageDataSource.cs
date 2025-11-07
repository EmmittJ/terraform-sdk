using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sagemaker_prebuilt_ecr_image.
/// </summary>
public class AwsSagemakerPrebuiltEcrImageDataSource : TerraformDataSource
{
    public AwsSagemakerPrebuiltEcrImageDataSource(string name) : base("aws_sagemaker_prebuilt_ecr_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("registry_id");
        this.DeclareOutput("registry_path");
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? DnsSuffix
    {
        get => GetProperty<TerraformProperty<string>>("dns_suffix");
        set => this.WithProperty("dns_suffix", value);
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
    /// The image_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ImageTag
    {
        get => GetProperty<TerraformProperty<string>>("image_tag");
        set => this.WithProperty("image_tag", value);
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
    /// The repository_name attribute.
    /// </summary>
    public TerraformProperty<string>? RepositoryName
    {
        get => GetProperty<TerraformProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

    /// <summary>
    /// The registry_path attribute.
    /// </summary>
    public TerraformExpression RegistryPath => this["registry_path"];

}
