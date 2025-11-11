using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcPipelineDestinationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource name of the Message Bus to which events should be
    /// published. The Message Bus resource should exist in the same project as
    /// the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/messageBuses/{message_bus}&#39;
    /// </summary>
    [TerraformProperty("message_bus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageBus { get; set; }

    /// <summary>
    /// The resource name of the Pub/Sub topic to which events should be
    /// published. Format:
    /// &#39;projects/{project}/locations/{location}/topics/{topic}&#39;
    /// </summary>
    [TerraformProperty("topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Topic { get; set; }

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by
    /// the events. The Workflow resource should be deployed in the same
    /// project as the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    [TerraformProperty("workflow")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Workflow { get; set; }

}

/// <summary>
/// Block type for input_payload_format in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcPipelineInputPayloadFormatBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcPipelineLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The minimum severity of logs that will be sent to Stackdriver/Platform
    /// Telemetry. Logs at severitiy ≥ this value will be sent, unless it is NONE. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;NOTICE&amp;quot;, &amp;quot;WARNING&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;CRITICAL&amp;quot;, &amp;quot;ALERT&amp;quot;, &amp;quot;EMERGENCY&amp;quot;]
    /// </summary>
    [TerraformProperty("log_severity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogSeverity { get; set; }

}

/// <summary>
/// Block type for mediations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcPipelineMediationsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcPipelineRetryPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must
    /// be between 1 and 100.
    /// The default value for this field is 5.
    /// </summary>
    [TerraformProperty("max_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAttempts { get; set; }

    /// <summary>
    /// The maximum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 60.
    /// </summary>
    [TerraformProperty("max_retry_delay")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxRetryDelay { get; set; }

    /// <summary>
    /// The minimum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 5.
    /// </summary>
    [TerraformProperty("min_retry_delay")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinRetryDelay { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleEventarcPipelineTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_eventarc_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleEventarcPipeline : TerraformResource
{
    public GoogleEventarcPipeline(string name) : base("google_eventarc_pipeline", name)
    {
    }

    /// <summary>
    /// User-defined annotations. See https://google.aip.dev/128#annotations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to
    /// encrypt/decrypt the event data. If not set, an internal Google-owned key
    /// will be used to encrypt messages. It must match the pattern
    /// &amp;quot;projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}&amp;quot;.
    /// </summary>
    [TerraformProperty("crypto_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CryptoKeyName { get; set; }

    /// <summary>
    /// Display name of resource.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User labels attached to the Pipeline that can be used to group
    /// resources. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: {
    /// &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The user-provided ID to be assigned to the Pipeline. It should match the
    /// format &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    [TerraformProperty("pipeline_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PipelineId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [TerraformProperty("destinations")]
    public partial TerraformList<TerraformBlock<GoogleEventarcPipelineDestinationsBlock>>? Destinations { get; set; }

    /// <summary>
    /// Block for input_payload_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputPayloadFormat block(s) allowed")]
    [TerraformProperty("input_payload_format")]
    public partial TerraformList<TerraformBlock<GoogleEventarcPipelineInputPayloadFormatBlock>>? InputPayloadFormat { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public partial TerraformList<TerraformBlock<GoogleEventarcPipelineLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// Block for mediations.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("mediations")]
    public partial TerraformList<TerraformBlock<GoogleEventarcPipelineMediationsBlock>>? Mediations { get; set; }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformProperty("retry_policy")]
    public partial TerraformList<TerraformBlock<GoogleEventarcPipelineRetryPolicyBlock>>? RetryPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleEventarcPipelineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creation time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of
    /// other fields, and might be sent only on create requests to ensure that the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The resource name of the Pipeline. Must be unique within the
    /// location of the project and must be in
    /// &#39;projects/{project}/locations/{location}/pipelines/{pipeline}&#39; format.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Server-assigned unique identifier for the Pipeline. The value
    /// is a UUID4 string and guaranteed to remain unchanged until the resource is
    /// deleted.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The last-modified time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
