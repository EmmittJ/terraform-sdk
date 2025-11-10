using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsSecretCiphertextTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

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
        SetOutput("ciphertext");
        SetOutput("additional_authenticated_data");
        SetOutput("crypto_key");
        SetOutput("id");
        SetOutput("plaintext");
    }

    /// <summary>
    /// The additional authenticated data used for integrity checks during encryption and decryption.
    /// </summary>
    public TerraformProperty<string> AdditionalAuthenticatedData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("additional_authenticated_data");
        set => SetProperty("additional_authenticated_data", value);
    }

    /// <summary>
    /// The full name of the CryptoKey that will be used to encrypt the provided plaintext.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformProperty<string> CryptoKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("crypto_key");
        set => SetProperty("crypto_key", value);
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
    /// The plaintext to be encrypted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformProperty<string> Plaintext
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plaintext");
        set => SetProperty("plaintext", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleKmsSecretCiphertextTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Contains the result of encrypting the provided plaintext, encoded in base64.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
