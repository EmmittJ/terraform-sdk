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
    public string? DnsSuffix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_suffix")?.Value;
        set => this.WithProperty("dns_suffix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The image_tag attribute.
    /// </summary>
    public string? ImageTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_tag")?.Value;
        set => this.WithProperty("image_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The repository_name attribute.
    /// </summary>
    public string? RepositoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_name")?.Value;
        set => this.WithProperty("repository_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
