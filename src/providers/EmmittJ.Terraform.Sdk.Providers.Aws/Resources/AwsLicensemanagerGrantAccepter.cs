using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_grant_accepter resource.
/// </summary>
public class AwsLicensemanagerGrantAccepter : TerraformResource
{
    public AwsLicensemanagerGrantAccepter(string name) : base("aws_licensemanager_grant_accepter", name)
    {
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantArn is required")]
    [TerraformPropertyName("grant_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GrantArn { get; set; }

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
    /// Allowed operations for the grant.
    /// </summary>
    [TerraformPropertyName("allowed_operations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedOperations => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_operations");

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    [TerraformPropertyName("home_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HomeRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "home_region");

    /// <summary>
    /// License ARN.
    /// </summary>
    [TerraformPropertyName("license_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_arn");

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Parent ARN.
    /// </summary>
    [TerraformPropertyName("parent_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_arn");

    /// <summary>
    /// The grantee principal ARN.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Principal => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal");

    /// <summary>
    /// GrantAccepter status.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// GrantAccepter version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
