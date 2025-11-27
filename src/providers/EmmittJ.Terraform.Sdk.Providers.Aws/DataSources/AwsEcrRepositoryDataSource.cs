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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
        set => SetArgument("registry_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageScanningConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_scanning_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformValue<string> ImageTagMutability
    {
        get => new TerraformReference<string>(this, "image_tag_mutability");
    }

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImageTagMutabilityExclusionFilter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_tag_mutability_exclusion_filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The most_recent_image_tags attribute.
    /// </summary>
    public TerraformList<string> MostRecentImageTags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "most_recent_image_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
    }

}
