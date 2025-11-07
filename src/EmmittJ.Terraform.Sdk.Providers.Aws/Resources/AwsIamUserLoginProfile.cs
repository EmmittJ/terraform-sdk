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
        this.DeclareOutput("encrypted_password");
        this.DeclareOutput("key_fingerprint");
        this.DeclareOutput("password");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordLength
    {
        get => GetProperty<TerraformProperty<double>>("password_length");
        set => this.WithProperty("password_length", value);
    }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    public TerraformProperty<bool>? PasswordResetRequired
    {
        get => GetProperty<TerraformProperty<bool>>("password_reset_required");
        set => this.WithProperty("password_reset_required", value);
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public TerraformProperty<string>? PgpKey
    {
        get => GetProperty<TerraformProperty<string>>("pgp_key");
        set => this.WithProperty("pgp_key", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformProperty<string>? User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
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
