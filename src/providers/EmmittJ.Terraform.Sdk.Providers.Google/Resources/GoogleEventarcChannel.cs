using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEventarcChannelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_eventarc_channel resource.
/// </summary>
public class GoogleEventarcChannel : TerraformResource
{
    public GoogleEventarcChannel(string name) : base("google_eventarc_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("activation_token");
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("pubsub_topic");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
        this.WithOutput("uid");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt their event data. It must match the pattern &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
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
    /// User-defined labels for the channel.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the channel. Must be unique within the location on the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The name of the event provider (e.g. Eventarc SaaS partner) associated with the channel. This provider will be granted permissions to publish events to the channel. Format: &#39;projects/{project}/locations/{location}/providers/{provider_id}&#39;.
    /// </summary>
    public TerraformProperty<string>? ThirdPartyProvider
    {
        get => GetProperty<TerraformProperty<string>>("third_party_provider");
        set => this.WithProperty("third_party_provider", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEventarcChannelTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleEventarcChannelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The activation token for the channel. The token must be used by the provider to register the channel for publishing.
    /// </summary>
    public TerraformExpression ActivationToken => this["activation_token"];

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The name of the Pub/Sub topic created and managed by Eventarc system as a transport for the event delivery. Format: &#39;projects/{project}/topics/{topic_id}&#39;.
    /// </summary>
    public TerraformExpression PubsubTopic => this["pubsub_topic"];

    /// <summary>
    /// The state of a Channel.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server assigned unique identifier for the channel. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
