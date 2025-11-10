using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_key resource.
/// </summary>
public class GoogleServiceAccountKey : TerraformResource
{
    public GoogleServiceAccountKey(string name) : base("google_service_account_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("private_key");
        this.WithOutput("public_key");
        this.WithOutput("valid_after");
        this.WithOutput("valid_before");
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
    /// Arbitrary map of values that, when changed, will trigger recreation of resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Keepers
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("keepers");
        set => this.WithProperty("keepers", value);
    }

    /// <summary>
    /// The algorithm used to generate the key, used only on create. KEY_ALG_RSA_2048 is the default algorithm. Valid values are: &amp;quot;KEY_ALG_RSA_1024&amp;quot;, &amp;quot;KEY_ALG_RSA_2048&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? KeyAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("key_algorithm");
        set => this.WithProperty("key_algorithm", value);
    }

    /// <summary>
    /// The private_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKeyType
    {
        get => GetProperty<TerraformProperty<string>>("private_key_type");
        set => this.WithProperty("private_key_type", value);
    }

    /// <summary>
    /// A field that allows clients to upload their own public key. If set, use this public key data to create a service account key for given service account. Please note, the expected format for this field is a base64 encoded X509_PEM.
    /// </summary>
    public TerraformProperty<string>? PublicKeyData
    {
        get => GetProperty<TerraformProperty<string>>("public_key_data");
        set => this.WithProperty("public_key_data", value);
    }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? PublicKeyType
    {
        get => GetProperty<TerraformProperty<string>>("public_key_type");
        set => this.WithProperty("public_key_type", value);
    }

    /// <summary>
    /// The ID of the parent service account of the key. This can be a string in the format {ACCOUNT} or projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}, where {ACCOUNT} is the email address or unique id of the service account. If the {ACCOUNT} syntax is used, the project will be inferred from the provider&#39;s configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    public required TerraformProperty<string> ServiceAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_account_id");
        set => this.WithProperty("service_account_id", value);
    }

    /// <summary>
    /// The name used for this key pair
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The private key in JSON format, base64 encoded. This is what you normally get as a file when creating service account keys through the CLI or web console. This is only populated when creating a new key.
    /// </summary>
    public TerraformExpression PrivateKey => this["private_key"];

    /// <summary>
    /// The public key, base64 encoded
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The key can be used after this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression ValidAfter => this["valid_after"];

    /// <summary>
    /// The key can be used before this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression ValidBefore => this["valid_before"];

}
