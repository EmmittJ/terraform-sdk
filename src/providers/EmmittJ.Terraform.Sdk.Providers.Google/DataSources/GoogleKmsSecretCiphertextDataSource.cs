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
        SetOutput("ciphertext");
        SetOutput("crypto_key");
        SetOutput("id");
        SetOutput("plaintext");
    }

    /// <summary>
    /// The crypto_key attribute.
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
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformProperty<string> Plaintext
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plaintext");
        set => SetProperty("plaintext", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
