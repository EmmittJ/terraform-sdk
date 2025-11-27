using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_images Terraform data source.
/// Retrieves information about a aws_ecr_images.
/// </summary>
public partial class AwsEcrImagesDataSource(string name) : TerraformDataSource("aws_ecr_images", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// ID of the registry (AWS account ID)
    /// </summary>
    public TerraformValue<string>? RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
        set => SetArgument("registry_id", value);
    }

    /// <summary>
    /// Name of the repository
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The image_ids attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageIds
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_ids").ResolveNodes(ctx));
    }

}
