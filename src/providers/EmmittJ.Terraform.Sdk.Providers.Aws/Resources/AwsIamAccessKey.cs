using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_access_key resource.
/// </summary>
public partial class AwsIamAccessKey : TerraformResource
{
    public AwsIamAccessKey(string name) : base("aws_iam_access_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    [TerraformProperty("pgp_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PgpKey { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformProperty("user")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> User { get; set; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The encrypted_secret attribute.
    /// </summary>
    [TerraformProperty("encrypted_secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptedSecret { get; }

    /// <summary>
    /// The encrypted_ses_smtp_password_v4 attribute.
    /// </summary>
    [TerraformProperty("encrypted_ses_smtp_password_v4")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptedSesSmtpPasswordV4 { get; }

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    [TerraformProperty("key_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyFingerprint { get; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformProperty("secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Secret { get; }

    /// <summary>
    /// The ses_smtp_password_v4 attribute.
    /// </summary>
    [TerraformProperty("ses_smtp_password_v4")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SesSmtpPasswordV4 { get; }

}
