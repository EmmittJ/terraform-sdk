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
        this.WithOutput("public_key");
        this.WithOutput("versions");
    }

    /// <summary>
    /// The crypto_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    public required TerraformProperty<string> CryptoKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("crypto_key");
        set => this.WithProperty("crypto_key", value);
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
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
