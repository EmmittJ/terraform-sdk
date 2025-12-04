using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_account_key Terraform resource.
/// Manages a google_service_account_key resource.
/// </summary>
public partial class GoogleServiceAccountKey(string name) : TerraformResource("google_service_account_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Arbitrary map of values that, when changed, will trigger recreation of resource.
    /// </summary>
    public TerraformMap<string>? Keepers
    {
        get => GetArgument<TerraformMap<string>>("keepers");
        set => SetArgument("keepers", value);
    }

    /// <summary>
    /// The algorithm used to generate the key, used only on create. KEY_ALG_RSA_2048 is the default algorithm. Valid values are: &amp;quot;KEY_ALG_RSA_1024&amp;quot;, &amp;quot;KEY_ALG_RSA_2048&amp;quot;.
    /// </summary>
    public TerraformValue<string>? KeyAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// The private_key_type attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKeyType
    {
        get => GetArgument<TerraformValue<string>>("private_key_type");
        set => SetArgument("private_key_type", value);
    }

    /// <summary>
    /// A field that allows clients to upload their own public key. If set, use this public key data to create a service account key for given service account. Please note, the expected format for this field is a base64 encoded X509_PEM.
    /// </summary>
    public TerraformValue<string>? PublicKeyData
    {
        get => GetArgument<TerraformValue<string>>("public_key_data");
        set => SetArgument("public_key_data", value);
    }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    public TerraformValue<string>? PublicKeyType
    {
        get => GetArgument<TerraformValue<string>>("public_key_type");
        set => SetArgument("public_key_type", value);
    }

    /// <summary>
    /// The ID of the parent service account of the key. This can be a string in the format {ACCOUNT} or projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}, where {ACCOUNT} is the email address or unique id of the service account. If the {ACCOUNT} syntax is used, the project will be inferred from the provider&#39;s configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountId is required")]
    public required TerraformValue<string> ServiceAccountId
    {
        get => GetArgument<TerraformValue<string>>("service_account_id");
        set => SetArgument("service_account_id", value);
    }

    /// <summary>
    /// The name used for this key pair
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The private key in JSON format, base64 encoded. This is what you normally get as a file when creating service account keys through the CLI or web console. This is only populated when creating a new key.
    /// </summary>
    public TerraformValue<string> PrivateKey
        => AsReference("private_key");

    /// <summary>
    /// The public key, base64 encoded
    /// </summary>
    public TerraformValue<string> PublicKey
        => AsReference("public_key");

    /// <summary>
    /// The key can be used after this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> ValidAfter
        => AsReference("valid_after");

    /// <summary>
    /// The key can be used before this timestamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> ValidBefore
        => AsReference("valid_before");

}
