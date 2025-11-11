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
    public required TerraformValue<string> GrantArn { get; set; }

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
    /// Allowed operations for the grant.
    /// </summary>
    [TerraformPropertyName("allowed_operations")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AllowedOperations => new TerraformReference(this, "allowed_operations");

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    [TerraformPropertyName("home_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomeRegion => new TerraformReference(this, "home_region");

    /// <summary>
    /// License ARN.
    /// </summary>
    [TerraformPropertyName("license_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseArn => new TerraformReference(this, "license_arn");

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Parent ARN.
    /// </summary>
    [TerraformPropertyName("parent_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentArn => new TerraformReference(this, "parent_arn");

    /// <summary>
    /// The grantee principal ARN.
    /// </summary>
    [TerraformPropertyName("principal")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Principal => new TerraformReference(this, "principal");

    /// <summary>
    /// GrantAccepter status.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// GrantAccepter version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
