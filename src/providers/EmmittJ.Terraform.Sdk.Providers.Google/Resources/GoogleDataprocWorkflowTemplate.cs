using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocWorkflowTemplateEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. The Cloud KMS key name to use for encryption.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKey { get; set; }

}

/// <summary>
/// Block type for jobs in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocWorkflowTemplateJobsBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: p{Ll}p{Lo}{0,62} Label values must be between 1 and 63 characters long, and must conform to the following regular expression: [p{Ll}p{Lo}p{N}_-]{0,63} No more than 32 labels can be associated with a given job.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Optional. The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.
    /// </summary>
    [TerraformProperty("prerequisite_step_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>
    /// Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job `goog-dataproc-workflow-step-id` label, and in prerequisiteStepIds field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StepId is required")]
    [TerraformProperty("step_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StepId { get; set; }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocWorkflowTemplateParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Brief description of the parameter. Must not exceed 1024 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter&#39;s list of field paths. A field path is similar in syntax to a google.protobuf.FieldMask. For example, a field path that references the zone field of a workflow template&#39;s cluster selector would be specified as `placement.clusterSelector.zone`. Also, field paths can reference fields using the following syntax: * Values in maps can be referenced by key: * labels[&#39;key&#39;] * placement.clusterSelector.clusterLabels[&#39;key&#39;] * placement.managedCluster.labels[&#39;key&#39;] * placement.clusterSelector.clusterLabels[&#39;key&#39;] * jobs[&#39;step-id&#39;].labels[&#39;key&#39;] * Jobs in the jobs list can be referenced by step-id: * jobs[&#39;step-id&#39;].hadoopJob.mainJarFileUri * jobs[&#39;step-id&#39;].hiveJob.queryFileUri * jobs[&#39;step-id&#39;].pySparkJob.mainPythonFileUri * jobs[&#39;step-id&#39;].hadoopJob.jarFileUris[0] * jobs[&#39;step-id&#39;].hadoopJob.archiveUris[0] * jobs[&#39;step-id&#39;].hadoopJob.fileUris[0] * jobs[&#39;step-id&#39;].pySparkJob.pythonFileUris[0] * Items in repeated fields can be referenced by a zero-based index: * jobs[&#39;step-id&#39;].sparkJob.args[0] * Other examples: * jobs[&#39;step-id&#39;].hadoopJob.properties[&#39;key&#39;] * jobs[&#39;step-id&#39;].hadoopJob.args[0] * jobs[&#39;step-id&#39;].hiveJob.scriptVariables[&#39;key&#39;] * jobs[&#39;step-id&#39;].hadoopJob.mainJarFileUri * placement.clusterSelector.zone It may not be possible to parameterize maps and repeated fields in their entirety since only individual map values and individual items in repeated fields can be referenced. For example, the following field paths are invalid: - placement.clusterSelector.clusterLabels - jobs[&#39;step-id&#39;].sparkJob.args
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [TerraformProperty("fields")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Fields { get; set; }

    /// <summary>
    /// Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocWorkflowTemplatePlacementBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocWorkflowTemplateTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_dataproc_workflow_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocWorkflowTemplate : TerraformResource
{
    public GoogleDataprocWorkflowTemplate(string name) : base("google_dataproc_workflow_template", name)
    {
    }

    /// <summary>
    /// Optional. Timeout duration for the DAG of jobs, expressed in seconds (see [JSON representation of duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). The timeout duration must be from 10 minutes (&amp;quot;600s&amp;quot;) to 24 hours (&amp;quot;86400s&amp;quot;). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a [managed cluster](/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.
    /// </summary>
    [TerraformProperty("dag_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DagTimeout { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. The labels to associate with this template. These labels will be propagated to all jobs and clusters created by the workflow instance. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be empty, but, if present, must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For `projects.regions.workflowTemplates`, the resource name of the template has the following format: `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}` * For `projects.locations.workflowTemplates`, the resource name of the template has the following format: `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Output only. The current version of this workflow template.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Version { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public partial TerraformList<TerraformBlock<GoogleDataprocWorkflowTemplateEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for jobs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Jobs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Jobs block(s) required")]
    [TerraformProperty("jobs")]
    public partial TerraformList<TerraformBlock<GoogleDataprocWorkflowTemplateJobsBlock>>? Jobs { get; set; }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("parameters")]
    public partial TerraformList<TerraformBlock<GoogleDataprocWorkflowTemplateParametersBlock>>? Parameters { get; set; }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Placement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    [TerraformProperty("placement")]
    public partial TerraformList<TerraformBlock<GoogleDataprocWorkflowTemplatePlacementBlock>>? Placement { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataprocWorkflowTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The time template was created.
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
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The time template was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
