using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiEndpointEncryptionSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for predict_request_response_logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// If logging is enabled or not.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// Percentage of requests to be logged, expressed as a fraction in range(0,1]
    /// </summary>
    [TerraformProperty("sampling_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SamplingRate { get; set; }

}

/// <summary>
/// Block type for private_service_connect_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiEndpointPrivateServiceConnectConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. If true, expose the IndexEndpoint via private service connect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    [TerraformProperty("enable_private_service_connect")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> EnablePrivateServiceConnect { get; set; }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    [TerraformProperty("project_allowlist")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ProjectAllowlist { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiEndpointTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_vertex_ai_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVertexAiEndpoint : TerraformResource
{
    public GoogleVertexAiEndpoint(string name) : base("google_vertex_ai_endpoint", name)
    {
    }

    /// <summary>
    /// If true, the endpoint will be exposed through a dedicated DNS [Endpoint.dedicated_endpoint_dns]. Your request to the dedicated DNS will be isolated from other users&#39; traffic and will have better performance and reliability. Note: Once you enabled dedicated endpoint, you won&#39;t be able to send request to the shared DNS {region}-aiplatform.googleapis.com. The limitation will be removed soon.
    /// </summary>
    [TerraformProperty("dedicated_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DedicatedEndpointEnabled { get; set; }

    /// <summary>
    /// The description of the Endpoint.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Required. The display name of the Endpoint. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels with user-defined metadata to organize your Endpoints. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. See https://goo.gl/xmQnxf for more information and examples of labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the Endpoint. The name must be numeric with no leading zeros and can be at most 10 digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks) to which the Endpoint should be peered. Private services access must already be configured for the network. If left unspecified, the Endpoint is not peered with any network. Only one of the fields, network or enable_private_service_connect, can be set. [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/insert): &#39;projects/{project}/global/networks/{network}&#39;. Where &#39;{project}&#39; is a project number, as in &#39;12345&#39;, and &#39;{network}&#39; is network name. Only one of the fields, &#39;network&#39; or &#39;privateServiceConnectConfig&#39;, can be set.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region for the resource
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// A map from a DeployedModel&#39;s id to the percentage of this Endpoint&#39;s traffic that should be forwarded to that DeployedModel.
    /// If a DeployedModel&#39;s id is not listed in this map, then it receives no traffic.
    /// The traffic percentage values must add up to 100, or map must be empty if the Endpoint is to not accept any traffic at a moment. See
    /// the &#39;deployModel&#39; [example](https://cloud.google.com/vertex-ai/docs/general/deployment#deploy_a_model_to_an_endpoint) and
    /// [documentation](https://cloud.google.com/vertex-ai/docs/reference/rest/v1beta1/projects.locations.endpoints/deployModel) for more information.
    /// 
    /// ~&amp;gt; **Note:** To set the map to empty, set &#39;&amp;quot;{}&amp;quot;&#39;, apply, and then remove the field from your config.
    /// </summary>
    [TerraformProperty("traffic_split")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TrafficSplit { get; set; }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformProperty("encryption_spec")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointEncryptionSpecBlock>>? EncryptionSpec { get; set; }

    /// <summary>
    /// Block for predict_request_response_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictRequestResponseLoggingConfig block(s) allowed")]
    [TerraformProperty("predict_request_response_logging_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock>>? PredictRequestResponseLoggingConfig { get; set; }

    /// <summary>
    /// Block for private_service_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    [TerraformProperty("private_service_connect_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointPrivateServiceConnectConfigBlock>>? PrivateServiceConnectConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleVertexAiEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Timestamp when this Endpoint was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. DNS of the dedicated endpoint. Will only be populated if dedicatedEndpointEnabled is true. Format: &#39;https://{endpointId}.{region}-{projectNumber}.prediction.vertexai.goog&#39;.
    /// </summary>
    [TerraformProperty("dedicated_endpoint_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DedicatedEndpointDns { get; }

    /// <summary>
    /// Output only. The models deployed in this Endpoint. To add or remove DeployedModels use EndpointService.DeployModel and EndpointService.UndeployModel respectively. Models can also be deployed and undeployed using the [Cloud Console](https://console.cloud.google.com/vertex-ai/).
    /// </summary>
    [TerraformProperty("deployed_models")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DeployedModels { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Used to perform consistent read-modify-write updates. If not set, a blind &amp;quot;overwrite&amp;quot; update happens.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. Resource name of the Model Monitoring job associated with this Endpoint if monitoring is enabled by CreateModelDeploymentMonitoringJob. Format: &#39;projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}&#39;
    /// </summary>
    [TerraformProperty("model_deployment_monitoring_job")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ModelDeploymentMonitoringJob { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. Timestamp when this Endpoint was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
