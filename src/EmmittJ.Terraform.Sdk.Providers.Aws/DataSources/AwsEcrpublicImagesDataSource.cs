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
    public TerraformProperty<string>? RepositoryName
    {
        get => GetProperty<TerraformProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
