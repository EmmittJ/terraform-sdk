using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_grant resource.
/// </summary>
public class AwsLicensemanagerGrant : TerraformResource
{
    public AwsLicensemanagerGrant(string name) : base("aws_licensemanager_grant", name)
    {
    }

    /// <summary>
    /// Allowed operations for the grant. This is a subset of the allowed operations on the license.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOperations is required")]
    [TerraformPropertyName("allowed_operations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AllowedOperations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// License ARN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    [TerraformPropertyName("license_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LicenseArn { get; set; }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The grantee principal ARN. The target account for the grant in the form of the ARN for an account principal of the root user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    [TerraformPropertyName("home_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomeRegion => new TerraformReference(this, "home_region");

    /// <summary>
    /// Parent ARN.
    /// </summary>
    [TerraformPropertyName("parent_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentArn => new TerraformReference(this, "parent_arn");

    /// <summary>
    /// Grant status.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Grant version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
