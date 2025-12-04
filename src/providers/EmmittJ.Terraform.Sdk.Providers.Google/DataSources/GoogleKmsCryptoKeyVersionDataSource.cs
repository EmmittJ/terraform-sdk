using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_crypto_key_version Terraform data source.
/// Retrieves information about a google_kms_crypto_key_version.
/// </summary>
public partial class GoogleKmsCryptoKeyVersionDataSource(string name) : TerraformDataSource("google_kms_crypto_key_version", name)
{
    /// <summary>
    /// The crypto_key attribute.
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
    /// The version attribute.
    /// </summary>
    public TerraformValue<double>? Version
    {
        get => GetArgument<TerraformValue<double>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    public TerraformValue<string> Algorithm
        => AsReference("algorithm");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The protection_level attribute.
    /// </summary>
    public TerraformValue<string> ProtectionLevel
        => AsReference("protection_level");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicKey
        => AsReference("public_key");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

}
