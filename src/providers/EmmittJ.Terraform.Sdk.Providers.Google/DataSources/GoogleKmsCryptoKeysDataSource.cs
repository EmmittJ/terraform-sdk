using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_crypto_keys Terraform data source.
/// Retrieves information about a google_kms_crypto_keys.
/// </summary>
public partial class GoogleKmsCryptoKeysDataSource(string name) : TerraformDataSource("google_kms_crypto_keys", name)
{
    /// <summary>
    /// 
    /// 					The filter argument is used to add a filter query parameter that limits which keys are retrieved by the data source: ?filter={{filter}}.
    /// 					Example values:
    /// 					
    /// 					* &amp;quot;name:my-key-&amp;quot; will retrieve keys that contain &amp;quot;my-key-&amp;quot; anywhere in their name. Note: names take the form projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}.
    /// 					* &amp;quot;name=projects/my-project/locations/global/keyRings/my-key-ring/cryptoKeys/my-key-1&amp;quot; will only retrieve a key with that exact name.
    /// 					
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/sorting-and-filtering)
    /// 				
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
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
    /// The key ring that the keys belongs to. Format: &#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    public required TerraformValue<string> KeyRing
    {
        get => GetArgument<TerraformValue<string>>("key_ring");
        set => SetArgument("key_ring", value);
    }

    /// <summary>
    /// A list of all the retrieved keys from the provided key ring
    /// </summary>
    public TerraformList<TerraformMap<object>> KeysAttribute
        => AsReference("keys");

}
