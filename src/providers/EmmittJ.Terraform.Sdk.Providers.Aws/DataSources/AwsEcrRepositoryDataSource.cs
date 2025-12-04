using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_repository Terraform data source.
/// Retrieves information about a aws_ecr_repository.
/// </summary>
public partial class AwsEcrRepositoryDataSource(string name) : TerraformDataSource("aws_ecr_repository", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
        => AsReference("encryption_configuration");

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageScanningConfiguration
        => AsReference("image_scanning_configuration");

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformValue<string> ImageTagMutability
        => AsReference("image_tag_mutability");

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageTagMutabilityExclusionFilter
        => AsReference("image_tag_mutability_exclusion_filter");

    /// <summary>
    /// The most_recent_image_tags attribute.
    /// </summary>
    public TerraformList<string> MostRecentImageTags
        => AsReference("most_recent_image_tags");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
        => AsReference("repository_url");

}
