using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_crypto_key_latest_version Terraform data source.
/// Retrieves information about a google_kms_crypto_key_latest_version.
/// </summary>
public partial class GoogleKmsCryptoKeyLatestVersionDataSource(string name) : TerraformDataSource("google_kms_crypto_key_latest_version", name)
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
    /// 					The filter argument is used to add a filter query parameter that limits which type of cryptoKeyVersion is retrieved as the latest by the data source: ?filter={{filter}}. When no value is provided there is no filtering.
    /// 
    /// 					Example filter values if filtering on state.
    /// 
    /// 					* &amp;quot;state:ENABLED&amp;quot; will retrieve the latest cryptoKeyVersion that has the state &amp;quot;ENABLED&amp;quot;.
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
    /// The algorithm attribute.
    /// </summary>
    public TerraformValue<string> Algorithm
    {
        get => new TerraformReference<string>(this, "algorithm");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The protection_level attribute.
    /// </summary>
    public TerraformValue<string> ProtectionLevel
    {
        get => new TerraformReference<string>(this, "protection_level");
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicKey
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "public_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

}
