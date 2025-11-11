using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_repository_permissions_policy resource.
/// </summary>
public partial class AwsCodeartifactRepositoryPermissionsPolicy : TerraformResource
{
    public AwsCodeartifactRepositoryPermissionsPolicy(string name) : base("aws_codeartifact_repository_permissions_policy", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    [TerraformProperty("domain_owner")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    [TerraformProperty("policy_document")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyDocument { get; set; }

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    [TerraformProperty("policy_revision")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PolicyRevision { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformProperty("repository")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Repository { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceArn { get; }

}
