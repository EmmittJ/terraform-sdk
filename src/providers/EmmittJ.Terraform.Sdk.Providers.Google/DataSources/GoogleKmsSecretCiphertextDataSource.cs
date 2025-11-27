using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_secret_ciphertext Terraform data source.
/// Retrieves information about a google_kms_secret_ciphertext.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleKmsSecretCiphertextDataSource(string name) : TerraformDataSource("google_kms_secret_ciphertext", name)
{
    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformValue<string> CryptoKey
    {
        get => new TerraformReference<string>(this, "crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformValue<string> Plaintext
    {
        get => new TerraformReference<string>(this, "plaintext");
        set => SetArgument("plaintext", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    public TerraformValue<string> Ciphertext
    {
        get => new TerraformReference<string>(this, "ciphertext");
    }

}
