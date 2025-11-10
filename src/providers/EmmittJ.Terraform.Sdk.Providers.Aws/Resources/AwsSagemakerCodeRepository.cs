using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for git_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerCodeRepositoryGitConfigBlock : TerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformProperty<string> RepositoryUrl
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_url");
        set => WithProperty("repository_url", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretArn
    {
        get => GetProperty<TerraformProperty<string>>("secret_arn");
        set => WithProperty("secret_arn", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_code_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerCodeRepository : TerraformResource
{
    public AwsSagemakerCodeRepository(string name) : base("aws_sagemaker_code_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The code_repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryName is required")]
    public required TerraformProperty<string> CodeRepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("code_repository_name");
        set => this.WithProperty("code_repository_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for git_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitConfig block(s) allowed")]
    public List<AwsSagemakerCodeRepositoryGitConfigBlock>? GitConfig
    {
        get => GetProperty<List<AwsSagemakerCodeRepositoryGitConfigBlock>>("git_config");
        set => this.WithProperty("git_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
