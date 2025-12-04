using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_prebuilt_ecr_image Terraform data source.
/// Retrieves information about a aws_sagemaker_prebuilt_ecr_image.
/// </summary>
public partial class AwsSagemakerPrebuiltEcrImageDataSource(string name) : TerraformDataSource("aws_sagemaker_prebuilt_ecr_image", name)
{
    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string>? DnsSuffix
    {
        get => GetArgument<TerraformValue<string>>("dns_suffix");
        set => SetArgument("dns_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    public TerraformValue<string>? ImageTag
    {
        get => GetArgument<TerraformValue<string>>("image_tag");
        set => SetArgument("image_tag", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
        => AsReference("registry_id");

    /// <summary>
    /// The registry_path attribute.
    /// </summary>
    public TerraformValue<string> RegistryPath
        => AsReference("registry_path");

}
