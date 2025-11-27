using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_user_login_profile Terraform resource.
/// Manages a aws_iam_user_login_profile resource.
/// </summary>
public partial class AwsIamUserLoginProfile(string name) : TerraformResource("aws_iam_user_login_profile", name)
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
    /// The password_length attribute.
    /// </summary>
    public TerraformValue<double>? PasswordLength
    {
        get => new TerraformReference<double>(this, "password_length");
        set => SetArgument("password_length", value);
    }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    public TerraformValue<bool> PasswordResetRequired
    {
        get => new TerraformReference<bool>(this, "password_reset_required");
        set => SetArgument("password_reset_required", value);
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
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The encrypted_password attribute.
    /// </summary>
    public TerraformValue<string> EncryptedPassword
    {
        get => new TerraformReference<string>(this, "encrypted_password");
    }

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> KeyFingerprint
    {
        get => new TerraformReference<string>(this, "key_fingerprint");
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
    }

}
