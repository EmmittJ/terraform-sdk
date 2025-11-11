using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oidc in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksIdentityProviderConfigOidcBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The groups_claim attribute.
    /// </summary>
    [TerraformProperty("groups_claim")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GroupsClaim { get; set; }

    /// <summary>
    /// The groups_prefix attribute.
    /// </summary>
    [TerraformProperty("groups_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GroupsPrefix { get; set; }

    /// <summary>
    /// The identity_provider_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderConfigName is required")]
    [TerraformProperty("identity_provider_config_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityProviderConfigName { get; set; }

    /// <summary>
    /// The issuer_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    [TerraformProperty("issuer_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IssuerUrl { get; set; }

    /// <summary>
    /// The required_claims attribute.
    /// </summary>
    [TerraformProperty("required_claims")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequiredClaims { get; set; }

    /// <summary>
    /// The username_claim attribute.
    /// </summary>
    [TerraformProperty("username_claim")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UsernameClaim { get; set; }

    /// <summary>
    /// The username_prefix attribute.
    /// </summary>
    [TerraformProperty("username_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UsernamePrefix { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEksIdentityProviderConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_eks_identity_provider_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEksIdentityProviderConfig : TerraformResource
{
    public AwsEksIdentityProviderConfig(string name) : base("aws_eks_identity_provider_config", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for oidc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oidc is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Oidc block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oidc block(s) allowed")]
    [TerraformProperty("oidc")]
    public partial TerraformList<TerraformBlock<AwsEksIdentityProviderConfigOidcBlock>>? Oidc { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEksIdentityProviderConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
