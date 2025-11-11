using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_repository resource.
/// </summary>
public class AwsCodecommitRepository : TerraformResource
{
    public AwsCodecommitRepository(string name) : base("aws_codecommit_repository", name)
    {
    }

    /// <summary>
    /// The default_branch attribute.
    /// </summary>
    [TerraformPropertyName("default_branch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultBranch { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The clone_url_http attribute.
    /// </summary>
    [TerraformPropertyName("clone_url_http")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloneUrlHttp => new TerraformReference(this, "clone_url_http");

    /// <summary>
    /// The clone_url_ssh attribute.
    /// </summary>
    [TerraformPropertyName("clone_url_ssh")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloneUrlSsh => new TerraformReference(this, "clone_url_ssh");

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [TerraformPropertyName("repository_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RepositoryId => new TerraformReference(this, "repository_id");

}
