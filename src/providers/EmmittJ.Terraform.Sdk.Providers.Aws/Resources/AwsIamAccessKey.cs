using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_access_key Terraform resource.
/// Manages a aws_iam_access_key resource.
/// </summary>
public partial class AwsIamAccessKey(string name) : TerraformResource("aws_iam_access_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public TerraformValue<string>? PgpKey
    {
        get => new TerraformReference<string>(this, "pgp_key");
        set => SetArgument("pgp_key", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
    {
        get => new TerraformReference<string>(this, "create_date");
    }

    /// <summary>
    /// The encrypted_secret attribute.
    /// </summary>
    public TerraformValue<string> EncryptedSecret
    {
        get => new TerraformReference<string>(this, "encrypted_secret");
    }

    /// <summary>
    /// The encrypted_ses_smtp_password_v4 attribute.
    /// </summary>
    public TerraformValue<string> EncryptedSesSmtpPasswordV4
    {
        get => new TerraformReference<string>(this, "encrypted_ses_smtp_password_v4");
    }

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> KeyFingerprint
    {
        get => new TerraformReference<string>(this, "key_fingerprint");
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformValue<string> Secret
    {
        get => new TerraformReference<string>(this, "secret");
    }

    /// <summary>
    /// The ses_smtp_password_v4 attribute.
    /// </summary>
    public TerraformValue<string> SesSmtpPasswordV4
    {
        get => new TerraformReference<string>(this, "ses_smtp_password_v4");
    }

}
