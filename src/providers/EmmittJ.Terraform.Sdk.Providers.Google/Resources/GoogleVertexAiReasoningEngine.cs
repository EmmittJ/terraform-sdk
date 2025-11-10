using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource.
    /// Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlock : TerraformBlock
{
    /// <summary>
    /// Optional. The OSS agent framework used to develop the agent.
    /// </summary>
    public TerraformProperty<string>? AgentFramework
    {
        get => GetProperty<TerraformProperty<string>>("agent_framework");
        set => WithProperty("agent_framework", value);
    }

    /// <summary>
    /// Optional. Declarations for object class methods in OpenAPI specification format.
    /// </summary>
    public TerraformProperty<string>? ClassMethods
    {
        get => GetProperty<TerraformProperty<string>>("class_methods");
        set => WithProperty("class_methods", value);
    }

    /// <summary>
    /// Optional. The service account that the Reasoning Engine artifact runs as.
    /// It should have &amp;quot;roles/storage.objectViewer&amp;quot; for reading the user project&#39;s
    /// Cloud Storage and &amp;quot;roles/aiplatform.user&amp;quot; for using Vertex extensions.
    /// If not specified, the Vertex AI Reasoning Engine service Agent in the project will be used.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => WithProperty("service_account", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiReasoningEngineTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_vertex_ai_reasoning_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiReasoningEngine : TerraformResource
{
    public GoogleVertexAiReasoningEngine(string name) : base("google_vertex_ai_reasoning_engine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("name");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The description of the ReasoningEngine.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the ReasoningEngine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the reasoning engine. eg us-central1
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public List<GoogleVertexAiReasoningEngineEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetProperty<List<GoogleVertexAiReasoningEngineEncryptionSpecBlock>>("encryption_spec");
        set => this.WithProperty("encryption_spec", value);
    }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public List<GoogleVertexAiReasoningEngineSpecBlock>? Spec
    {
        get => GetProperty<List<GoogleVertexAiReasoningEngineSpecBlock>>("spec");
        set => this.WithProperty("spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiReasoningEngineTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiReasoningEngineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The generated name of the ReasoningEngine, in the format
    /// &#39;projects/{project}/locations/{location}/reasoningEngines/{reasoningEngine}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
