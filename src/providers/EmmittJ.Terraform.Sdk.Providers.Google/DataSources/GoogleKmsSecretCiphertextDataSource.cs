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
        this.WithOutput("ciphertext");
    }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformProperty<string> CryptoKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("crypto_key");
        set => this.WithProperty("crypto_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformProperty<string> Plaintext
    {
        get => GetRequiredProperty<TerraformProperty<string>>("plaintext");
        set => this.WithProperty("plaintext", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public TerraformExpression Ciphertext => this["ciphertext"];

}
