using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in GoogleEventarcTrigger.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The Cloud Function resource name. Only Cloud Functions V2 is supported. Format projects/{project}/locations/{location}/functions/{function} This is a read-only field. [WARNING] Creating Cloud Functions V2 triggers is only supported via the Cloud Functions product. An error will be returned if the user sets this value.
    /// </summary>
    public TerraformValue<string> CloudFunction
        => AsReference("cloud_function");

    /// <summary>
    /// The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: &#39;projects/{project}/locations/{location}/workflows/{workflow}&#39;
    /// </summary>
    public TerraformValue<string>? Workflow
    {
        get => GetArgument<TerraformValue<string>>("workflow");
        set => SetArgument("workflow", value);
    }

    /// <summary>
    /// CloudRunService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudRunService block(s) allowed")]
    public TerraformList<GoogleEventarcTriggerDestinationBlockCloudRunServiceBlock>? CloudRunService
    {
        get => GetArgument<TerraformList<GoogleEventarcTriggerDestinationBlockCloudRunServiceBlock>>("cloud_run_service");
        set => SetArgument("cloud_run_service", value);
    }

    /// <summary>
    /// Gke block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gke block(s) allowed")]
    public TerraformList<GoogleEventarcTriggerDestinationBlockGkeBlock>? Gke
    {
        get => GetArgument<TerraformList<GoogleEventarcTriggerDestinationBlockGkeBlock>>("gke");
        set => SetArgument("gke", value);
    }

    /// <summary>
    /// HttpEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpoint block(s) allowed")]
    public TerraformList<GoogleEventarcTriggerDestinationBlockHttpEndpointBlock>? HttpEndpoint
    {
        get => GetArgument<TerraformList<GoogleEventarcTriggerDestinationBlockHttpEndpointBlock>>("http_endpoint");
        set => SetArgument("http_endpoint", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleEventarcTriggerDestinationBlockNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleEventarcTriggerDestinationBlockNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

}

/// <summary>
/// Block type for cloud_run_service in GoogleEventarcTriggerDestinationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerDestinationBlockCloudRunServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_run_service";

    /// <summary>
    /// Optional. The relative path on the Cloud Run service the events should be sent to. The value must conform to the definition of URI path segment (section 3.3 of RFC2396). Examples: &amp;quot;/route&amp;quot;, &amp;quot;route&amp;quot;, &amp;quot;route/subroute&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Required. The region the Cloud Run service is deployed in.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Required. The name of the Cloud Run service being addressed. See https://cloud.google.com/run/docs/reference/rest/v1/namespaces.services. Only services located in the same project of the trigger object can be addressed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for gke in GoogleEventarcTriggerDestinationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerDestinationBlockGkeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke";

    /// <summary>
    /// Required. The name of the cluster the GKE service is running in. The cluster must be running in the same project as the trigger being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Required. The name of the Google Compute Engine in which the cluster resides, which can either be compute zone (for example, us-central1-a) for the zonal clusters or region (for example, us-central1) for regional clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Required. The namespace the GKE service is running in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: &amp;quot;/route&amp;quot;, &amp;quot;route&amp;quot;, &amp;quot;route/subroute&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Required. Name of the GKE service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_endpoint in GoogleEventarcTriggerDestinationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerDestinationBlockHttpEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_endpoint";

    /// <summary>
    /// Required. The URI of the HTTP enpdoint. The value must be a RFC2396 URI string. Examples: &#39;http://10.10.10.8:80/route&#39;, &#39;http://svc.us-central1.p.local:8080/&#39;. Only HTTP and HTTPS protocols are supported. The host can be either a static IP addressable from the VPC specified by the network config, or an internal DNS hostname of the service resolvable via Cloud DNS.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for network_config in GoogleEventarcTriggerDestinationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerDestinationBlockNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Required. Name of the NetworkAttachment that allows access to the destination VPC. Format: &#39;projects/{PROJECT_ID}/regions/{REGION}/networkAttachments/{NETWORK_ATTACHMENT_NAME}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAttachment is required")]
    public required TerraformValue<string> NetworkAttachment
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_attachment");
        set => SetArgument("network_attachment", value);
    }

}


