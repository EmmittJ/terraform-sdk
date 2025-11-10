using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_login_profile resource.
/// </summary>
public class AwsIamUserLoginProfile : TerraformResource
{
    public AwsIamUserLoginProfile(string name) : base("aws_iam_user_login_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    [TerraformPropertyName("password_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PasswordLength { get; set; }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    [TerraformPropertyName("password_reset_required")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PasswordResetRequired { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "password_reset_required");

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    [TerraformPropertyName("pgp_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PgpKey { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformPropertyName("user")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> User { get; set; }

    /// <summary>
    /// The encrypted_password attribute.
    /// </summary>
    [TerraformPropertyName("encrypted_password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptedPassword => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encrypted_password");

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("key_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_fingerprint");

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Password => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "password");

}
