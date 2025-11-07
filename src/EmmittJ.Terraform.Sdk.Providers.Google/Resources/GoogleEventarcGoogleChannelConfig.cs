using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_eventarc_google_channel_config resource.
/// </summary>
public class GoogleEventarcGoogleChannelConfig : TerraformResource
{
    public GoogleEventarcGoogleChannelConfig(string name) : base("google_eventarc_google_channel_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt their event data. It must match the pattern &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    public TerraformProperty<string>? CryptoKeyName
    {
        get => GetProperty<TerraformProperty<string>>("crypto_key_name");
        set => this.WithProperty("crypto_key_name", value);
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
    /// The location for the resource
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Required. The resource name of the config. Must be in the format of, &#39;projects/{project}/locations/{location}/googleChannelConfig&#39;.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Output only. The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
