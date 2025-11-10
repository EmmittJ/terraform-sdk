using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for deploy_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock : TerraformBlock
{
    /// <summary>
    /// If true, enable the QMT fast tryout feature for this model if possible.
    /// </summary>
    public TerraformProperty<bool>? FastTryoutEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fast_tryout_enabled");
        set => WithProperty("fast_tryout_enabled", value);
    }

    /// <summary>
    /// System labels for Model Garden deployments.
    /// These labels are managed by Google and for tracking purposes only.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SystemLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("system_labels");
        set => WithProperty("system_labels", value);
    }

}

/// <summary>
/// Block type for endpoint_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// If true, the endpoint will be exposed through a dedicated
    /// DNS [Endpoint.dedicated_endpoint_dns]. Your request to the dedicated DNS
    /// will be isolated from other users&#39; traffic and will have better
    /// performance and reliability. Note: Once you enabled dedicated endpoint,
    /// you won&#39;t be able to send request to the shared DNS
    /// {region}-aiplatform.googleapis.com. The limitations will be removed soon.
    /// </summary>
    public TerraformProperty<bool>? DedicatedEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dedicated_endpoint_enabled");
        set => WithProperty("dedicated_endpoint_enabled", value);
    }

    /// <summary>
    /// The user-specified display name of the endpoint. If not set, a
    /// default name will be used.
    /// </summary>
    public TerraformProperty<string>? EndpointDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_display_name");
        set => WithProperty("endpoint_display_name", value);
    }

}

/// <summary>
/// Block type for model_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether the user accepts the End User License Agreement (EULA)
    /// for the model.
    /// </summary>
    public TerraformProperty<bool>? AcceptEula
    {
        get => GetProperty<TerraformProperty<bool>>("accept_eula");
        set => WithProperty("accept_eula", value);
    }

    /// <summary>
    /// The Hugging Face read access token used to access the model
    /// artifacts of gated models.
    /// </summary>
    public TerraformProperty<string>? HuggingFaceAccessToken
    {
        get => GetProperty<TerraformProperty<string>>("hugging_face_access_token");
        set => WithProperty("hugging_face_access_token", value);
    }

    /// <summary>
    /// If true, the model will deploy with a cached version instead of directly
    /// downloading the model artifacts from Hugging Face. This is suitable for
    /// VPC-SC users with limited internet access.
    /// </summary>
    public TerraformProperty<bool>? HuggingFaceCacheEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hugging_face_cache_enabled");
        set => WithProperty("hugging_face_cache_enabled", value);
    }

    /// <summary>
    /// The user-specified display name of the uploaded model. If not
    /// set, a default name will be used.
    /// </summary>
    public TerraformProperty<string>? ModelDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("model_display_name");
        set => WithProperty("model_display_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_vertex_ai_endpoint_with_model_garden_deployment resource.
/// </summary>
public class GoogleVertexAiEndpointWithModelGardenDeployment : TerraformResource
{
    public GoogleVertexAiEndpointWithModelGardenDeployment(string name) : base("google_vertex_ai_endpoint_with_model_garden_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("deployed_model_display_name");
        this.DeclareOutput("deployed_model_id");
        this.DeclareOutput("endpoint");
    }

    /// <summary>
    /// The Hugging Face model to deploy.
    /// Format: Hugging Face model ID like &#39;google/gemma-2-2b-it&#39;.
    /// </summary>
    public TerraformProperty<string>? HuggingFaceModelId
    {
        get => GetProperty<TerraformProperty<string>>("hugging_face_model_id");
        set => this.WithProperty("hugging_face_model_id", value);
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
    /// Resource ID segment making up resource &#39;location&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The Model Garden model to deploy.
    /// Format:
    /// &#39;publishers/{publisher}/models/{publisher_model}@{version_id}&#39;, or
    /// &#39;publishers/hf-{hugging-face-author}/models/{hugging-face-model-name}@001&#39;.
    /// </summary>
    public TerraformProperty<string>? PublisherModelName
    {
        get => GetProperty<TerraformProperty<string>>("publisher_model_name");
        set => this.WithProperty("publisher_model_name", value);
    }

    /// <summary>
    /// Block for deploy_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeployConfig block(s) allowed")]
    public List<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock>? DeployConfig
    {
        get => GetProperty<List<GoogleVertexAiEndpointWithModelGardenDeploymentDeployConfigBlock>>("deploy_config");
        set => this.WithProperty("deploy_config", value);
    }

    /// <summary>
    /// Block for endpoint_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfig block(s) allowed")]
    public List<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock>? EndpointConfig
    {
        get => GetProperty<List<GoogleVertexAiEndpointWithModelGardenDeploymentEndpointConfigBlock>>("endpoint_config");
        set => this.WithProperty("endpoint_config", value);
    }

    /// <summary>
    /// Block for model_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelConfig block(s) allowed")]
    public List<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock>? ModelConfig
    {
        get => GetProperty<List<GoogleVertexAiEndpointWithModelGardenDeploymentModelConfigBlock>>("model_config");
        set => this.WithProperty("model_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiEndpointWithModelGardenDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The display name assigned to the model deployed to the endpoint.
    /// This is not required to delete the resource but is used for debug logging.
    /// </summary>
    public TerraformExpression DeployedModelDisplayName => this["deployed_model_display_name"];

    /// <summary>
    /// Output only. The unique numeric ID that Vertex AI assigns to the model at the time it is deployed to the endpoint.
    /// It is required to undeploy the model from the endpoint during resource deletion as described in
    /// https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.endpoints/undeployModel.
    /// </summary>
    public TerraformExpression DeployedModelId => this["deployed_model_id"];

    /// <summary>
    /// Resource ID segment making up resource &#39;endpoint&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

}
