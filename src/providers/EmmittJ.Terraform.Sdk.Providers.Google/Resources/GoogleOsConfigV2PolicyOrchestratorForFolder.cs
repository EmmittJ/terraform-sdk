using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for orchestrated_resource in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock() : TerraformBlock("orchestrated_resource")
{
    /// <summary>
    /// ID of the resource to be used while generating set of affected resources.
    /// 
    /// For UPSERT action the value is auto-generated during PolicyOrchestrator
    /// creation when not set. When the value is set it should following next
    /// restrictions:
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the project.
    /// 
    /// For DELETE action, ID must be specified explicitly during
    /// PolicyOrchestrator creation.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

}

/// <summary>
/// Block type for orchestration_scope in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock() : TerraformBlock("orchestration_scope")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_os_config_v2_policy_orchestrator_for_folder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOsConfigV2PolicyOrchestratorForFolder : TerraformResource
{
    public GoogleOsConfigV2PolicyOrchestratorForFolder(string name) : base("google_os_config_v2_policy_orchestrator_for_folder", name)
    {
    }

    /// <summary>
    /// Action to be done by the orchestrator in
    /// &#39;projects/{project_id}/zones/{zone_id}&#39; locations defined by the
    /// &#39;orchestration_scope&#39;. Allowed values:
    /// - &#39;UPSERT&#39; - Orchestrator will create or update target resources.
    /// - &#39;DELETE&#39; - Orchestrator will delete target resources, if they exist
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// Freeform text describing the purpose of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The parent resource name in the form of &#39;folders/{folder_id}/locations/global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    [TerraformProperty("folder_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FolderId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The logical identifier of the policy orchestrator, with the following
    /// restrictions:
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the parent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyOrchestratorId is required")]
    [TerraformProperty("policy_orchestrator_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyOrchestratorId { get; set; }

    /// <summary>
    /// State of the orchestrator. Can be updated to change orchestrator behaviour.
    /// Allowed values:
    /// - &#39;ACTIVE&#39; - orchestrator is actively looking for actions to be taken.
    /// - &#39;STOPPED&#39; - orchestrator won&#39;t make any changes.
    /// 
    /// Note: There might be more states added in the future. We use string here
    /// instead of an enum, to avoid the need of propagating new states to all the
    /// client code.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// Block for orchestrated_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrchestratedResource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OrchestratedResource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestratedResource block(s) allowed")]
    [TerraformProperty("orchestrated_resource")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock> OrchestratedResource { get; set; } = new();

    /// <summary>
    /// Block for orchestration_scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestrationScope block(s) allowed")]
    [TerraformProperty("orchestration_scope")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock> OrchestrationScope { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Timestamp when the policy orchestrator resource was created.
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
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Identifier. In form of
    /// * &#39;organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Describes the state of the orchestration process.
    /// </summary>
    [TerraformProperty("orchestration_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OrchestrationState { get; }

    /// <summary>
    /// Set to true, if the there are ongoing changes being applied by the
    /// orchestrator.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Timestamp when the policy orchestrator resource was last modified.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
