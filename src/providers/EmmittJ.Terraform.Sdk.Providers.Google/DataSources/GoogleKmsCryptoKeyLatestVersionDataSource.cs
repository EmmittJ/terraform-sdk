using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_latest_version.
/// </summary>
public class GoogleKmsCryptoKeyLatestVersionDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyLatestVersionDataSource(string name) : base("google_kms_crypto_key_latest_version", name)
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
        SetOutput("version");
        SetOutput("crypto_key");
        SetOutput("filter");
        SetOutput("id");
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
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
