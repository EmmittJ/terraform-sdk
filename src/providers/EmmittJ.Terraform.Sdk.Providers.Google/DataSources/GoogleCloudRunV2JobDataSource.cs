using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_run_v2_job.
/// </summary>
public class GoogleCloudRunV2JobDataSource : TerraformDataSource
{
    public GoogleCloudRunV2JobDataSource(string name) : base("google_cloud_run_v2_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the cloud run job
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Name of the Job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected on new resources.
    /// All system annotations in v1 now have a corresponding field in v2 Job.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Annotations => new TerraformReference(this, "annotations");

    /// <summary>
    /// Settings for the Binary Authorization feature.
    /// </summary>
    [TerraformPropertyName("binary_authorization")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BinaryAuthorization => new TerraformReference(this, "binary_authorization");

    /// <summary>
    /// Arbitrary identifier for the API client.
    /// </summary>
    [TerraformPropertyName("client")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Client => new TerraformReference(this, "client");

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    [TerraformPropertyName("client_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientVersion => new TerraformReference(this, "client_version");

    /// <summary>
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Job does not reach its desired state. See comments in reconciling for additional information on &#39;reconciliation&#39; process in Cloud Run.
    /// </summary>
    [TerraformPropertyName("conditions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Conditions => new TerraformReference(this, "conditions");

    /// <summary>
    /// The creation time.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    [TerraformPropertyName("creator")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Creator => new TerraformReference(this, "creator");

    /// <summary>
    /// The deletion time.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeleteTime => new TerraformReference(this, "delete_time");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the job. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the job,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the job will fail.
    /// When the field is set to false, deleting the job is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// Number of executions created for this job.
    /// </summary>
    [TerraformPropertyName("execution_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ExecutionCount => new TerraformReference(this, "execution_count");

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpireTime => new TerraformReference(this, "expire_time");

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Generation => new TerraformReference(this, "generation");

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 Job.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    [TerraformPropertyName("last_modifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifier => new TerraformReference(this, "last_modifier");

    /// <summary>
    /// Name of the last created execution.
    /// </summary>
    [TerraformPropertyName("latest_created_execution")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LatestCreatedExecution => new TerraformReference(this, "latest_created_execution");

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("launch_stage")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LaunchStage => new TerraformReference(this, "launch_stage");

    /// <summary>
    /// The generation of this Job. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    [TerraformPropertyName("observed_generation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObservedGeneration => new TerraformReference(this, "observed_generation");

    /// <summary>
    /// Returns true if the Job is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new Job is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Job to the desired state. This process is called reconciliation. While reconciliation is in process, observedGeneration and latest_succeeded_execution, will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the state matches the Job, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: observedGeneration and generation, latest_succeeded_execution and latestCreatedExecution.
    /// 
    /// If reconciliation failed, observedGeneration and latest_succeeded_execution will have the state of the last succeeded execution or empty for newly created Job. Additional information on the failure can be found in terminalCondition and conditions
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// The template used to create executions for this Job.
    /// </summary>
    [TerraformPropertyName("template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Template => new TerraformReference(this, "template");

    /// <summary>
    /// The Condition of this Job, containing its readiness status, and detailed error information in case it did not reach the desired state
    /// </summary>
    [TerraformPropertyName("terminal_condition")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TerminalCondition => new TerraformReference(this, "terminal_condition");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// The last-modified time.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
