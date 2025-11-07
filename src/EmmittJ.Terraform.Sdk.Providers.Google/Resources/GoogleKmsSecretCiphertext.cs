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
    public TerraformLiteralProperty<string>? AdditionalAuthenticatedData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_authenticated_data");
        set => this.WithProperty("additional_authenticated_data", value);
    }

    /// <summary>
    /// The full name of the CryptoKey that will be used to encrypt the provided plaintext.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
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
    /// The plaintext to be encrypted.
    /// </summary>
    public TerraformLiteralProperty<string>? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext");
        set => this.WithProperty("plaintext", value);
    }

    /// <summary>
    /// Contains the result of encrypting the provided plaintext, encoded in base64.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
