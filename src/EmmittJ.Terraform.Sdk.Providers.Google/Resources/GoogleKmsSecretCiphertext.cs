using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_secret_ciphertext resource.
/// </summary>
public class GoogleKmsSecretCiphertext : TerraformResource
{
    public GoogleKmsSecretCiphertext(string name) : base("google_kms_secret_ciphertext", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ciphertext");
    }

    /// <summary>
    /// The additional authenticated data used for integrity checks during encryption and decryption.
    /// </summary>
    public string? AdditionalAuthenticatedData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_authenticated_data")?.Value;
        set => this.WithProperty("additional_authenticated_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The full name of the CryptoKey that will be used to encrypt the provided plaintext.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
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
    /// The plaintext to be encrypted.
    /// </summary>
    public string? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext")?.Value;
        set => this.WithProperty("plaintext", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Contains the result of encrypting the provided plaintext, encoded in base64.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
