using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloud_run_v2_service Terraform data source.
/// Retrieves information about a google_cloud_run_v2_service.
/// </summary>
public partial class GoogleCloudRunV2ServiceDataSource(string name) : TerraformDataSource("google_cloud_run_v2_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the cloud run service
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects.
    /// 
    /// Cloud Run API v2 does not support annotations with &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected in new resources.
    /// All system annotations in v1 now have a corresponding field in v2 Service.
    /// 
    /// This field follows Kubernetes annotations&#39; namespacing, limits, and rules.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string> Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// Settings for the Binary Authorization feature.
    /// </summary>
    public TerraformList<TerraformMap<object>> BinaryAuthorization
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "binary_authorization").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for building a Cloud Run function.
    /// </summary>
    public TerraformList<TerraformMap<object>> BuildConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "build_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Arbitrary identifier for the API client.
    /// </summary>
    public TerraformValue<string> Client
    {
        get => new TerraformReference<string>(this, "client");
    }

    /// <summary>
    /// Arbitrary version identifier for the API client.
    /// </summary>
    public TerraformValue<string> ClientVersion
    {
        get => new TerraformReference<string>(this, "client_version");
    }

    /// <summary>
    /// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> Conditions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "conditions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The creation time.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Email address of the authenticated creator.
    /// </summary>
    public TerraformValue<string> Creator
    {
        get => new TerraformReference<string>(this, "creator");
    }

    /// <summary>
    /// One or more custom audiences that you want this service to support. Specify each custom audience as the full URL in a string. The custom audiences are encoded in the token and used to authenticate requests.
    /// For more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
    /// </summary>
    public TerraformList<string> CustomAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_audiences").ResolveNodes(ctx));
    }

    /// <summary>
    /// Disables public resolution of the default URI of this service.
    /// </summary>
    public TerraformValue<bool> DefaultUriDisabled
    {
        get => new TerraformReference<bool>(this, "default_uri_disabled");
    }

    /// <summary>
    /// The deletion time.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the service. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the service,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the service will fail.
    /// When the field is set to false, deleting the service is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// User-provided description of the Service. This field currently has a 512-character limit.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// For a deleted resource, the time after which it will be permanently deleted.
    /// </summary>
    public TerraformValue<string> ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
    }

    /// <summary>
    /// A number that monotonically increases every time the user modifies the desired state. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformValue<string> Generation
    {
        get => new TerraformReference<string>(this, "generation");
    }

    /// <summary>
    /// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active. Possible values: [&amp;quot;INGRESS_TRAFFIC_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER&amp;quot;]
    /// </summary>
    public TerraformValue<string> Ingress
    {
        get => new TerraformReference<string>(this, "ingress");
    }

    /// <summary>
    /// Disables IAM permission check for run.routes.invoke for callers of this service. For more information, visit https://cloud.google.com/run/docs/securing/managing-access#invoker_check.
    /// </summary>
    public TerraformValue<bool> InvokerIamDisabled
    {
        get => new TerraformReference<bool>(this, "invoker_iam_disabled");
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are shared with Google&#39;s billing system, so they can be used to filter, or break down billing charges by team, component,
    /// environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels.
    /// 
    /// Cloud Run API v2 does not support labels with  &#39;run.googleapis.com&#39;, &#39;cloud.googleapis.com&#39;, &#39;serving.knative.dev&#39;, or &#39;autoscaling.knative.dev&#39; namespaces, and they will be rejected.
    /// All system labels in v1 now have a corresponding field in v2 Service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Email address of the last authenticated modifier.
    /// </summary>
    public TerraformValue<string> LastModifier
    {
        get => new TerraformReference<string>(this, "last_modifier");
    }

    /// <summary>
    /// Name of the last created revision. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> LatestCreatedRevision
    {
        get => new TerraformReference<string>(this, "latest_created_revision");
    }

    /// <summary>
    /// Name of the latest revision that is serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformValue<string> LatestReadyRevision
    {
        get => new TerraformReference<string>(this, "latest_ready_revision");
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/products#product-launch-stages). Cloud Run supports ALPHA, BETA, and GA.
    /// If no value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview features in that stage. On read (or output), describes whether the resource uses preview features.
    /// 
    /// For example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be BETA on output. Possible values: [&amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public TerraformValue<string> LaunchStage
    {
        get => new TerraformReference<string>(this, "launch_stage");
    }

    /// <summary>
    /// Settings for creating a Multi-Region Service. Make sure to use region = &#39;global&#39; when using them. For more information, visit https://cloud.google.com/run/docs/multiple-regions#deploy
    /// </summary>
    public TerraformList<TerraformMap<object>> MultiRegionSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "multi_region_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The generation of this Service currently serving traffic. See comments in reconciling for additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a string instead of an integer.
    /// </summary>
    public TerraformValue<string> ObservedGeneration
    {
        get => new TerraformReference<string>(this, "observed_generation");
    }

    /// <summary>
    /// Returns true if the Service is currently being acted upon by the system to bring it into the desired state.
    /// 
    /// When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, observedGeneration, latest_ready_revison, trafficStatuses, and uri will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in terminalCondition.state.
    /// 
    /// If reconciliation succeeded, the following fields will match: traffic and trafficStatuses, observedGeneration and generation, latestReadyRevision and latestCreatedRevision.
    /// 
    /// If reconciliation failed, trafficStatuses, observedGeneration, and latestReadyRevision will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in terminalCondition and conditions.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// Scaling settings that apply to the whole service
    /// </summary>
    public TerraformList<TerraformMap<object>> Scaling
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scaling").ResolveNodes(ctx));
    }

    /// <summary>
    /// The template used to create revisions for this Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> Template
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "template").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> TerminalCondition
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "terminal_condition").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest Ready Revision.
    /// </summary>
    public TerraformList<TerraformMap<object>> Traffic
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "traffic").ResolveNodes(ctx));
    }

    /// <summary>
    /// Detailed status information for corresponding traffic targets. See comments in reconciling for additional information on reconciliation process in Cloud Run.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrafficStatuses
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "traffic_statuses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// The main URI in which this Service is serving traffic.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

    /// <summary>
    /// All URLs serving traffic for this Service.
    /// </summary>
    public TerraformList<string> Urls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "urls").ResolveNodes(ctx));
    }

}
