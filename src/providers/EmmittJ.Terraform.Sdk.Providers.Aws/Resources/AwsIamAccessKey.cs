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
        SetOutput("create_date");
        SetOutput("encrypted_secret");
        SetOutput("encrypted_ses_smtp_password_v4");
        SetOutput("key_fingerprint");
        SetOutput("secret");
        SetOutput("ses_smtp_password_v4");
        SetOutput("id");
        SetOutput("pgp_key");
        SetOutput("status");
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
    /// The pgp_key attribute.
    /// </summary>
    public TerraformProperty<string> PgpKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pgp_key");
        set => SetProperty("pgp_key", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
