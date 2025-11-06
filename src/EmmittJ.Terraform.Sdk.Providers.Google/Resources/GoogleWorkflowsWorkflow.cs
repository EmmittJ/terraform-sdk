using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? CallLogLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("call_log_level")?.Value;
        set => this.WithProperty("call_log_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The KMS key used to encrypt workflow and execution data.
    /// 
    /// Format: projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// </summary>
    public string? CryptoKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("crypto_key_name")?.Value;
        set => this.WithProperty("crypto_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the workflow. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the workflow,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the workflow will fail.
    /// When the field is set to false, deleting the workflow is allowed.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Description of the workflow provided by the user. Must be at most 1000 unicode characters long.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Describes the level of execution history to be stored for this workflow. This configuration
    /// determines how much information about workflow executions is preserved. If not specified,
    /// defaults to EXECUTION_HISTORY_LEVEL_UNSPECIFIED. Possible values: [&amp;quot;EXECUTION_HISTORY_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;EXECUTION_HISTORY_BASIC&amp;quot;, &amp;quot;EXECUTION_HISTORY_DETAILED&amp;quot;]
    /// </summary>
    public string? ExecutionHistoryLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_history_level")?.Value;
        set => this.WithProperty("execution_history_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this Workflow.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Name of the Workflow.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region of the workflow.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Workflow code to be executed. The size limit is 128KB.
    /// </summary>
    public string? SourceContents
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_contents")?.Value;
        set => this.WithProperty("source_contents", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition
    /// as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in
    /// the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// User-defined environment variables associated with this workflow revision. This map has a maximum length of 20. Each string can take up to 4KiB. Keys cannot be empty strings and cannot start with &amp;quot;GOOGLE&amp;quot; or &amp;quot;WORKFLOWS&amp;quot;.
    /// </summary>
    public Dictionary<string, string>? UserEnvVars
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("user_env_vars")?.Value;
        set => this.WithProperty("user_env_vars", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
