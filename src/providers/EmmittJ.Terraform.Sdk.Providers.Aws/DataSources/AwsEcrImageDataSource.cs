using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_image Terraform data source.
/// Retrieves information about a aws_ecr_image.
/// </summary>
public partial class AwsEcrImageDataSource(string name) : TerraformDataSource("aws_ecr_image", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    public TerraformValue<string> ImageDigest
    {
        get => GetArgument<TerraformValue<string>>("image_digest") ?? AsReference("image_digest");
        set => SetArgument("image_digest", value);
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
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => GetArgument<TerraformValue<bool>>("most_recent");
        set => SetArgument("most_recent", value);
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
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => GetArgument<TerraformValue<string>>("registry_id") ?? AsReference("registry_id");
        set => SetArgument("registry_id", value);
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
    /// The image_pushed_at attribute.
    /// </summary>
    public TerraformValue<double> ImagePushedAt
        => AsReference("image_pushed_at");

    /// <summary>
    /// The image_size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> ImageSizeInBytes
        => AsReference("image_size_in_bytes");

    /// <summary>
    /// The image_tags attribute.
    /// </summary>
    public TerraformList<string> ImageTags
        => AsReference("image_tags");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    public TerraformValue<string> ImageUri
        => AsReference("image_uri");

}
