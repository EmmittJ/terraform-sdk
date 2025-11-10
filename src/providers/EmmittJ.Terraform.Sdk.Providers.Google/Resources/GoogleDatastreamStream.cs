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
        set => SetProperty("destination_connection_profile", value);
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
        set => SetProperty("source_connection_profile", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("create_without_validation");
        SetOutput("customer_managed_encryption_key");
        SetOutput("desired_state");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
        SetOutput("stream_id");
    }

    /// <summary>
    /// Create the stream without validating it.
    /// </summary>
    public TerraformProperty<bool> CreateWithoutValidation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_without_validation");
        set => SetProperty("create_without_validation", value);
    }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    public TerraformProperty<string> CustomerManagedEncryptionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_encryption_key");
        set => SetProperty("customer_managed_encryption_key", value);
    }

    /// <summary>
    /// Desired state of the Stream. Set this field to &#39;RUNNING&#39; to start the stream,
    /// &#39;NOT_STARTED&#39; to create the stream without starting and &#39;PAUSED&#39; to pause
    /// the stream from a &#39;RUNNING&#39; state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    public TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The name of the location this stream is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The stream identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamId is required")]
    public required TerraformProperty<string> StreamId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_id");
        set => SetProperty("stream_id", value);
    }

    /// <summary>
    /// Block for backfill_all.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillAll block(s) allowed")]
    public List<GoogleDatastreamStreamBackfillAllBlock>? BackfillAll
    {
        set => SetProperty("backfill_all", value);
    }

    /// <summary>
    /// Block for backfill_none.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillNone block(s) allowed")]
    public List<GoogleDatastreamStreamBackfillNoneBlock>? BackfillNone
    {
        set => SetProperty("backfill_none", value);
    }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public List<GoogleDatastreamStreamDestinationConfigBlock>? DestinationConfig
    {
        set => SetProperty("destination_config", value);
    }

    /// <summary>
    /// Block for source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfig block(s) allowed")]
    public List<GoogleDatastreamStreamSourceConfigBlock>? SourceConfig
    {
        set => SetProperty("source_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatastreamStreamTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
