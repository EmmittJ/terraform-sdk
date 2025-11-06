using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_versions.
/// </summary>
public class GoogleKmsCryptoKeyVersionsDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyVersionsDataSource(string name) : base("google_kms_crypto_key_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("public_key");
        this.DeclareOutput("versions");
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
    /// 
    /// 					The filter argument is used to add a filter query parameter that limits which cryptoKeyVersions are retrieved by the data source: ?filter={{filter}}.
    /// 					Example values:
    /// 					
    /// 					* &amp;quot;name:my-cryptokey-version-&amp;quot; will retrieve cryptoKeyVersions that contain &amp;quot;my-key-&amp;quot; anywhere in their name. Note: names take the form projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}/cryptoKeyVersions/{{cryptoKeyVersion}}.
    /// 					* &amp;quot;name=projects/my-project/locations/global/keyRings/my-key-ring/cryptoKeys/my-key-1/cryptoKeyVersions/1&amp;quot; will only retrieve a key with that exact name.
    /// 					
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/sorting-and-filtering)
    /// 				
    /// </summary>
    public string? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter")?.Value;
        set => this.WithProperty("filter", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// A list of all the retrieved cryptoKeyVersions from the provided crypto key
    /// </summary>
    public TerraformExpression Versions => this["versions"];

}
