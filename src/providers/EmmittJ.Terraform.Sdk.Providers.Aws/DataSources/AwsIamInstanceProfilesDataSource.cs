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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformPropertyName("role_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleName { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Arns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Names => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "names");

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [TerraformPropertyName("paths")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Paths => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "paths");

}
