using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_access_key resource.
/// </summary>
public class AwsIamAccessKey : TerraformResource
{
    public AwsIamAccessKey(string name) : base("aws_iam_access_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_date");
        this.DeclareOutput("encrypted_secret");
        this.DeclareOutput("encrypted_ses_smtp_password_v4");
        this.DeclareOutput("key_fingerprint");
        this.DeclareOutput("secret");
        this.DeclareOutput("ses_smtp_password_v4");
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
    /// The pgp_key attribute.
    /// </summary>
    public string? PgpKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pgp_key")?.Value;
        set => this.WithProperty("pgp_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The encrypted_secret attribute.
    /// </summary>
    public TerraformExpression EncryptedSecret => this["encrypted_secret"];

    /// <summary>
    /// The encrypted_ses_smtp_password_v4 attribute.
    /// </summary>
    public TerraformExpression EncryptedSesSmtpPasswordV4 => this["encrypted_ses_smtp_password_v4"];

    /// <summary>
    /// The key_fingerprint attribute.
    /// </summary>
    public TerraformExpression KeyFingerprint => this["key_fingerprint"];

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

    /// <summary>
    /// The ses_smtp_password_v4 attribute.
    /// </summary>
    public TerraformExpression SesSmtpPasswordV4 => this["ses_smtp_password_v4"];

}
