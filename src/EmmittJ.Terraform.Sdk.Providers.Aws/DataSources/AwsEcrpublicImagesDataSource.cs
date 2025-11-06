using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// AWS account ID associated with the public registry that contains the repository. If not specified, the default public registry is assumed.
    /// </summary>
    public string? RegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_id")?.Value;
        set => this.WithProperty("registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the public repository.
    /// </summary>
    public string? RepositoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_name")?.Value;
        set => this.WithProperty("repository_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