/// <summary>
/// Block type for matching_criteria in GoogleEventarcTrigger.
/// Nesting mode: set
/// </summary>
public class GoogleEventarcTriggerMatchingCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matching_criteria";

    /// <summary>
    /// Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the &#39;type&#39; attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attribute is required")]
    public required TerraformValue<string> Attribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("attribute");
        set => SetArgument("attribute", value);
    }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is &#39;match-path-pattern&#39;.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleEventarcTrigger.
/// Nesting mode: single
/// </summary>
public class GoogleEventarcTriggerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for transport in GoogleEventarcTrigger.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerTransportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transport";

    /// <summary>
    /// Pubsub block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pubsub block(s) allowed")]
    public TerraformList<GoogleEventarcTriggerTransportBlockPubsubBlock>? Pubsub
    {
        get => GetArgument<TerraformList<GoogleEventarcTriggerTransportBlockPubsubBlock>>("pubsub");
        set => SetArgument("pubsub", value);
    }

}

/// <summary>
/// Block type for pubsub in GoogleEventarcTriggerTransportBlock.
/// Nesting mode: list
/// </summary>
public class GoogleEventarcTriggerTransportBlockPubsubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub";

    /// <summary>
    /// Output only. The name of the Pub/Sub subscription created and managed by Eventarc system as a transport for the event delivery. Format: &#39;projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_NAME}&#39;.
    /// </summary>
    public TerraformValue<string> Subscription
        => AsReference("subscription");

    /// <summary>
    /// Optional. The name of the Pub/Sub topic created and managed by Eventarc system as a transport for the event delivery. Format: &#39;projects/{PROJECT_ID}/topics/{TOPIC_NAME}. You may set an existing topic for triggers of the type google.cloud.pubsub.topic.v1.messagePublished&#39; only. The topic you provide here will not be deleted by Eventarc at trigger deletion.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Represents a google_eventarc_trigger Terraform resource.
/// Manages a google_eventarc_trigger resource.
/// </summary>
public partial class GoogleEventarcTrigger(string name) : TerraformResource("google_eventarc_trigger", name)
{
    /// <summary>
    /// Optional. The name of the channel associated with the trigger in &#39;projects/{project}/locations/{location}/channels/{channel}&#39; format. You must provide a channel to receive events from Eventarc SaaS partners.
    /// </summary>
    public TerraformValue<string>? Channel
    {
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to &#39;application/json&#39; if the value is not defined.
    /// </summary>
    public TerraformValue<string> EventDataContentType
    {
        get => GetArgument<TerraformValue<string>>("event_data_content_type") ?? AsReference("event_data_content_type");
        set => SetArgument("event_data_content_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. User labels attached to the triggers that can be used to group resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Required. The resource name of the trigger. Must be unique within the location on the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have &#39;iam.serviceAccounts.actAs&#39; permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have &#39;roles/eventarc.eventReceiver&#39; IAM role.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Output only. The reason(s) why a trigger is in FAILED state.
    /// </summary>
    public TerraformMap<string> Conditions
        => AsReference("conditions");

    /// <summary>
    /// Output only. The creation time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other fields, and may be sent only on create requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. The last-modified time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<GoogleEventarcTriggerDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<GoogleEventarcTriggerDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// MatchingCriteria block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchingCriteria block(s) required")]
    public required TerraformSet<GoogleEventarcTriggerMatchingCriteriaBlock> MatchingCriteria
    {
        get => GetRequiredArgument<TerraformSet<GoogleEventarcTriggerMatchingCriteriaBlock>>("matching_criteria");
        set => SetArgument("matching_criteria", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEventarcTriggerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEventarcTriggerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Transport block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transport block(s) allowed")]
    public TerraformList<GoogleEventarcTriggerTransportBlock>? Transport
    {
        get => GetArgument<TerraformList<GoogleEventarcTriggerTransportBlock>>("transport");
        set => SetArgument("transport", value);
    }

}
