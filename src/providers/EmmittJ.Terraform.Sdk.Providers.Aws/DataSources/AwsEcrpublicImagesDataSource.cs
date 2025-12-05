using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_ids in AwsEcrpublicImagesDataSource.
/// Nesting mode: list
/// </summary>
public class AwsEcrpublicImagesDataSourceImageIdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_ids";

    /// <summary>
    /// Image digest.
    /// </summary>
    public TerraformValue<string>? ImageDigest
    {
        get => GetArgument<TerraformValue<string>>("image_digest");
        set => SetArgument("image_digest", value);
    }

    /// <summary>
    /// Image tag.
    /// </summary>
    public TerraformValue<string>? ImageTag
    {
        get => GetArgument<TerraformValue<string>>("image_tag");
        set => SetArgument("image_tag", value);
    }

}


/// <summary>
/// Represents a aws_ecrpublic_images Terraform data source.
/// Provides details about AWS ECR Public Images in a public repository.
/// </summary>
public partial class AwsEcrpublicImagesDataSource(string name) : TerraformDataSource("aws_ecrpublic_images", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// AWS account ID associated with the public registry that contains the repository. If not specified, the default public registry is assumed.
    /// </summary>
    public TerraformValue<string>? RegistryId
    {
        get => GetArgument<TerraformValue<string>>("registry_id");
        set => SetArgument("registry_id", value);
    }

    /// <summary>
    /// Name of the public repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Images
        => CreateReference("images");

    /// <summary>
    /// ImageIds block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcrpublicImagesDataSourceImageIdsBlock>? ImageIds
    {
        get => GetArgument<TerraformList<AwsEcrpublicImagesDataSourceImageIdsBlock>>("image_ids");
        set => SetArgument("image_ids", value);
    }

}
