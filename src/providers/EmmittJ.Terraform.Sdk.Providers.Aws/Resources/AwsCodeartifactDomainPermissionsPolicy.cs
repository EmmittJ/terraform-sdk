using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_domain_permissions_policy resource.
/// </summary>
public class AwsCodeartifactDomainPermissionsPolicy : TerraformResource
{
    public AwsCodeartifactDomainPermissionsPolicy(string name) : base("aws_codeartifact_domain_permissions_policy", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    [TerraformPropertyName("domain_owner")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainOwner { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_owner");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformPropertyName("policy_document")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PolicyDocument { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_document");

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    [TerraformPropertyName("policy_revision")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PolicyRevision { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_revision");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_arn");

}
