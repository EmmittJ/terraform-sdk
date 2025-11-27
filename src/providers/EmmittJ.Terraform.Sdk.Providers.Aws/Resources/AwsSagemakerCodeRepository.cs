using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for git_config in AwsSagemakerCodeRepository.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerCodeRepositoryGitConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_config";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_code_repository Terraform resource.
/// Manages a aws_sagemaker_code_repository resource.
/// </summary>
public partial class AwsSagemakerCodeRepository(string name) : TerraformResource("aws_sagemaker_code_repository", name)
{
    /// <summary>
    /// The code_repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryName is required")]
    public required TerraformValue<string> CodeRepositoryName
    {
        get => new TerraformReference<string>(this, "code_repository_name");
        set => SetArgument("code_repository_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// GitConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerCodeRepositoryGitConfigBlock> GitConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerCodeRepositoryGitConfigBlock>>("git_config");
        set => SetArgument("git_config", value);
    }

}
