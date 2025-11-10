using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_access_key resource.
/// </summary>
public class AwsIamAccessKey : TerraformResource
{
    public AwsIamAccessKey(string name) : base("aws_iam_access_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    [TerraformPropertyName("pgp_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PgpKey { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformPropertyName("user")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> User { get; set; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_date");

    /// <summary>
    /// The encrypted_secret attribute.
    /// </summary>
    [TerraformPropertyName("encrypted_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptedSecret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encrypted_secret");

    /// <summary>
    /// The encrypted_ses_smtp_password_v4 attribute.
    /// </summary>
    [TerraformPropertyName("encrypted_ses_smtp_password_v4")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptedSesSmtpPasswordV4 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encrypted_ses_smtp_password_v4");

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("key_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_fingerprint");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Secret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret");

    /// <summary>
    /// The ses_smtp_password_v4 attribute.
    /// </summary>
    [TerraformPropertyName("ses_smtp_password_v4")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SesSmtpPasswordV4 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ses_smtp_password_v4");

}
