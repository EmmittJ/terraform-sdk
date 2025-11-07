using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_secret_ciphertext.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class GoogleKmsSecretCiphertextDataSource : TerraformDataSource
{
    public GoogleKmsSecretCiphertextDataSource(string name) : base("google_kms_secret_ciphertext", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ciphertext");
    }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CryptoKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("crypto_key");
        set => this.WithProperty("crypto_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext");
        set => this.WithProperty("plaintext", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
