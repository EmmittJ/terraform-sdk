using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleKmsSecretCiphertext.
/// Nesting mode: single
/// </summary>
public class GoogleKmsSecretCiphertextTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_kms_secret_ciphertext Terraform resource.
/// Manages a google_kms_secret_ciphertext resource.
/// </summary>
public partial class GoogleKmsSecretCiphertext(string name) : TerraformResource("google_kms_secret_ciphertext", name)
{
    /// <summary>
    /// The additional authenticated data used for integrity checks during encryption and decryption.
    /// </summary>
    public TerraformValue<string>? AdditionalAuthenticatedData
    {
        get => GetArgument<TerraformValue<string>>("additional_authenticated_data");
        set => SetArgument("additional_authenticated_data", value);
    }

    /// <summary>
    /// The full name of the CryptoKey that will be used to encrypt the provided plaintext.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformValue<string> CryptoKey
    {
        get => GetArgument<TerraformValue<string>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The plaintext to be encrypted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformValue<string> Plaintext
    {
        get => GetArgument<TerraformValue<string>>("plaintext");
        set => SetArgument("plaintext", value);
    }

    /// <summary>
    /// Contains the result of encrypting the provided plaintext, encoded in base64.
    /// </summary>
    public TerraformValue<string> Ciphertext
        => AsReference("ciphertext");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleKmsSecretCiphertextTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleKmsSecretCiphertextTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
