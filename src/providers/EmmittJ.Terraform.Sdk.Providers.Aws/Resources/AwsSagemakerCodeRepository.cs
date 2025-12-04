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
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => GetArgument<TerraformValue<string>>("secret_arn");
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
        get => GetArgument<TerraformValue<string>>("code_repository_name");
        set => SetArgument("code_repository_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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
