using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// The resource name of the Message Bus to which events should be
    /// published. The Message Bus resource should exist in the same project as
    /// the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/messageBuses/{message_bus}&#39;
    /// </summary>
    public TerraformProperty<string>? MessageBus
    {
        get => GetProperty<TerraformProperty<string>>("message_bus");
        set => WithProperty("message_bus", value);
    }

    /// <summary>
    /// The resource name of the Pub/Sub topic to which events should be
    /// published. Format:
    /// &#39;projects/{project}/locations/{location}/topics/{topic}&#39;
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by
    /// the events. The Workflow resource should be deployed in the same
    /// project as the Pipeline. Format:
    /// &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    public TerraformProperty<string>? Workflow
    {
        get => GetProperty<TerraformProperty<string>>("workflow");
        set => WithProperty("workflow", value);
    }

}

/// <summary>
/// Block type for input_payload_format in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineInputPayloadFormatBlock : TerraformBlock
{
}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The minimum severity of logs that will be sent to Stackdriver/Platform
    /// Telemetry. Logs at severitiy ≥ this value will be sent, unless it is NONE. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;NOTICE&amp;quot;, &amp;quot;WARNING&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;CRITICAL&amp;quot;, &amp;quot;ALERT&amp;quot;, &amp;quot;EMERGENCY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LogSeverity
    {
        get => GetProperty<TerraformProperty<string>>("log_severity");
        set => WithProperty("log_severity", value);
    }

}

/// <summary>
/// Block type for mediations in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineMediationsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcPipelineRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must
    /// be between 1 and 100.
    /// The default value for this field is 5.
    /// </summary>
    public TerraformProperty<double>? MaxAttempts
    {
        get => GetProperty<TerraformProperty<double>>("max_attempts");
        set => WithProperty("max_attempts", value);
    }

    /// <summary>
    /// The maximum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 60.
    /// </summary>
    public TerraformProperty<string>? MaxRetryDelay
    {
        get => GetProperty<TerraformProperty<string>>("max_retry_delay");
        set => WithProperty("max_retry_delay", value);
    }

    /// <summary>
    /// The minimum amount of seconds to wait between retry attempts. The value
    /// must be between 1 and 600.
    /// The default value for this field is 5.
    /// </summary>
    public TerraformProperty<string>? MinRetryDelay
    {
        get => GetProperty<TerraformProperty<string>>("min_retry_delay");
        set => WithProperty("min_retry_delay", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEventarcPipelineTimeoutsBlock : TerraformBlock
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
/// Manages a google_eventarc_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEventarcPipeline : TerraformResource
{
    public GoogleEventarcPipeline(string name) : base("google_eventarc_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_annotations");
        this.WithOutput("effective_labels");
        this.WithOutput("etag");
        this.WithOutput("name");
        this.WithOutput("terraform_labels");
        this.WithOutput("uid");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// User-defined annotations. See https://google.aip.dev/128#annotations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to
    /// encrypt/decrypt the event data. If not set, an internal Google-owned key
    /// will be used to encrypt messages. It must match the pattern
    /// &amp;quot;projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? CryptoKeyName
    {
        get => GetProperty<TerraformProperty<string>>("crypto_key_name");
        set => this.WithProperty("crypto_key_name", value);
    }

    /// <summary>
    /// Display name of resource.
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
    /// User labels attached to the Pipeline that can be used to group
    /// resources. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: {
    /// &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The user-provided ID to be assigned to the Pipeline. It should match the
    /// format &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    public required TerraformProperty<string> PipelineId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pipeline_id");
        set => this.WithProperty("pipeline_id", value);
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
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    public List<GoogleEventarcPipelineDestinationsBlock>? Destinations
    {
        get => GetProperty<List<GoogleEventarcPipelineDestinationsBlock>>("destinations");
        set => this.WithProperty("destinations", value);
    }

    /// <summary>
    /// Block for input_payload_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputPayloadFormat block(s) allowed")]
    public List<GoogleEventarcPipelineInputPayloadFormatBlock>? InputPayloadFormat
    {
        get => GetProperty<List<GoogleEventarcPipelineInputPayloadFormatBlock>>("input_payload_format");
        set => this.WithProperty("input_payload_format", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleEventarcPipelineLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<GoogleEventarcPipelineLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// Block for mediations.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleEventarcPipelineMediationsBlock>? Mediations
    {
        get => GetProperty<List<GoogleEventarcPipelineMediationsBlock>>("mediations");
        set => this.WithProperty("mediations", value);
    }

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public List<GoogleEventarcPipelineRetryPolicyBlock>? RetryPolicy
    {
        get => GetProperty<List<GoogleEventarcPipelineRetryPolicyBlock>>("retry_policy");
        set => this.WithProperty("retry_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEventarcPipelineTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleEventarcPipelineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The creation time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// This checksum is computed by the server based on the value of
    /// other fields, and might be sent only on create requests to ensure that the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The resource name of the Pipeline. Must be unique within the
    /// location of the project and must be in
    /// &#39;projects/{project}/locations/{location}/pipelines/{pipeline}&#39; format.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server-assigned unique identifier for the Pipeline. The value
    /// is a UUID4 string and guaranteed to remain unchanged until the resource is
    /// deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The last-modified time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up
    /// to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
