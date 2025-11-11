using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_login_profile resource.
/// </summary>
public partial class AwsIamUserLoginProfile : TerraformResource
{
    public AwsIamUserLoginProfile(string name) : base("aws_iam_user_login_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    [TerraformProperty("password_length")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PasswordLength { get; set; }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    [TerraformProperty("password_reset_required")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> PasswordResetRequired { get; set; }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    [TerraformProperty("pgp_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PgpKey { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformProperty("user")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> User { get; set; }

    /// <summary>
    /// The encrypted_password attribute.
    /// </summary>
    [TerraformProperty("encrypted_password")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptedPassword { get; }

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    [TerraformProperty("key_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyFingerprint { get; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Password { get; }

}
