using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_instance_profiles.
/// </summary>
public class AwsIamInstanceProfilesDataSource : TerraformDataSource
{
    public AwsIamInstanceProfilesDataSource(string name) : base("aws_iam_instance_profiles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformPropertyName("role_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleName { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Arns => new TerraformReference(this, "arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Names => new TerraformReference(this, "names");

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [TerraformPropertyName("paths")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Paths => new TerraformReference(this, "paths");

}
