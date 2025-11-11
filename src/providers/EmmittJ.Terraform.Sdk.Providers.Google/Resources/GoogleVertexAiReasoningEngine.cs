using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiReasoningEngineEncryptionSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource.
    /// Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiReasoningEngineSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. The OSS agent framework used to develop the agent.
    /// </summary>
    [TerraformProperty("agent_framework")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AgentFramework { get; set; }

    /// <summary>
    /// Optional. Declarations for object class methods in OpenAPI specification format.
    /// </summary>
    [TerraformProperty("class_methods")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClassMethods { get; set; }

    /// <summary>
    /// Optional. The service account that the Reasoning Engine artifact runs as.
    /// It should have &amp;quot;roles/storage.objectViewer&amp;quot; for reading the user project&#39;s
    /// Cloud Storage and &amp;quot;roles/aiplatform.user&amp;quot; for using Vertex extensions.
    /// If not specified, the Vertex AI Reasoning Engine service Agent in the project will be used.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceAccount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiReasoningEngineTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_vertex_ai_reasoning_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVertexAiReasoningEngine : TerraformResource
{
    public GoogleVertexAiReasoningEngine(string name) : base("google_vertex_ai_reasoning_engine", name)
    {
    }

    /// <summary>
    /// The description of the ReasoningEngine.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the ReasoningEngine.
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
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region of the reasoning engine. eg us-central1
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformProperty("encryption_spec")]
    public TerraformList<TerraformBlock<GoogleVertexAiReasoningEngineEncryptionSpecBlock>>? EncryptionSpec { get; set; }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    [TerraformProperty("spec")]
    public TerraformList<TerraformBlock<GoogleVertexAiReasoningEngineSpecBlock>>? Spec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleVertexAiReasoningEngineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The generated name of the ReasoningEngine, in the format
    /// &#39;projects/{project}/locations/{location}/reasoningEngines/{reasoningEngine}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
