using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_secret.
/// </summary>
public class GoogleKmsSecretDataSource : TerraformDataSource
{
    public GoogleKmsSecretDataSource(string name) : base("google_kms_secret", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("plaintext");
    }

    /// <summary>
    /// The additional_authenticated_data attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalAuthenticatedData
    {
        get => GetProperty<TerraformProperty<string>>("additional_authenticated_data");
        set => this.WithProperty("additional_authenticated_data", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ciphertext is required")]
    public required TerraformProperty<string> Ciphertext
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ciphertext");
        set => this.WithProperty("ciphertext", value);
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
    public TerraformExpression Plaintext => this["plaintext"];

}
