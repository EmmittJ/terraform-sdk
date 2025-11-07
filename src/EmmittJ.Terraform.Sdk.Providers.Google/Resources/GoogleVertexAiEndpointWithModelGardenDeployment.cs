using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformLiteralProperty<string>? HuggingFaceModelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hugging_face_model_id");
        set => this.WithProperty("hugging_face_model_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;location&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The Model Garden model to deploy.
    /// Format:
    /// &#39;publishers/{publisher}/models/{publisher_model}@{version_id}&#39;, or
    /// &#39;publishers/hf-{hugging-face-author}/models/{hugging-face-model-name}@001&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? PublisherModelName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher_model_name");
        set => this.WithProperty("publisher_model_name", value);
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
