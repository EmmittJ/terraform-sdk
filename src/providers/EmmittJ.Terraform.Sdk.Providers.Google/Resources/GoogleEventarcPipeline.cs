using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlock : ITerraformBlock
{
    /// <summary>
    /// The resource name of the Message Bus to which events should be
    /// published. The Message Bus resource should exist in the same project as
    /// the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/messageBuses/{message_bus}&#39;
    /// </summary>
    [TerraformPropertyName("message_bus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageBus { get; set; }

    /// <summary>
    /// The resource name of the Pub/Sub topic to which events should be
    /// published. Format:
    /// &#39;projects/{project}/locations/{location}/topics/{topic}&#39;
    /// </summary>
    [TerraformPropertyName("topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Topic { get; set; }

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by
    /// the events. The Workflow resource should be deployed in the same
    /// project as the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    [TerraformPropertyName("workflow")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Workflow { get; set; }

}

/// <summary>
/// Block type for input_payload_format in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineInputPayloadFormatBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The minimum severity of logs that will be sent to Stackdriver/Platform
    /// Telemetry. Logs at severitiy ≥ this value will be sent, unless it is NONE. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;NOTICE&amp;quot;, &amp;quot;WARNING&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;CRITICAL&amp;quot;, &amp;quot;ALERT&amp;quot;, &amp;quot;EMERGENCY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("log_severity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogSeverity { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "log_severity");

}

/// <summary>
/// Block type for mediations in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineMediationsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineRetryPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must
    /// be between 1 and 100.
    /// The default value for this field is 5.
    /// </summary>
    [TerraformPropertyName("max_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxAttempts { get; set; }

    /// <summary>
    /// The maximum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 60.
    /// </summary>
    [TerraformPropertyName("max_retry_delay")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxRetryDelay { get; set; }

    /// <summary>
    /// The minimum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 5.
    /// </summary>
    [TerraformPropertyName("min_retry_delay")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinRetryDelay { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEventarcPipelineTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_eventarc_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEventarcPipeline : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to
    /// encrypt/decrypt the event data. If not set, an internal Google-owned key
    /// will be used to encrypt messages. It must match the pattern
    /// &amp;quot;projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("crypto_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CryptoKeyName { get; set; }

    /// <summary>
    /// Display name of resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User labels attached to the Pipeline that can be used to group
    /// resources. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: {
    /// &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The user-provided ID to be assigned to the Pipeline. It should match the
    /// format &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    [TerraformPropertyName("pipeline_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PipelineId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [TerraformPropertyName("destinations")]
    public TerraformList<TerraformBlock<GoogleEventarcPipelineDestinationsBlock>>? Destinations { get; set; } = new();

    /// <summary>
    /// Block for input_payload_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputPayloadFormat block(s) allowed")]
    [TerraformPropertyName("input_payload_format")]
    public TerraformList<TerraformBlock<GoogleEventarcPipelineInputPayloadFormatBlock>>? InputPayloadFormat { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<GoogleEventarcPipelineLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for mediations.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("mediations")]
    public TerraformList<TerraformBlock<GoogleEventarcPipelineMediationsBlock>>? Mediations { get; set; } = new();

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformPropertyName("retry_policy")]
    public TerraformList<TerraformBlock<GoogleEventarcPipelineRetryPolicyBlock>>? RetryPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleEventarcPipelineTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The creation time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of
    /// other fields, and might be sent only on create requests to ensure that the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The resource name of the Pipeline. Must be unique within the
    /// location of the project and must be in
    /// &#39;projects/{project}/locations/{location}/pipelines/{pipeline}&#39; format.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Server-assigned unique identifier for the Pipeline. The value
    /// is a UUID4 string and guaranteed to remain unchanged until the resource is
    /// deleted.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The last-modified time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
