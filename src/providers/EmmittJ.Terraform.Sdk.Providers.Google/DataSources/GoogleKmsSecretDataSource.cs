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
        SetOutput("plaintext");
        SetOutput("additional_authenticated_data");
        SetOutput("ciphertext");
        SetOutput("crypto_key");
        SetOutput("id");
    }

    /// <summary>
    /// The additional_authenticated_data attribute.
    /// </summary>
    public TerraformProperty<string> AdditionalAuthenticatedData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("additional_authenticated_data");
        set => SetProperty("additional_authenticated_data", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ciphertext is required")]
    public required TerraformProperty<string> Ciphertext
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ciphertext");
        set => SetProperty("ciphertext", value);
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
    public TerraformExpression Plaintext => this["plaintext"];

}
