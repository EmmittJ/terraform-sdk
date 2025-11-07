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
    public TerraformLiteralProperty<string>? AdditionalAuthenticatedData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_authenticated_data");
        set => this.WithProperty("additional_authenticated_data", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ciphertext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ciphertext");
        set => this.WithProperty("ciphertext", value);
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
    public TerraformExpression Plaintext => this["plaintext"];

}
