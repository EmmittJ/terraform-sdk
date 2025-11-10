using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_login_profile resource.
/// </summary>
public class AwsIamUserLoginProfile : TerraformResource
{
    public AwsIamUserLoginProfile(string name) : base("aws_iam_user_login_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("encrypted_password");
        SetOutput("key_fingerprint");
        SetOutput("password");
        SetOutput("id");
        SetOutput("password_length");
        SetOutput("password_reset_required");
        SetOutput("pgp_key");
        SetOutput("user");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformProperty<double> PasswordLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("password_length");
        set => SetProperty("password_length", value);
    }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    public TerraformProperty<bool> PasswordResetRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("password_reset_required");
        set => SetProperty("password_reset_required", value);
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public TerraformProperty<string> PgpKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pgp_key");
        set => SetProperty("pgp_key", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformProperty<string> User
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user");
        set => SetProperty("user", value);
    }

    /// <summary>
    /// The encrypted_password attribute.
    /// </summary>
    public TerraformExpression EncryptedPassword => this["encrypted_password"];

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    public TerraformExpression KeyFingerprint => this["key_fingerprint"];

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformExpression Password => this["password"];

}
