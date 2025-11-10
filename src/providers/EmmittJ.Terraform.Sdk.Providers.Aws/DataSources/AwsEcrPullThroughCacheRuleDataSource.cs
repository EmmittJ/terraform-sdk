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
    public required TerraformProperty<TerraformProperty<string>> EcrRepositoryPrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The credential_arn attribute.
    /// </summary>
    [TerraformPropertyName("credential_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CredentialArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "credential_arn");

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_role_arn");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_id");

    /// <summary>
    /// The upstream_registry_url attribute.
    /// </summary>
    [TerraformPropertyName("upstream_registry_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpstreamRegistryUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "upstream_registry_url");

    /// <summary>
    /// The upstream_repository_prefix attribute.
    /// </summary>
    [TerraformPropertyName("upstream_repository_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpstreamRepositoryPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "upstream_repository_prefix");

}
