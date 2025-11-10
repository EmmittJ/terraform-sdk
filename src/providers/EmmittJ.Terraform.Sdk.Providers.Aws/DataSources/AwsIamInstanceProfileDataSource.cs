using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_instance_profile.
/// </summary>
public class AwsIamInstanceProfileDataSource : TerraformDataSource
{
    public AwsIamInstanceProfileDataSource(string name) : base("aws_iam_instance_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_date");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    [TerraformPropertyName("role_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_name");

}
