using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleWorkflowsWorkflow.
/// Nesting mode: single
/// </summary>
public class GoogleWorkflowsWorkflowTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_workflows_workflow Terraform resource.
/// Manages a google_workflows_workflow resource.
/// </summary>
public partial class GoogleWorkflowsWorkflow(string name) : TerraformResource("google_workflows_workflow", name)
{
    /// <summary>
    /// Describes the level of platform logging to apply to calls and call responses during
    /// executions of this workflow. If both the workflow and the execution specify a logging level,
    /// the execution level takes precedence. Possible values: [&amp;quot;CALL_LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;LOG_ALL_CALLS&amp;quot;, &amp;quot;LOG_ERRORS_ONLY&amp;quot;, &amp;quot;LOG_NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CallLogLevel
    {
        get => GetArgument<TerraformValue<string>>("call_log_level");
        set => SetArgument("call_log_level", value);
    }

    /// <summary>
    /// The KMS key used to encrypt workflow and execution data.
    /// 
    /// Format: projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// </summary>
    public TerraformValue<string>? CryptoKeyName
    {
        get => GetArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the workflow. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the workflow,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the workflow will fail.
    /// When the field is set to false, deleting the workflow is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// Description of the workflow provided by the user. Must be at most 1000 unicode characters long.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Describes the level of execution history to be stored for this workflow. This configuration
    /// determines how much information about workflow executions is preserved. If not specified,
    /// defaults to EXECUTION_HISTORY_LEVEL_UNSPECIFIED. Possible values: [&amp;quot;EXECUTION_HISTORY_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;EXECUTION_HISTORY_BASIC&amp;quot;, &amp;quot;EXECUTION_HISTORY_DETAILED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ExecutionHistoryLevel
    {
        get => GetArgument<TerraformValue<string>>("execution_history_level");
        set => SetArgument("execution_history_level", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this Workflow.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the Workflow.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the workflow.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Workflow code to be executed. The size limit is 128KB.
    /// </summary>
    public TerraformValue<string>? SourceContents
    {
        get => GetArgument<TerraformValue<string>>("source_contents");
        set => SetArgument("source_contents", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition
    /// as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in
    /// the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// User-defined environment variables associated with this workflow revision. This map has a maximum length of 20. Each string can take up to 4KiB. Keys cannot be empty strings and cannot start with &amp;quot;GOOGLE&amp;quot; or &amp;quot;WORKFLOWS&amp;quot;.
    /// </summary>
    public TerraformMap<string>? UserEnvVars
    {
        get => GetArgument<TerraformMap<string>>("user_env_vars");
        set => SetArgument("user_env_vars", value);
    }

    /// <summary>
    /// The timestamp of when the workflow was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The revision of the workflow. A new one is generated if the service account or source contents is changed.
    /// </summary>
    public TerraformValue<string> RevisionId
        => AsReference("revision_id");

    /// <summary>
    /// State of the workflow deployment.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp of when the workflow was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleWorkflowsWorkflowTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleWorkflowsWorkflowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
