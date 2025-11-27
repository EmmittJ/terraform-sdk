using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleVertexAiEndpoint.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for predict_request_response_logging_config in GoogleVertexAiEndpoint.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predict_request_response_logging_config";

    /// <summary>
    /// If logging is enabled or not.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Percentage of requests to be logged, expressed as a fraction in range(0,1]
    /// </summary>
    public TerraformValue<double>? SamplingRate
    {
        get => new TerraformReference<double>(this, "sampling_rate");
        set => SetArgument("sampling_rate", value);
    }

    /// <summary>
    /// BigqueryDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDestination block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlockBigqueryDestinationBlock>? BigqueryDestination
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlockBigqueryDestinationBlock>>("bigquery_destination");
        set => SetArgument("bigquery_destination", value);
    }

}

/// <summary>
/// Block type for bigquery_destination in GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlockBigqueryDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_destination";

    /// <summary>
    /// BigQuery URI to a project or table, up to 2000 characters long. When only the project is specified, the Dataset and Table is created. When the full table reference is specified, the Dataset must exist and table must not exist. Accepted forms: - BigQuery path. For example: &#39;bq://projectId&#39; or &#39;bq://projectId.bqDatasetId&#39; or &#39;bq://projectId.bqDatasetId.bqTableId&#39;.
    /// </summary>
    public TerraformValue<string>? OutputUri
    {
        get => new TerraformReference<string>(this, "output_uri");
        set => SetArgument("output_uri", value);
    }

}


/// <summary>
/// Block type for private_service_connect_config in GoogleVertexAiEndpoint.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointPrivateServiceConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_service_connect_config";

    /// <summary>
    /// Required. If true, expose the IndexEndpoint via private service connect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    public required TerraformValue<bool> EnablePrivateServiceConnect
    {
        get => new TerraformReference<bool>(this, "enable_private_service_connect");
        set => SetArgument("enable_private_service_connect", value);
    }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    public TerraformList<string>? ProjectAllowlist
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "project_allowlist").ResolveNodes(ctx));
        set => SetArgument("project_allowlist", value);
    }

    /// <summary>
    /// PscAutomationConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleVertexAiEndpointPrivateServiceConnectConfigBlockPscAutomationConfigsBlock>? PscAutomationConfigs
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointPrivateServiceConnectConfigBlockPscAutomationConfigsBlock>>("psc_automation_configs");
        set => SetArgument("psc_automation_configs", value);
    }

}

/// <summary>
/// Block type for psc_automation_configs in GoogleVertexAiEndpointPrivateServiceConnectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointPrivateServiceConnectConfigBlockPscAutomationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_automation_configs";

    /// <summary>
    /// Error message if the PSC service automation failed.
    /// </summary>
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

    /// <summary>
    /// Forwarding rule created by the PSC service automation.
    /// </summary>
    public TerraformValue<string> ForwardingRule
    {
        get => new TerraformReference<string>(this, "forwarding_rule");
    }

    /// <summary>
    /// IP address rule created by the PSC service automation.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The full name of the Google Compute Engine [network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/get): projects/{project}/global/networks/{network}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Project id used to create forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The state of the PSC service automation.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiEndpoint.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiEndpointTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vertex_ai_endpoint Terraform resource.
/// Manages a google_vertex_ai_endpoint resource.
/// </summary>
public partial class GoogleVertexAiEndpoint(string name) : TerraformResource("google_vertex_ai_endpoint", name)
{
    /// <summary>
    /// If true, the endpoint will be exposed through a dedicated DNS [Endpoint.dedicated_endpoint_dns]. Your request to the dedicated DNS will be isolated from other users&#39; traffic and will have better performance and reliability. Note: Once you enabled dedicated endpoint, you won&#39;t be able to send request to the shared DNS {region}-aiplatform.googleapis.com. The limitation will be removed soon.
    /// </summary>
    public TerraformValue<bool>? DedicatedEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "dedicated_endpoint_enabled");
        set => SetArgument("dedicated_endpoint_enabled", value);
    }

    /// <summary>
    /// The description of the Endpoint.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Required. The display name of the Endpoint. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels with user-defined metadata to organize your Endpoints. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. See https://goo.gl/xmQnxf for more information and examples of labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the Endpoint. The name must be numeric with no leading zeros and can be at most 10 digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks) to which the Endpoint should be peered. Private services access must already be configured for the network. If left unspecified, the Endpoint is not peered with any network. Only one of the fields, network or enable_private_service_connect, can be set. [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/insert): &#39;projects/{project}/global/networks/{network}&#39;. Where &#39;{project}&#39; is a project number, as in &#39;12345&#39;, and &#39;{network}&#39; is network name. Only one of the fields, &#39;network&#39; or &#39;privateServiceConnectConfig&#39;, can be set.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region for the resource
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A map from a DeployedModel&#39;s id to the percentage of this Endpoint&#39;s traffic that should be forwarded to that DeployedModel.
    /// If a DeployedModel&#39;s id is not listed in this map, then it receives no traffic.
    /// The traffic percentage values must add up to 100, or map must be empty if the Endpoint is to not accept any traffic at a moment. See
    /// the &#39;deployModel&#39; [example](https://cloud.google.com/vertex-ai/docs/general/deployment#deploy_a_model_to_an_endpoint) and
    /// [documentation](https://cloud.google.com/vertex-ai/docs/reference/rest/v1beta1/projects.locations.endpoints/deployModel) for more information.
    /// 
    /// ~&amp;gt; **Note:** To set the map to empty, set &#39;&amp;quot;{}&amp;quot;&#39;, apply, and then remove the field from your config.
    /// </summary>
    public TerraformValue<string> TrafficSplit
    {
        get => new TerraformReference<string>(this, "traffic_split");
        set => SetArgument("traffic_split", value);
    }

    /// <summary>
    /// Output only. Timestamp when this Endpoint was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. DNS of the dedicated endpoint. Will only be populated if dedicatedEndpointEnabled is true. Format: &#39;https://{endpointId}.{region}-{projectNumber}.prediction.vertexai.goog&#39;.
    /// </summary>
    public TerraformValue<string> DedicatedEndpointDns
    {
        get => new TerraformReference<string>(this, "dedicated_endpoint_dns");
    }

    /// <summary>
    /// Output only. The models deployed in this Endpoint. To add or remove DeployedModels use EndpointService.DeployModel and EndpointService.UndeployModel respectively. Models can also be deployed and undeployed using the [Cloud Console](https://console.cloud.google.com/vertex-ai/).
    /// </summary>
    public TerraformList<TerraformMap<object>> DeployedModels
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "deployed_models").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Used to perform consistent read-modify-write updates. If not set, a blind &amp;quot;overwrite&amp;quot; update happens.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Output only. Resource name of the Model Monitoring job associated with this Endpoint if monitoring is enabled by CreateModelDeploymentMonitoringJob. Format: &#39;projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}&#39;
    /// </summary>
    public TerraformValue<string> ModelDeploymentMonitoringJob
    {
        get => new TerraformReference<string>(this, "model_deployment_monitoring_job");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Timestamp when this Endpoint was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// PredictRequestResponseLoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictRequestResponseLoggingConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock>? PredictRequestResponseLoggingConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock>>("predict_request_response_logging_config");
        set => SetArgument("predict_request_response_logging_config", value);
    }

    /// <summary>
    /// PrivateServiceConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiEndpointPrivateServiceConnectConfigBlock>? PrivateServiceConnectConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiEndpointPrivateServiceConnectConfigBlock>>("private_service_connect_config");
        set => SetArgument("private_service_connect_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
