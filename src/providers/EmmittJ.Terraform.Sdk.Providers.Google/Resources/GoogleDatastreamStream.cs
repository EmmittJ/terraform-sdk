using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backfill_all in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamStreamBackfillAllBlock() : TerraformBlock("backfill_all")
{
}

/// <summary>
/// Block type for backfill_none in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamStreamBackfillNoneBlock() : TerraformBlock("backfill_none")
{
}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamStreamDestinationConfigBlock() : TerraformBlock("destination_config")
{
    /// <summary>
    /// Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConnectionProfile is required")]
    [TerraformProperty("destination_connection_profile")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationConnectionProfile { get; set; }

}

/// <summary>
/// Block type for source_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamStreamSourceConfigBlock() : TerraformBlock("source_config")
{
    /// <summary>
    /// Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConnectionProfile is required")]
    [TerraformProperty("source_connection_profile")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceConnectionProfile { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDatastreamStreamTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_datastream_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDatastreamStream : TerraformResource
{
    public GoogleDatastreamStream(string name) : base("google_datastream_stream", name)
    {
    }

    /// <summary>
    /// Create the stream without validating it.
    /// </summary>
    [TerraformProperty("create_without_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateWithoutValidation { get; set; }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    [TerraformProperty("customer_managed_encryption_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerManagedEncryptionKey { get; set; }

    /// <summary>
    /// Desired state of the Stream. Set this field to &#39;RUNNING&#39; to start the stream,
    /// &#39;NOT_STARTED&#39; to create the stream without starting and &#39;PAUSED&#39; to pause
    /// the stream from a &#39;RUNNING&#39; state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the location this stream is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The stream identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamId is required")]
    [TerraformProperty("stream_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamId { get; set; }

    /// <summary>
    /// Block for backfill_all.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillAll block(s) allowed")]
    [TerraformProperty("backfill_all")]
    public TerraformList<GoogleDatastreamStreamBackfillAllBlock> BackfillAll { get; set; } = new();

    /// <summary>
    /// Block for backfill_none.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackfillNone block(s) allowed")]
    [TerraformProperty("backfill_none")]
    public TerraformList<GoogleDatastreamStreamBackfillNoneBlock> BackfillNone { get; set; } = new();

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    [TerraformProperty("destination_config")]
    public required TerraformList<GoogleDatastreamStreamDestinationConfigBlock> DestinationConfig { get; set; } = new();

    /// <summary>
    /// Block for source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfig block(s) allowed")]
    [TerraformProperty("source_config")]
    public required TerraformList<GoogleDatastreamStreamSourceConfigBlock> SourceConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDatastreamStreamTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The stream&#39;s name.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The state of the stream.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
