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
        SetOutput("registry_id");
        SetOutput("registry_path");
        SetOutput("dns_suffix");
        SetOutput("id");
        SetOutput("image_tag");
        SetOutput("region");
        SetOutput("repository_name");
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformProperty<string> DnsSuffix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_suffix");
        set => SetProperty("dns_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    public TerraformProperty<string> ImageTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_tag");
        set => SetProperty("image_tag", value);
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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_name");
        set => SetProperty("repository_name", value);
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
