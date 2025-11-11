using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_pull_through_cache_rule.
/// </summary>
public partial class AwsEcrPullThroughCacheRuleDataSource : TerraformDataSource
{
    public AwsEcrPullThroughCacheRuleDataSource(string name) : base("aws_ecr_pull_through_cache_rule", name)
    {
    }

    /// <summary>
    /// The ecr_repository_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EcrRepositoryPrefix is required")]
    [TerraformProperty("ecr_repository_prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EcrRepositoryPrefix { get; set; }

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
    /// The credential_arn attribute.
    /// </summary>
    [TerraformProperty("credential_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CredentialArn { get; }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformProperty("custom_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomRoleArn { get; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegistryId { get; }

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    [TerraformProperty("upstream_registry_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpstreamRegistryUrl { get; }

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    [TerraformProperty("upstream_repository_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpstreamRepositoryPrefix { get; }

}
