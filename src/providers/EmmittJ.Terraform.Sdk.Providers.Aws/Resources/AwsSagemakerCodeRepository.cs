using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for git_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerCodeRepositoryGitConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformProperty("branch")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformProperty("repository_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryUrl { get; set; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretArn { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_code_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerCodeRepository : TerraformResource
{
    public AwsSagemakerCodeRepository(string name) : base("aws_sagemaker_code_repository", name)
    {
    }

    /// <summary>
    /// The code_repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryName is required")]
    [TerraformProperty("code_repository_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CodeRepositoryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for git_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitConfig block(s) allowed")]
    [TerraformProperty("git_config")]
    public TerraformList<TerraformBlock<AwsSagemakerCodeRepositoryGitConfigBlock>>? GitConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
