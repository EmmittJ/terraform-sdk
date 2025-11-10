using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_version.
/// </summary>
public class GoogleKmsCryptoKeyVersionDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyVersionDataSource(string name) : base("google_kms_crypto_key_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("algorithm");
        SetOutput("name");
        SetOutput("protection_level");
        SetOutput("public_key");
        SetOutput("state");
        SetOutput("crypto_key");
        SetOutput("id");
        SetOutput("version");
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<double> Version
    {
        get => GetRequiredOutput<TerraformProperty<double>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    public TerraformExpression Algorithm => this["algorithm"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The protection_level attribute.
    /// </summary>
    public TerraformExpression ProtectionLevel => this["protection_level"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
