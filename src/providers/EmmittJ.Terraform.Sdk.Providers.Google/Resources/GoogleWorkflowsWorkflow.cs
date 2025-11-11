using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleWorkflowsWorkflowTimeoutsBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_workflows_workflow resource.
/// </summary>
public class GoogleWorkflowsWorkflow : TerraformResource
{
    public GoogleWorkflowsWorkflow(string name) : base("google_workflows_workflow", name)
    {
    }

    /// <summary>
    /// Describes the level of platform logging to apply to calls and call responses during
    /// executions of this workflow. If both the workflow and the execution specify a logging level,
    /// the execution level takes precedence. Possible values: [&amp;quot;CALL_LOG_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;LOG_ALL_CALLS&amp;quot;, &amp;quot;LOG_ERRORS_ONLY&amp;quot;, &amp;quot;LOG_NONE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("call_log_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CallLogLevel { get; set; }

    /// <summary>
    /// The KMS key used to encrypt workflow and execution data.
    /// 
    /// Format: projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey}
    /// </summary>
    [TerraformPropertyName("crypto_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CryptoKeyName { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the workflow. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the workflow,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the workflow will fail.
    /// When the field is set to false, deleting the workflow is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// Description of the workflow provided by the user. Must be at most 1000 unicode characters long.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// Describes the level of execution history to be stored for this workflow. This configuration
    /// determines how much information about workflow executions is preserved. If not specified,
    /// defaults to EXECUTION_HISTORY_LEVEL_UNSPECIFIED. Possible values: [&amp;quot;EXECUTION_HISTORY_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;EXECUTION_HISTORY_BASIC&amp;quot;, &amp;quot;EXECUTION_HISTORY_DETAILED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("execution_history_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionHistoryLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A set of key/value label pairs to assign to this Workflow.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the Workflow.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The region of the workflow.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Name of the service account associated with the latest workflow version. This service
    /// account represents the identity of the workflow and determines what permissions the workflow has.
    /// Format: projects/{project}/serviceAccounts/{account} or {account}.
    /// Using - as a wildcard for the {project} or not providing one at all will infer the project from the account.
    /// The {account} value can be the email address or the unique_id of the service account.
    /// If not provided, workflow will use the project&#39;s default service account.
    /// Modifying this field for an existing workflow results in a new workflow revision.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccount { get; set; } = default!;

    /// <summary>
    /// Workflow code to be executed. The size limit is 128KB.
    /// </summary>
    [TerraformPropertyName("source_contents")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceContents { get; set; }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition
    /// as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in
    /// the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// User-defined environment variables associated with this workflow revision. This map has a maximum length of 20. Each string can take up to 4KiB. Keys cannot be empty strings and cannot start with &amp;quot;GOOGLE&amp;quot; or &amp;quot;WORKFLOWS&amp;quot;.
    /// </summary>
    [TerraformPropertyName("user_env_vars")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? UserEnvVars { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleWorkflowsWorkflowTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp of when the workflow was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The revision of the workflow. A new one is generated if the service account or source contents is changed.
    /// </summary>
    [TerraformPropertyName("revision_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RevisionId => new TerraformReference(this, "revision_id");

    /// <summary>
    /// State of the workflow deployment.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The timestamp of when the workflow was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
