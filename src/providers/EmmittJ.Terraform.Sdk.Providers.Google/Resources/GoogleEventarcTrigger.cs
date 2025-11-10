using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud Function resource name. Only Cloud Functions V2 is supported. Format projects/{project}/locations/{location}/functions/{function} This is a read-only field. [WARNING] Creating Cloud Functions V2 triggers is only supported via the Cloud Functions product. An error will be returned if the user sets this value.
    /// </summary>
    public TerraformProperty<string>? CloudFunction
    {
        set => SetProperty("cloud_function", value);
    }

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    public TerraformProperty<string>? Workflow
    {
        set => SetProperty("workflow", value);
    }

}

/// <summary>
/// Block type for matching_criteria in .
/// Nesting mode: set
/// </summary>
public class GoogleEventarcTriggerMatchingCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the &#39;type&#39; attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attribute is required")]
    public required TerraformProperty<string> Attribute
    {
        set => SetProperty("attribute", value);
    }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is &#39;match-path-pattern&#39;.
    /// </summary>
    public TerraformProperty<string>? Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEventarcTriggerTimeoutsBlock : TerraformBlock
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
/// Block type for transport in .
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerTransportBlock : TerraformBlock
{
}

/// <summary>
/// Manages a google_eventarc_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEventarcTrigger : TerraformResource
{
    public GoogleEventarcTrigger(string name) : base("google_eventarc_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("conditions");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("channel");
        SetOutput("event_data_content_type");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("service_account");
    }

    /// <summary>
    /// Optional. The name of the channel associated with the trigger in &#39;projects/{project}/locations/{location}/channels/{channel}&#39; format. You must provide a channel to receive events from Eventarc SaaS partners.
    /// </summary>
    public TerraformProperty<string> Channel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("channel");
        set => SetProperty("channel", value);
    }

    /// <summary>
    /// Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to &#39;application/json&#39; if the value is not defined.
    /// </summary>
    public TerraformProperty<string> EventDataContentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_data_content_type");
        set => SetProperty("event_data_content_type", value);
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
    /// Optional. User labels attached to the triggers that can be used to group resources.
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Required. The resource name of the trigger. Must be unique within the location on the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have &#39;iam.serviceAccounts.actAs&#39; permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have &#39;roles/eventarc.eventReceiver&#39; IAM role.
    /// </summary>
    public TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<GoogleEventarcTriggerDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for matching_criteria.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchingCriteria block(s) required")]
    public HashSet<GoogleEventarcTriggerMatchingCriteriaBlock>? MatchingCriteria
    {
        set => SetProperty("matching_criteria", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEventarcTriggerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for transport.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transport block(s) allowed")]
    public List<GoogleEventarcTriggerTransportBlock>? Transport
    {
        set => SetProperty("transport", value);
    }

    /// <summary>
    /// Output only. The reason(s) why a trigger is in FAILED state.
    /// </summary>
    public TerraformExpression Conditions => this["conditions"];

    /// <summary>
    /// Output only. The creation time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other fields, and may be sent only on create requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
