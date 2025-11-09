using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_datastream_stream resource.
/// </summary>
public class GoogleDatastreamStream : TerraformResource
{
    public GoogleDatastreamStream(string name) : base("google_datastream_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Create the stream without validating it.
    /// </summary>
    public TerraformProperty<bool>? CreateWithoutValidation
    {
        get => GetProperty<TerraformProperty<bool>>("create_without_validation");
        set => this.WithProperty("create_without_validation", value);
    }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedEncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_encryption_key");
        set => this.WithProperty("customer_managed_encryption_key", value);
    }

    /// <summary>
    /// Desired state of the Stream. Set this field to &#39;RUNNING&#39; to start the stream,
    /// &#39;NOT_STARTED&#39; to create the stream without starting and &#39;PAUSED&#39; to pause
    /// the stream from a &#39;RUNNING&#39; state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    public TerraformProperty<string>? DesiredState
    {
        get => GetProperty<TerraformProperty<string>>("desired_state");
        set => this.WithProperty("desired_state", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the location this stream is located in.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The stream identifier.
    /// </summary>
    public TerraformProperty<string>? StreamId
    {
        get => GetProperty<TerraformProperty<string>>("stream_id");
        set => this.WithProperty("stream_id", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The stream&#39;s name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the stream.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
