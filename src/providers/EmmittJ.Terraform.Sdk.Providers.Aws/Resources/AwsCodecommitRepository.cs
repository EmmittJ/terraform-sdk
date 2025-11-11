using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_repository resource.
/// </summary>
public partial class AwsCodecommitRepository : TerraformResource
{
    public AwsCodecommitRepository(string name) : base("aws_codecommit_repository", name)
    {
    }

    /// <summary>
    /// The default_branch attribute.
    /// </summary>
    [TerraformProperty("default_branch")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultBranch { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryName { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The clone_url_http attribute.
    /// </summary>
    [TerraformProperty("clone_url_http")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloneUrlHttp { get; }

    /// <summary>
    /// The clone_url_ssh attribute.
    /// </summary>
    [TerraformProperty("clone_url_ssh")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloneUrlSsh { get; }

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [TerraformProperty("repository_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RepositoryId { get; }

}
