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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformValue<double>? PasswordLength
    {
        get => GetArgument<TerraformValue<double>>("password_length");
        set => SetArgument("password_length", value);
    }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    public TerraformValue<bool>? PasswordResetRequired
    {
        get => GetArgument<TerraformValue<bool>>("password_reset_required");
        set => SetArgument("password_reset_required", value);
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
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => GetArgument<TerraformValue<string>>("user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The encrypted_password attribute.
    /// </summary>
    public TerraformValue<string> EncryptedPassword
        => AsReference("encrypted_password");

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> KeyFingerprint
        => AsReference("key_fingerprint");

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
        => AsReference("password");

}
