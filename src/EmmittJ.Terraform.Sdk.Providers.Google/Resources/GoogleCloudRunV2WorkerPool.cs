using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_run_v2_worker_pool resource.
/// </summary>
public class GoogleCloudRunV2WorkerPool : TerraformResource
{
    public GoogleCloudRunV2WorkerPool(string name) : base("google_cloud_run_v2_worker_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("conditions");
        this.DeclareOutput("create_time");
        this.DeclareOutput("creator");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("generation");
        this.DeclareOutput("instance_split_statuses");
        this.DeclareOutput("last_modifier");
        this.DeclareOutput("latest_created_revision");
        this.DeclareOutput("latest_ready_revision");
        this.DeclareOutput("observed_generation");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("terminal_condition");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected in new resources.
    /// All system annotations in v1 now have a corresponding field in v2 WorkerPool.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Annotations
    {
        get => GetProperty<TerraformMapProperty<string>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Arbitrary identifier for the API client.
    /// </summary>
    public TerraformProperty<string>? Client
    {
        get => GetProperty<TerraformProperty<string>>("client");
        set => this.WithProperty("client", value);
    }

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    public TerraformProperty<string>? ClientVersion
    {
        get => GetProperty<TerraformProperty<string>>("client_version");
        set => this.WithProperty("client_version", value);
    }

    /// <summary>
    /// One or more custom audiences that you want this worker pool to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests.
    /// For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
    /// </summary>
    public TerraformProperty<List<string>>? CustomAudiences
    {
        get => GetProperty<TerraformProperty<List<string>>>("custom_audiences");
        set => this.WithProperty("custom_audiences", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the service. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the service,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the WorkerPool will fail.
    /// When the field is set to false, deleting the WorkerPool is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// User-provided description of the WorkerPool. This field currently has a 512-character limit.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with  &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 WorkerPool.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LaunchStage
    {
        get => GetProperty<TerraformProperty<string>>("launch_stage");
        set => this.WithProperty("launch_stage", value);
    }

    /// <summary>
    /// The location of the cloud run worker pool
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the WorkerPool.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the WorkerPool does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression Conditions => this["conditions"];

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    public TerraformExpression Creator => this["creator"];

    /// <summary>
    /// The deletion time.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformExpression Generation => this["generation"];

    /// <summary>
    /// Detailed status information for corresponding instance splits. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression InstanceSplitStatuses => this["instance_split_statuses"];

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    public TerraformExpression LastModifier => this["last_modifier"];

    /// <summary>
    /// Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression LatestCreatedRevision => this["latest_created_revision"];

    /// <summary>
    /// Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression LatestReadyRevision => this["latest_ready_revision"];

    /// <summary>
    /// The generation of this WorkerPool currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformExpression ObservedGeneration => this["observed_generation"];

    /// <summary>
    /// Returns true if the WorkerPool is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new WorkerPool is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the WorkerPool to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the WorkerPool, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.
    /// 
    /// If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created WorkerPools. Additional information on the failure can be found in terminalCondition and conditions.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The Condition of this WorkerPool, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformExpression TerminalCondition => this["terminal_condition"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
