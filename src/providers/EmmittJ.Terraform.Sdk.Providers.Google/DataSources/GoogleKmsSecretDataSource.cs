using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_secret Terraform data source.
/// Retrieves information about a google_kms_secret.
/// </summary>
public partial class GoogleKmsSecretDataSource(string name) : TerraformDataSource("google_kms_secret", name)
{
    /// <summary>
    /// The additional_authenticated_data attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalAuthenticatedData
    {
        get => GetArgument<TerraformValue<string>>("additional_authenticated_data");
        set => SetArgument("additional_authenticated_data", value);
    }

    /// <summary>
    /// The ciphertext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ciphertext is required")]
    public required TerraformValue<string> Ciphertext
    {
        get => GetRequiredArgument<TerraformValue<string>>("ciphertext");
        set => SetArgument("ciphertext", value);
    }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformValue<string> CryptoKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformValue<string> Plaintext
        => AsReference("plaintext");

}
