using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for orchestrated_resource in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock : TerraformBlock
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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

}

/// <summary>
/// Block type for orchestration_scope in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock : TerraformBlock
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
/// Manages a google_os_config_v2_policy_orchestrator_for_folder resource.
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolder : TerraformResource
{
    public GoogleOsConfigV2PolicyOrchestratorForFolder(string name) : base("google_os_config_v2_policy_orchestrator_for_folder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("orchestration_state");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Action to be done by the orchestrator in
    /// &#39;projects/{project_id}/zones/{zone_id}&#39; locations defined by the
    /// &#39;orchestration_scope&#39;. Allowed values:
    /// - &#39;UPSERT&#39; - Orchestrator will create or update target resources.
    /// - &#39;DELETE&#39; - Orchestrator will delete target resources, if they exist
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Freeform text describing the purpose of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The parent resource name in the form of &#39;folders/{folder_id}/locations/global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformProperty<string> FolderId
    {
        get => GetProperty<TerraformProperty<string>>("folder_id");
        set => this.WithProperty("folder_id", value);
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
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

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
    public required TerraformProperty<string> PolicyOrchestratorId
    {
        get => GetProperty<TerraformProperty<string>>("policy_orchestrator_id");
        set => this.WithProperty("policy_orchestrator_id", value);
    }

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
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// Block for orchestrated_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OrchestratedResource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestratedResource block(s) allowed")]
    public List<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock>? OrchestratedResource
    {
        get => GetProperty<List<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock>>("orchestrated_resource");
        set => this.WithProperty("orchestrated_resource", value);
    }

    /// <summary>
    /// Block for orchestration_scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestrationScope block(s) allowed")]
    public List<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock>? OrchestrationScope
    {
        get => GetProperty<List<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock>>("orchestration_scope");
        set => this.WithProperty("orchestration_scope", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Timestamp when the policy orchestrator resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. In form of
    /// * &#39;organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Describes the state of the orchestration process.
    /// </summary>
    public TerraformExpression OrchestrationState => this["orchestration_state"];

    /// <summary>
    /// Set to true, if the there are ongoing changes being applied by the
    /// orchestrator.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Timestamp when the policy orchestrator resource was last modified.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
