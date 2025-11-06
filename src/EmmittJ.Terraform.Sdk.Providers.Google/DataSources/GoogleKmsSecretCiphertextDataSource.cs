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
    public string? CryptoKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("crypto_key")?.Value;
        set => this.WithProperty("crypto_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The plaintext attribute.
    /// </summary>
    public string? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext")?.Value;
        set => this.WithProperty("plaintext", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
