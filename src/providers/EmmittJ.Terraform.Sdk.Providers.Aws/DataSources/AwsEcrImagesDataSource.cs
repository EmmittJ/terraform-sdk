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
        SetOutput("image_ids");
        SetOutput("region");
        SetOutput("registry_id");
        SetOutput("repository_name");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// ID of the registry (AWS account ID)
    /// </summary>
    public TerraformProperty<string> RegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("registry_id");
        set => SetProperty("registry_id", value);
    }

    /// <summary>
    /// Name of the repository
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_name");
        set => SetProperty("repository_name", value);
    }

    /// <summary>
    /// The image_ids attribute.
    /// </summary>
    public TerraformExpression ImageIds => this["image_ids"];

}
