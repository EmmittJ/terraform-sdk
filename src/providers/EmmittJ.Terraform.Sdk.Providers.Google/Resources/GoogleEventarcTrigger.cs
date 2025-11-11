using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcTriggerDestinationBlock : TerraformBlockBase
{

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    [TerraformProperty("workflow")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Workflow { get; set; }

}

/// <summary>
/// Block type for matching_criteria in .
/// Nesting mode: set
/// </summary>
public partial class GoogleEventarcTriggerMatchingCriteriaBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the &#39;type&#39; attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attribute is required")]
    [TerraformProperty("attribute")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Attribute { get; set; }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is &#39;match-path-pattern&#39;.
    /// </summary>
    [TerraformProperty("operator")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Operator { get; set; }

    /// <summary>
    /// Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleEventarcTriggerTimeoutsBlock : TerraformBlockBase
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
/// Block type for transport in .
/// Nesting mode: list
/// </summary>
public partial class GoogleEventarcTriggerTransportBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a google_eventarc_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleEventarcTrigger : TerraformResource
{
    public GoogleEventarcTrigger(string name) : base("google_eventarc_trigger", name)
    {
    }

    /// <summary>
    /// Optional. The name of the channel associated with the trigger in &#39;projects/{project}/locations/{location}/channels/{channel}&#39; format. You must provide a channel to receive events from Eventarc SaaS partners.
    /// </summary>
    [TerraformProperty("channel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Channel { get; set; }

    /// <summary>
    /// Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to &#39;application/json&#39; if the value is not defined.
    /// </summary>
    [TerraformProperty("event_data_content_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EventDataContentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. User labels attached to the triggers that can be used to group resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Required. The resource name of the trigger. Must be unique within the location on the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have &#39;iam.serviceAccounts.actAs&#39; permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have &#39;roles/eventarc.eventReceiver&#39; IAM role.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformProperty("destination")]
    public partial TerraformList<TerraformBlock<GoogleEventarcTriggerDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for matching_criteria.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchingCriteria block(s) required")]
    [TerraformProperty("matching_criteria")]
    public partial TerraformSet<TerraformBlock<GoogleEventarcTriggerMatchingCriteriaBlock>>? MatchingCriteria { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleEventarcTriggerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for transport.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transport block(s) allowed")]
    [TerraformProperty("transport")]
    public partial TerraformList<TerraformBlock<GoogleEventarcTriggerTransportBlock>>? Transport { get; set; }

    /// <summary>
    /// Output only. The reason(s) why a trigger is in FAILED state.
    /// </summary>
    [TerraformProperty("conditions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Conditions { get; }

    /// <summary>
    /// Output only. The creation time.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other fields, and may be sent only on create requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The last-modified time.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
