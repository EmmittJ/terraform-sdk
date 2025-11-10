using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcGoogleApiSourceLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The minimum severity of logs that will be sent to Stackdriver/Platform
    /// Telemetry. Logs at severitiy ≥ this value will be sent, unless it is NONE. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG&amp;quot;, &amp;quot;INFO&amp;quot;, &amp;quot;NOTICE&amp;quot;, &amp;quot;WARNING&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;CRITICAL&amp;quot;, &amp;quot;ALERT&amp;quot;, &amp;quot;EMERGENCY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LogSeverity
    {
        set => SetProperty("log_severity", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEventarcGoogleApiSourceTimeoutsBlock : TerraformBlock
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
/// Manages a google_eventarc_google_api_source resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEventarcGoogleApiSource : TerraformResource
{
    public GoogleEventarcGoogleApiSource(string name) : base("google_eventarc_google_api_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("crypto_key_name");
        SetOutput("destination");
        SetOutput("display_name");
        SetOutput("google_api_source_id");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Resource annotations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to
    /// encrypt/decrypt their event data.
    /// 
    /// It must match the pattern
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    public TerraformProperty<string> CryptoKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("crypto_key_name");
        set => SetProperty("crypto_key_name", value);
    }

    /// <summary>
    /// Destination is the message bus that the GoogleApiSource is delivering to.
    /// It must be point to the full resource name of a MessageBus. Format:
    /// &amp;quot;projects/{PROJECT_ID}/locations/{region}/messagesBuses/{MESSAGE_BUS_ID)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination");
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Resource display name.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The user-provided ID to be assigned to the GoogleApiSource. It should match
    /// the format &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GoogleApiSourceId is required")]
    public required TerraformProperty<string> GoogleApiSourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("google_api_source_id");
        set => SetProperty("google_api_source_id", value);
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
    /// Resource labels.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
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
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleEventarcGoogleApiSourceLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEventarcGoogleApiSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The creation time.
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
    /// This checksum is computed by the server based on the value of other
    /// fields, and might be sent only on update and delete requests to ensure that
    /// the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Resource name of the form
    /// projects/{project}/locations/{location}/googleApiSources/{google_api_source}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server assigned unique identifier for the channel. The value is a UUID4
    /// string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
