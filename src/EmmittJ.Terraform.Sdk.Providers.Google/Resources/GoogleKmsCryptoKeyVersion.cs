using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_crypto_key_version resource.
/// </summary>
public class GoogleKmsCryptoKeyVersion : TerraformResource
{
    public GoogleKmsCryptoKeyVersion(string name) : base("google_kms_crypto_key_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("algorithm");
        this.DeclareOutput("attestation");
        this.DeclareOutput("generate_time");
        this.DeclareOutput("name");
        this.DeclareOutput("protection_level");
    }

    /// <summary>
    /// The name of the cryptoKey associated with the CryptoKeyVersions.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
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
    /// The current state of the CryptoKeyVersion. Note: you can only specify this field to manually &#39;ENABLE&#39; or &#39;DISABLE&#39; the CryptoKeyVersion,
    /// otherwise the value of this field is always retrieved automatically. Possible values: [&amp;quot;PENDING_GENERATION&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;DESTROYED&amp;quot;, &amp;quot;DESTROY_SCHEDULED&amp;quot;, &amp;quot;PENDING_IMPORT&amp;quot;, &amp;quot;IMPORT_FAILED&amp;quot;]
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.
    /// </summary>
    public TerraformExpression Algorithm => this["algorithm"];

    /// <summary>
    /// Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only provided for key versions with protectionLevel HSM.
    /// </summary>
    public TerraformExpression Attestation => this["attestation"];

    /// <summary>
    /// The time this CryptoKeyVersion key material was generated
    /// </summary>
    public TerraformExpression GenerateTime => this["generate_time"];

    /// <summary>
    /// The resource name for this CryptoKeyVersion.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.
    /// </summary>
    public TerraformExpression ProtectionLevel => this["protection_level"];

}
