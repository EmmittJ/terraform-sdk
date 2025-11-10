using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleWorkflowsWorkflowTimeoutsBlock : TerraformBlock
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
/// Manages a google_workflows_workflow resource.
/// </summary>
public class GoogleWorkflowsWorkflow : TerraformResource
{
    public GoogleWorkflowsWorkflow(string name) : base("google_workflows_workflow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("revision_id");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Describes the level of platform logging to apply to calls and call responses during
    /// executions of this workflow. If both the workflow and the execution specify a logging level,
    /// the execution level takes precedence. Possible values: [&amp;quot;CALL_LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;LOG_ALL_CALLS&amp;quot;, &amp;quot;LOG_ERRORS_ONLY&amp;quot;, &amp;quot;LOG_NONE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CallLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("call_log_level");
        set => this.WithProperty("call_log_level", value);
    }

    /// <summary>
    /// The KMS key used to encrypt workflow and execution data.
    /// 
    /// Format: projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// </summary>
    public TerraformProperty<string>? CryptoKeyName
    {
        get => GetProperty<TerraformProperty<string>>("crypto_key_name");
        set => this.WithProperty("crypto_key_name", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the workflow. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the workflow,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the workflow will fail.
    /// When the field is set to false, deleting the workflow is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// Description of the workflow provided by the user. Must be at most 1000 unicode characters long.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Describes the level of execution history to be stored for this workflow. This configuration
    /// determines how much information about workflow executions is preserved. If not specified,
    /// defaults to EXECUTION_HISTORY_LEVEL_UNSPECIFIED. Possible values: [&amp;quot;EXECUTION_HISTORY_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;EXECUTION_HISTORY_BASIC&amp;quot;, &amp;quot;EXECUTION_HISTORY_DETAILED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ExecutionHistoryLevel
    {
        get => GetProperty<TerraformProperty<string>>("execution_history_level");
        set => this.WithProperty("execution_history_level", value);
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
    /// A set of key/value label pairs to assign to this Workflow.
    /// 
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
    /// Name of the Workflow.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The region of the workflow.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Name of the service account associated with the latest workflow version. This service
    /// account represents the identity of the workflow and determines what permissions the workflow has.
    /// Format: projects/{project}/serviceAccounts/{account} or {account}.
    /// Using - as a wildcard for the {project} or not providing one at all will infer the project from the account.
    /// The {account} value can be the email address or the unique_id of the service account.
    /// If not provided, workflow will use the project&#39;s default service account.
    /// Modifying this field for an existing workflow results in a new workflow revision.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Workflow code to be executed. The size limit is 128KB.
    /// </summary>
    public TerraformProperty<string>? SourceContents
    {
        get => GetProperty<TerraformProperty<string>>("source_contents");
        set => this.WithProperty("source_contents", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition
    /// as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in
    /// the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// User-defined environment variables associated with this workflow revision. This map has a maximum length of 20. Each string can take up to 4KiB. Keys cannot be empty strings and cannot start with &amp;quot;GOOGLE&amp;quot; or &amp;quot;WORKFLOWS&amp;quot;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? UserEnvVars
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("user_env_vars");
        set => this.WithProperty("user_env_vars", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleWorkflowsWorkflowTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleWorkflowsWorkflowTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the workflow was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The revision of the workflow. A new one is generated if the service account or source contents is changed.
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// State of the workflow deployment.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp of when the workflow was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
