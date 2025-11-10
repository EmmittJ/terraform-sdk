using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. The Cloud KMS key name to use for encryption.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => WithProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for jobs in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: p{Ll}p{Lo}{0,62} Label values must be between 1 and 63 characters long, and must conform to the following regular expression: [p{Ll}p{Lo}p{N}_-]{0,63} No more than 32 labels can be associated with a given job.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// Optional. The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.
    /// </summary>
    public List<TerraformProperty<string>>? PrerequisiteStepIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("prerequisite_step_ids");
        set => WithProperty("prerequisite_step_ids", value);
    }

    /// <summary>
    /// Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job `goog-dataproc-workflow-step-id` label, and in prerequisiteStepIds field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StepId is required")]
    public required TerraformProperty<string> StepId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("step_id");
        set => WithProperty("step_id", value);
    }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateParametersBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Brief description of the parameter. Must not exceed 1024 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter&#39;s list of field paths. A field path is similar in syntax to a google.protobuf.FieldMask. For example, a field path that references the zone field of a workflow template&#39;s cluster selector would be specified as `placement.clusterSelector.zone`. Also, field paths can reference fields using the following syntax: * Values in maps can be referenced by key: * labels[&#39;key&#39;] * placement.clusterSelector.clusterLabels[&#39;key&#39;] * placement.managedCluster.labels[&#39;key&#39;] * placement.clusterSelector.clusterLabels[&#39;key&#39;] * jobs[&#39;step-id&#39;].labels[&#39;key&#39;] * Jobs in the jobs list can be referenced by step-id: * jobs[&#39;step-id&#39;].hadoopJob.mainJarFileUri * jobs[&#39;step-id&#39;].hiveJob.queryFileUri * jobs[&#39;step-id&#39;].pySparkJob.mainPythonFileUri * jobs[&#39;step-id&#39;].hadoopJob.jarFileUris[0] * jobs[&#39;step-id&#39;].hadoopJob.archiveUris[0] * jobs[&#39;step-id&#39;].hadoopJob.fileUris[0] * jobs[&#39;step-id&#39;].pySparkJob.pythonFileUris[0] * Items in repeated fields can be referenced by a zero-based index: * jobs[&#39;step-id&#39;].sparkJob.args[0] * Other examples: * jobs[&#39;step-id&#39;].hadoopJob.properties[&#39;key&#39;] * jobs[&#39;step-id&#39;].hadoopJob.args[0] * jobs[&#39;step-id&#39;].hiveJob.scriptVariables[&#39;key&#39;] * jobs[&#39;step-id&#39;].hadoopJob.mainJarFileUri * placement.clusterSelector.zone It may not be possible to parameterize maps and repeated fields in their entirety since only individual map values and individual items in repeated fields can be referenced. For example, the following field paths are invalid: - placement.clusterSelector.clusterLabels - jobs[&#39;step-id&#39;].sparkJob.args
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    public List<TerraformProperty<string>>? Fields
    {
        get => GetProperty<List<TerraformProperty<string>>>("fields");
        set => WithProperty("fields", value);
    }

    /// <summary>
    /// Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocWorkflowTemplateTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataproc_workflow_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocWorkflowTemplate : TerraformResource
{
    public GoogleDataprocWorkflowTemplate(string name) : base("google_dataproc_workflow_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Optional. Timeout duration for the DAG of jobs, expressed in seconds (see [JSON representation of duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). The timeout duration must be from 10 minutes (&amp;quot;600s&amp;quot;) to 24 hours (&amp;quot;86400s&amp;quot;). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a [managed cluster](/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.
    /// </summary>
    public TerraformProperty<string>? DagTimeout
    {
        get => GetProperty<TerraformProperty<string>>("dag_timeout");
        set => this.WithProperty("dag_timeout", value);
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
    /// Optional. The labels to associate with this template. These labels will be propagated to all jobs and clusters created by the workflow instance. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be empty, but, if present, must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For `projects.regions.workflowTemplates`, the resource name of the template has the following format: `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}` * For `projects.locations.workflowTemplates`, the resource name of the template has the following format: `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Output only. The current version of this workflow template.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<double>? Version
    {
        get => GetProperty<TerraformProperty<double>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleDataprocWorkflowTemplateEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetProperty<List<GoogleDataprocWorkflowTemplateEncryptionConfigBlock>>("encryption_config");
        set => this.WithProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for jobs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Jobs block(s) required")]
    public List<GoogleDataprocWorkflowTemplateJobsBlock>? Jobs
    {
        get => GetProperty<List<GoogleDataprocWorkflowTemplateJobsBlock>>("jobs");
        set => this.WithProperty("jobs", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataprocWorkflowTemplateParametersBlock>? Parameters
    {
        get => GetProperty<List<GoogleDataprocWorkflowTemplateParametersBlock>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<GoogleDataprocWorkflowTemplatePlacementBlock>? Placement
    {
        get => GetProperty<List<GoogleDataprocWorkflowTemplatePlacementBlock>>("placement");
        set => this.WithProperty("placement", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocWorkflowTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocWorkflowTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time template was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The time template was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
