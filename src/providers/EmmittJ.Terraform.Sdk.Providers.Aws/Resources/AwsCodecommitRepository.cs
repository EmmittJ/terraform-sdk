using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codecommit_repository Terraform resource.
/// Manages a aws_codecommit_repository resource.
/// </summary>
public partial class AwsCodecommitRepository(string name) : TerraformResource("aws_codecommit_repository", name)
{
    /// <summary>
    /// The default_branch attribute.
    /// </summary>
    public TerraformValue<string>? DefaultBranch
    {
        get => new TerraformReference<string>(this, "default_branch");
        set => SetArgument("default_branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The clone_url_http attribute.
    /// </summary>
    public TerraformValue<string> CloneUrlHttp
    {
        get => new TerraformReference<string>(this, "clone_url_http");
    }

    /// <summary>
    /// The clone_url_ssh attribute.
    /// </summary>
    public TerraformValue<string> CloneUrlSsh
    {
        get => new TerraformReference<string>(this, "clone_url_ssh");
    }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    public TerraformValue<string> RepositoryId
    {
        get => new TerraformReference<string>(this, "repository_id");
    }

}
