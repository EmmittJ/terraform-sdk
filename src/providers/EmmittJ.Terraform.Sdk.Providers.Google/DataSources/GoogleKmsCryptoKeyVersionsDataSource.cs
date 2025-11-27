using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_crypto_key_versions Terraform data source.
/// Retrieves information about a google_kms_crypto_key_versions.
/// </summary>
public partial class GoogleKmsCryptoKeyVersionsDataSource(string name) : TerraformDataSource("google_kms_crypto_key_versions", name)
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
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
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
    /// The public_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicKey
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "public_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of all the retrieved cryptoKeyVersions from the provided crypto key
    /// </summary>
    public TerraformList<TerraformMap<object>> Versions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "versions").ResolveNodes(ctx));
    }

}
