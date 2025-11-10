using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_all in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillAllBlock : TerraformBlock
{
}

/// <summary>
/// Block type for backfill_none in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamBackfillNoneBlock : TerraformBlock
{
}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConnectionProfile is required")]
    public required TerraformProperty<string> DestinationConnectionProfile
    {
        get => GetProperty<TerraformProperty<string>>("destination_connection_profile");
        set => WithProperty("destination_connection_profile", value);
    }

}

/// <summary>
/// Block type for source_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamStreamSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConnectionProfile is required")]
    public required TerraformProperty<string> SourceConnectionProfile
    {
        get => GetProperty<TerraformProperty<string>>("source_connection_profile");
        set => WithProperty("source_connection_profile", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamStreamTimeoutsBlock : TerraformBlock
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
/// Manages a google_datastream_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the location this stream is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamId is required")]
    public required TerraformProperty<string> StreamId
    {
        get => GetProperty<TerraformProperty<string>>("stream_id");
        set => this.WithProperty("stream_id", value);
    }

    /// <summary>
    /// Block for backfill_all.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillAll block(s) allowed")]
    public List<GoogleDatastreamStreamBackfillAllBlock>? BackfillAll
    {
        get => GetProperty<List<GoogleDatastreamStreamBackfillAllBlock>>("backfill_all");
        set => this.WithProperty("backfill_all", value);
    }

    /// <summary>
    /// Block for backfill_none.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillNone block(s) allowed")]
    public List<GoogleDatastreamStreamBackfillNoneBlock>? BackfillNone
    {
        get => GetProperty<List<GoogleDatastreamStreamBackfillNoneBlock>>("backfill_none");
        set => this.WithProperty("backfill_none", value);
    }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public List<GoogleDatastreamStreamDestinationConfigBlock>? DestinationConfig
    {
        get => GetProperty<List<GoogleDatastreamStreamDestinationConfigBlock>>("destination_config");
        set => this.WithProperty("destination_config", value);
    }

    /// <summary>
    /// Block for source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfig block(s) allowed")]
    public List<GoogleDatastreamStreamSourceConfigBlock>? SourceConfig
    {
        get => GetProperty<List<GoogleDatastreamStreamSourceConfigBlock>>("source_config");
        set => this.WithProperty("source_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatastreamStreamTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDatastreamStreamTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
