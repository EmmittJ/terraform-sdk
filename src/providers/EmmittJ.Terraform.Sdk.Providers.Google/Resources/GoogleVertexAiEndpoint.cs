using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointEncryptionSpecBlock : ITerraformBlock
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformPropertyName("kms_key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for predict_request_response_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// If logging is enabled or not.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// Percentage of requests to be logged, expressed as a fraction in range(0,1]
    /// </summary>
    [TerraformPropertyName("sampling_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SamplingRate { get; set; }

}

/// <summary>
/// Block type for private_service_connect_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointPrivateServiceConnectConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. If true, expose the IndexEndpoint via private service connect.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    [TerraformPropertyName("enable_private_service_connect")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnablePrivateServiceConnect { get; set; }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    [TerraformPropertyName("project_allowlist")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ProjectAllowlist { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiEndpointTimeoutsBlock : ITerraformBlock
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
/// Manages a google_vertex_ai_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiEndpoint : TerraformResource
{
    public GoogleVertexAiEndpoint(string name) : base("google_vertex_ai_endpoint", name)
    {
    }

    /// <summary>
    /// If true, the endpoint will be exposed through a dedicated DNS [Endpoint.dedicated_endpoint_dns]. Your request to the dedicated DNS will be isolated from other users&#39; traffic and will have better performance and reliability. Note: Once you enabled dedicated endpoint, you won&#39;t be able to send request to the shared DNS {region}-aiplatform.googleapis.com. The limitation will be removed soon.
    /// </summary>
    [TerraformPropertyName("dedicated_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DedicatedEndpointEnabled { get; set; }

    /// <summary>
    /// The description of the Endpoint.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Required. The display name of the Endpoint. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The labels with user-defined metadata to organize your Endpoints. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. See https://goo.gl/xmQnxf for more information and examples of labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The resource name of the Endpoint. The name must be numeric with no leading zeros and can be at most 10 digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks) to which the Endpoint should be peered. Private services access must already be configured for the network. If left unspecified, the Endpoint is not peered with any network. Only one of the fields, network or enable_private_service_connect, can be set. [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/insert): &#39;projects/{project}/global/networks/{network}&#39;. Where &#39;{project}&#39; is a project number, as in &#39;12345&#39;, and &#39;{network}&#39; is network name. Only one of the fields, &#39;network&#39; or &#39;privateServiceConnectConfig&#39;, can be set.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region for the resource
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// A map from a DeployedModel&#39;s id to the percentage of this Endpoint&#39;s traffic that should be forwarded to that DeployedModel.
    /// If a DeployedModel&#39;s id is not listed in this map, then it receives no traffic.
    /// The traffic percentage values must add up to 100, or map must be empty if the Endpoint is to not accept any traffic at a moment. See
    /// the &#39;deployModel&#39; [example](https://cloud.google.com/vertex-ai/docs/general/deployment#deploy_a_model_to_an_endpoint) and
    /// [documentation](https://cloud.google.com/vertex-ai/docs/reference/rest/v1beta1/projects.locations.endpoints/deployModel) for more information.
    /// 
    /// ~&amp;gt; **Note:** To set the map to empty, set &#39;&amp;quot;{}&amp;quot;&#39;, apply, and then remove the field from your config.
    /// </summary>
    [TerraformPropertyName("traffic_split")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TrafficSplit { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "traffic_split");

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformPropertyName("encryption_spec")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointEncryptionSpecBlock>>? EncryptionSpec { get; set; } = new();

    /// <summary>
    /// Block for predict_request_response_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredictRequestResponseLoggingConfig block(s) allowed")]
    [TerraformPropertyName("predict_request_response_logging_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointPredictRequestResponseLoggingConfigBlock>>? PredictRequestResponseLoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for private_service_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    [TerraformPropertyName("private_service_connect_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointPrivateServiceConnectConfigBlock>>? PrivateServiceConnectConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVertexAiEndpointTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Timestamp when this Endpoint was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. DNS of the dedicated endpoint. Will only be populated if dedicatedEndpointEnabled is true. Format: &#39;https://{endpointId}.{region}-{projectNumber}.prediction.vertexai.goog&#39;.
    /// </summary>
    [TerraformPropertyName("dedicated_endpoint_dns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DedicatedEndpointDns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dedicated_endpoint_dns");

    /// <summary>
    /// Output only. The models deployed in this Endpoint. To add or remove DeployedModels use EndpointService.DeployModel and EndpointService.UndeployModel respectively. Models can also be deployed and undeployed using the [Cloud Console](https://console.cloud.google.com/vertex-ai/).
    /// </summary>
    [TerraformPropertyName("deployed_models")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DeployedModels => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "deployed_models");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Used to perform consistent read-modify-write updates. If not set, a blind &amp;quot;overwrite&amp;quot; update happens.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Output only. Resource name of the Model Monitoring job associated with this Endpoint if monitoring is enabled by CreateModelDeploymentMonitoringJob. Format: &#39;projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}&#39;
    /// </summary>
    [TerraformPropertyName("model_deployment_monitoring_job")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModelDeploymentMonitoringJob => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model_deployment_monitoring_job");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. Timestamp when this Endpoint was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
