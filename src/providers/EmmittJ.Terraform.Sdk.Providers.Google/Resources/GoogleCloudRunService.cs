using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceMetadataBlock : ITerraformBlock
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Computed attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Computed attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "effective_labels");

    /// <summary>
    /// A sequence number representing a specific generation of the desired state.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Generation => new TerraformReferenceProperty<TerraformProperty<double>>("", "generation");

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// and routes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Namespace { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "namespace");

    /// <summary>
    /// An opaque value that represents the internal version of this object that
    /// can be used by clients to determine when objects have changed. May be used
    /// for optimistic concurrency, change detection, and the watch operation on a
    /// resource or set of resources. They may only be valid for a
    /// particular resource or set of resources.
    /// </summary>
    [TerraformPropertyName("resource_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "resource_version");

    /// <summary>
    /// SelfLink is a URL representing this object.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>("", "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Computed attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "terraform_labels");

    /// <summary>
    /// UID is a unique id generated by the server on successful creation of a resource and is not
    /// allowed to change on PUT operations.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>("", "uid");

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunServiceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for traffic in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTrafficBlock : ITerraformBlock
{
    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    [TerraformPropertyName("latest_revision")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LatestRevision { get; set; }

    /// <summary>
    /// Percent specifies percent of the traffic to this Revision or Configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percent is required")]
    [TerraformPropertyName("percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Percent { get; set; }

    /// <summary>
    /// RevisionName of a specific revision to which to send this portion of traffic.
    /// </summary>
    [TerraformPropertyName("revision_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RevisionName { get; set; }

    /// <summary>
    /// Tag is optionally used to expose a dedicated url for referencing this target exclusively.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tag { get; set; }

    /// <summary>
    /// URL displays the URL for accessing tagged traffic targets. URL is displayed in status,
    /// and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname,
    /// but may not contain anything else (e.g. basic auth, url path, etc.)
    /// </summary>
    [TerraformPropertyName("url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>("", "url");

}

/// <summary>
/// Manages a google_cloud_run_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudRunService : TerraformResource
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
    [TerraformPropertyName("autogenerate_revision_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutogenerateRevisionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the cloud run instance. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Name must be unique within a Google Cloud project and region.
    /// Is required when creating resources. Name is primarily intended
    /// for creation idempotence and configuration definition. Cannot be updated.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    [TerraformPropertyName("metadata")]
    public TerraformList<TerraformBlock<GoogleCloudRunServiceMetadataBlock>>? Metadata { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformPropertyName("template")]
    public TerraformList<TerraformBlock<GoogleCloudRunServiceTemplateBlock>>? Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudRunServiceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for traffic.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("traffic")]
    public TerraformList<TerraformBlock<GoogleCloudRunServiceTrafficBlock>>? Traffic { get; set; } = new();

    /// <summary>
    /// The current status of the Service.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "status");

}
