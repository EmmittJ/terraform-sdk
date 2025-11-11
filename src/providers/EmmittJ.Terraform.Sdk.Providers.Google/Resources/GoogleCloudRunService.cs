using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunServiceMetadataBlock : TerraformBlockBase
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// 
    /// **Note**: The Cloud Run API may add additional annotations that were not provided in your config.
    /// If terraform plan shows a diff where a server-side annotation is added, you can add it to your config
    /// or apply the lifecycle.ignore_changes rule to the metadata.0.annotations field.
    /// 
    /// Annotations with &#39;run.googleapis.com/&#39; and &#39;autoscaling.knative.dev&#39; are restricted. Use the following annotation
    /// keys to configure features on a Service:
    /// 
    /// - &#39;run.googleapis.com/binary-authorization-breakglass&#39; sets the [Binary Authorization breakglass](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--breakglass).
    /// - &#39;run.googleapis.com/binary-authorization&#39; sets the [Binary Authorization](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--binary-authorization).
    /// - &#39;run.googleapis.com/client-name&#39; sets the client name calling the Cloud Run API.
    /// - &#39;run.googleapis.com/custom-audiences&#39; sets the [custom audiences](https://cloud.google.com/sdk/gcloud/reference/alpha/run/deploy#--add-custom-audiences)
    ///   that can be used in the audience field of ID token for authenticated requests.
    /// - &#39;run.googleapis.com/description&#39; sets a user defined description for the Service.
    /// - &#39;run.googleapis.com/ingress&#39; sets the [ingress settings](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--ingress)
    ///   for the Service. For example, &#39;&amp;quot;run.googleapis.com/ingress&amp;quot; = &amp;quot;all&amp;quot;&#39;.
    /// - &#39;run.googleapis.com/launch-stage&#39; sets the [launch stage](https://cloud.google.com/run/docs/troubleshooting#launch-stage-validation)
    ///   when a preview feature is used. For example, &#39;&amp;quot;run.googleapis.com/launch-stage&amp;quot;: &amp;quot;BETA&amp;quot;&#39;
    /// - &#39;run.googleapis.com/minScale&#39; sets the [minimum number of container instances](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--min) of the Service.
    /// - &#39;run.googleapis.com/scalingMode&#39; sets the type of scaling mode for the service. The supported values for scaling mode are &amp;quot;manual&amp;quot; and &amp;quot;automatic&amp;quot;. If not provided, it defaults to &amp;quot;automatic&amp;quot;.
    /// - &#39;run.googleapis.com/manualInstanceCount&#39; sets the total instance count for the service in manual scaling mode. This number of instances is divided among all revisions with specified traffic based on the percent of traffic they are receiving.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }




    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// and routes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Namespace { get; set; }





}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunServiceTemplateBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudRunServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for traffic in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunServiceTrafficBlock : TerraformBlockBase
{
    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    [TerraformProperty("latest_revision")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LatestRevision { get; set; }

    /// <summary>
    /// Percent specifies percent of the traffic to this Revision or Configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percent is required")]
    [TerraformProperty("percent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Percent { get; set; }

    /// <summary>
    /// RevisionName of a specific revision to which to send this portion of traffic.
    /// </summary>
    [TerraformProperty("revision_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RevisionName { get; set; }

    /// <summary>
    /// Tag is optionally used to expose a dedicated url for referencing this target exclusively.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tag { get; set; }


}

/// <summary>
/// Manages a google_cloud_run_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudRunService : TerraformResource
{
    public GoogleCloudRunService(string name) : base("google_cloud_run_service", name)
    {
    }

    /// <summary>
    /// If set to &#39;true&#39;, the revision name (template.metadata.name) will be omitted and
    /// autogenerated by Cloud Run. This cannot be set to &#39;true&#39; while &#39;template.metadata.name&#39;
    /// is also set.
    /// (For legacy support, if &#39;template.metadata.name&#39; is unset in state while
    /// this field is set to false, the revision name will still autogenerate.)
    /// </summary>
    [TerraformProperty("autogenerate_revision_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutogenerateRevisionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the cloud run instance. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name must be unique within a Google Cloud project and region.
    /// Is required when creating resources. Name is primarily intended
    /// for creation idempotence and configuration definition. Cannot be updated.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    [TerraformProperty("metadata")]
    public TerraformList<TerraformBlock<GoogleCloudRunServiceMetadataBlock>>? Metadata { get; set; }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformProperty("template")]
    public TerraformList<TerraformBlock<GoogleCloudRunServiceTemplateBlock>>? Template { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleCloudRunServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("traffic")]
    public TerraformList<TerraformBlock<GoogleCloudRunServiceTrafficBlock>>? Traffic { get; set; }

    /// <summary>
    /// The current status of the Service.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Status { get; }

}
