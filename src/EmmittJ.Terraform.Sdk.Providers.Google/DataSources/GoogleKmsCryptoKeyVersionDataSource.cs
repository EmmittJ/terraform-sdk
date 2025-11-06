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
        this.DeclareOutput("algorithm");
        this.DeclareOutput("name");
        this.DeclareOutput("protection_level");
        this.DeclareOutput("public_key");
        this.DeclareOutput("state");
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
    /// The version attribute.
    /// </summary>
    public double? Version
    {
        get => GetProperty<TerraformLiteralProperty<double>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
