using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_keys.
/// </summary>
public class GoogleKmsCryptoKeysDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeysDataSource(string name) : base("google_kms_crypto_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("keys");
    }

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
    /// The key ring that the keys belongs to. Format: &#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    public required TerraformProperty<string> KeyRing
    {
        get => GetProperty<TerraformProperty<string>>("key_ring");
        set => this.WithProperty("key_ring", value);
    }

    /// <summary>
    /// A list of all the retrieved keys from the provided key ring
    /// </summary>
    public TerraformExpression Keys => this["keys"];

}
