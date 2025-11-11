using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for deploy_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock
{
    /// <summary>
    /// If true, enable the QMT fast tryout feature for this model if possible.
    /// </summary>
    [TerraformPropertyName("fast_tryout_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FastTryoutEnabled { get; set; }

    /// <summary>
    /// System labels for Model Garden deployments.
    /// These labels are managed by Google and for tracking purposes only.
    /// </summary>
    [TerraformPropertyName("system_labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SystemLabels { get; set; }

}

/// <summary>
/// Block type for endpoint_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock
{
    /// <summary>
    /// If true, the endpoint will be exposed through a dedicated
    /// DNS [Endpoint.dedicated_endpoint_dns]. Your request to the dedicated DNS
    /// will be isolated from other users&#39; traffic and will have better
    /// performance and reliability. Note: Once you enabled dedicated endpoint,
    /// you won&#39;t be able to send request to the shared DNS
    /// {region}-aiplatform.googleapis.com. The limitations will be removed soon.
    /// </summary>
    [TerraformPropertyName("dedicated_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DedicatedEndpointEnabled { get; set; }

    /// <summary>
    /// The user-specified display name of the endpoint. If not set, a
    /// default name will be used.
    /// </summary>
    [TerraformPropertyName("endpoint_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EndpointDisplayName { get; set; }

}

/// <summary>
/// Block type for model_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock
{
    /// <summary>
    /// Whether the user accepts the End User License Agreement (EULA)
    /// for the model.
    /// </summary>
    [TerraformPropertyName("accept_eula")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AcceptEula { get; set; }

    /// <summary>
    /// The Hugging Face read access token used to access the model
    /// artifacts of gated models.
    /// </summary>
    [TerraformPropertyName("hugging_face_access_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HuggingFaceAccessToken { get; set; }

    /// <summary>
    /// If true, the model will deploy with a cached version instead of directly
    /// downloading the model artifacts from Hugging Face. This is suitable for
    /// VPC-SC users with limited internet access.
    /// </summary>
    [TerraformPropertyName("hugging_face_cache_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HuggingFaceCacheEnabled { get; set; }

    /// <summary>
    /// The user-specified display name of the uploaded model. If not
    /// set, a default name will be used.
    /// </summary>
    [TerraformPropertyName("model_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ModelDisplayName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_vertex_ai_endpoint_with_model_garden_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiEndpointWithModelGardenDeployment : TerraformResource
{
    public GoogleVertexAiEndpointWithModelGardenDeployment(string name) : base("google_vertex_ai_endpoint_with_model_garden_deployment", name)
    {
    }

    /// <summary>
    /// The Hugging Face model to deploy.
    /// Format: Hugging Face model ID like &#39;google/gemma-2-2b-it&#39;.
    /// </summary>
    [TerraformPropertyName("hugging_face_model_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HuggingFaceModelId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource ID segment making up resource &#39;location&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The Model Garden model to deploy.
    /// Format:
    /// &#39;publishers/{publisher}/models/{publisher_model}@{version_id}&#39;, or
    /// &#39;publishers/hf-{hugging-face-author}/models/{hugging-face-model-name}@001&#39;.
    /// </summary>
    [TerraformPropertyName("publisher_model_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublisherModelName { get; set; }

    /// <summary>
    /// Block for deploy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeployConfig block(s) allowed")]
    [TerraformPropertyName("deploy_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock>>? DeployConfig { get; set; }

    /// <summary>
    /// Block for endpoint_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfig block(s) allowed")]
    [TerraformPropertyName("endpoint_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock>>? EndpointConfig { get; set; }

    /// <summary>
    /// Block for model_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelConfig block(s) allowed")]
    [TerraformPropertyName("model_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock>>? ModelConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The display name assigned to the model deployed to the endpoint.
    /// This is not required to delete the resource but is used for debug logging.
    /// </summary>
    [TerraformPropertyName("deployed_model_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeployedModelDisplayName => new TerraformReference(this, "deployed_model_display_name");

    /// <summary>
    /// Output only. The unique numeric ID that Vertex AI assigns to the model at the time it is deployed to the endpoint.
    /// It is required to undeploy the model from the endpoint during resource deletion as described in
    /// https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.endpoints/undeployModel.
    /// </summary>
    [TerraformPropertyName("deployed_model_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeployedModelId => new TerraformReference(this, "deployed_model_id");

    /// <summary>
    /// Resource ID segment making up resource &#39;endpoint&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

}
