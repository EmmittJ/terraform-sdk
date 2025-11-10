using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Get an ephemeral service account public key.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleServiceAccountKeyEphemeralResource : TerraformEphemeralResource
{
    public GoogleServiceAccountKeyEphemeralResource(string name) : base("google_service_account_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key_algorithm");
        this.DeclareOutput("public_key");
    }

    /// <summary>
    /// The name of the service account key. This must have format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{KEYID}`, where `{ACCOUNT}` is the email address or unique id of the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The output format of the public key requested. TYPE_X509_PEM_FILE is the default output format.
    /// </summary>
    public TerraformProperty<string>? PublicKeyType
    {
        get => GetProperty<TerraformProperty<string>>("public_key_type");
        set => this.WithProperty("public_key_type", value);
    }

    /// <summary>
    /// The algorithm used to generate the key.
    /// </summary>
    public TerraformExpression KeyAlgorithm => this["key_algorithm"];

    /// <summary>
    /// The public key, base64 encoded.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

}
