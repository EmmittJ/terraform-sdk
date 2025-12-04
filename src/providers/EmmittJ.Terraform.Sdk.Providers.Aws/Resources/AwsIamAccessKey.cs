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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public TerraformValue<string>? PgpKey
    {
        get => GetArgument<TerraformValue<string>>("pgp_key");
        set => SetArgument("pgp_key", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => GetArgument<TerraformValue<string>>("user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => AsReference("create_date");

    /// <summary>
    /// The encrypted_secret attribute.
    /// </summary>
    public TerraformValue<string> EncryptedSecret
        => AsReference("encrypted_secret");

    /// <summary>
    /// The encrypted_ses_smtp_password_v4 attribute.
    /// </summary>
    public TerraformValue<string> EncryptedSesSmtpPasswordV4
        => AsReference("encrypted_ses_smtp_password_v4");

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> KeyFingerprint
        => AsReference("key_fingerprint");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformValue<string> Secret
        => AsReference("secret");

    /// <summary>
    /// The ses_smtp_password_v4 attribute.
    /// </summary>
    public TerraformValue<string> SesSmtpPasswordV4
        => AsReference("ses_smtp_password_v4");

}
