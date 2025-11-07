using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_images.
/// </summary>
public class AwsEcrImagesDataSource : TerraformDataSource
{
    public AwsEcrImagesDataSource(string name) : base("aws_ecr_images", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("image_ids");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// ID of the registry (AWS account ID)
    /// </summary>
    public TerraformLiteralProperty<string>? RegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_id");
        set => this.WithProperty("registry_id", value);
    }

    /// <summary>
    /// Name of the repository
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// The image_ids attribute.
    /// </summary>
    public TerraformExpression ImageIds => this["image_ids"];

}
