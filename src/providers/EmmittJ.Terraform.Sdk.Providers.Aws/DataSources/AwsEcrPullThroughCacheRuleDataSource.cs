using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_pull_through_cache_rule.
/// </summary>
public class AwsEcrPullThroughCacheRuleDataSource : TerraformDataSource
{
    public AwsEcrPullThroughCacheRuleDataSource(string name) : base("aws_ecr_pull_through_cache_rule", name)
    {
    }

    /// <summary>
    /// The ecr_repository_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EcrRepositoryPrefix is required")]
    [TerraformPropertyName("ecr_repository_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EcrRepositoryPrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The credential_arn attribute.
    /// </summary>
    [TerraformPropertyName("credential_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CredentialArn => new TerraformReference(this, "credential_arn");

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomRoleArn => new TerraformReference(this, "custom_role_arn");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegistryId => new TerraformReference(this, "registry_id");

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    [TerraformPropertyName("upstream_registry_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpstreamRegistryUrl => new TerraformReference(this, "upstream_registry_url");

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    [TerraformPropertyName("upstream_repository_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpstreamRepositoryPrefix => new TerraformReference(this, "upstream_repository_prefix");

}
