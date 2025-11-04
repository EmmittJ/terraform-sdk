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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public double? PasswordLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_length")?.Value;
        set => this.WithProperty("password_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The password_reset_required attribute.
    /// </summary>
    public bool? PasswordResetRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("password_reset_required")?.Value;
        set => this.WithProperty("password_reset_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public string? PgpKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pgp_key")?.Value;
        set => this.WithProperty("pgp_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public string? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user")?.Value;
        set => this.WithProperty("user", value == null ? null : new TerraformLiteralProperty<string>(value));
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
