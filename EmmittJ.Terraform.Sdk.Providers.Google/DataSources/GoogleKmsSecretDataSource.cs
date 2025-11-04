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
    public string? AdditionalAuthenticatedData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_authenticated_data")?.Value;
        set => this.WithProperty("additional_authenticated_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public string? Ciphertext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ciphertext")?.Value;
        set => this.WithProperty("ciphertext", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public TerraformExpression Plaintext => this["plaintext"];

}
