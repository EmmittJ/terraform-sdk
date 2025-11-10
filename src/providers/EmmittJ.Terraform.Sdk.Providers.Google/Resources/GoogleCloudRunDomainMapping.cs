using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunDomainMappingMetadataBlock : TerraformBlock
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
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => WithProperty("annotations", value);
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EffectiveAnnotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("effective_annotations");
        set => WithProperty("effective_annotations", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EffectiveLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("effective_labels");
        set => WithProperty("effective_labels", value);
    }

    /// <summary>
    /// A sequence number representing a specific generation of the desired state.
    /// </summary>
    public TerraformProperty<double>? Generation
    {
        get => GetProperty<TerraformProperty<double>>("generation");
        set => WithProperty("generation", value);
    }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// and routes.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
    }

    /// <summary>
    /// An opaque value that represents the internal version of this object that
    /// can be used by clients to determine when objects have changed. May be used
    /// for optimistic concurrency, change detection, and the watch operation on a
    /// resource or set of resources. They may only be valid for a
    /// particular resource or set of resources.
    /// 
    /// More info:
    /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    public TerraformProperty<string>? ResourceVersion
    {
        get => GetProperty<TerraformProperty<string>>("resource_version");
        set => WithProperty("resource_version", value);
    }

    /// <summary>
    /// SelfLink is a URL representing this object.
    /// </summary>
    public TerraformProperty<string>? SelfLink
    {
        get => GetProperty<TerraformProperty<string>>("self_link");
        set => WithProperty("self_link", value);
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TerraformLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("terraform_labels");
        set => WithProperty("terraform_labels", value);
    }

    /// <summary>
    /// UID is a unique id generated by the server on successful creation of a resource and is not
    /// allowed to change on PUT operations.
    /// 
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
    /// </summary>
    public TerraformProperty<string>? Uid
    {
        get => GetProperty<TerraformProperty<string>>("uid");
        set => WithProperty("uid", value);
    }

}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunDomainMappingSpecBlock : TerraformBlock
{
    /// <summary>
    /// The mode of the certificate. Default value: &amp;quot;AUTOMATIC&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("certificate_mode");
        set => WithProperty("certificate_mode", value);
    }

    /// <summary>
    /// If set, the mapping will override any mapping set before this spec was set.
    /// It is recommended that the user leaves this empty to receive an error
    /// warning about a potential conflict and only set it once the respective UI
    /// has given such a warning.
    /// </summary>
    public TerraformProperty<bool>? ForceOverride
    {
        get => GetProperty<TerraformProperty<bool>>("force_override");
        set => WithProperty("force_override", value);
    }

    /// <summary>
    /// The name of the Cloud Run Service that this DomainMapping applies to.
    /// The route must exist.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteName is required")]
    public required TerraformProperty<string> RouteName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("route_name");
        set => WithProperty("route_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunDomainMappingTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_cloud_run_domain_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudRunDomainMapping : TerraformResource
{
    public GoogleCloudRunDomainMapping(string name) : base("google_cloud_run_domain_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("status");
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
    /// The location of the cloud run instance. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name should be a [verified](https://support.google.com/webmasters/answer/9008080) domain
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public List<GoogleCloudRunDomainMappingMetadataBlock>? Metadata
    {
        get => GetProperty<List<GoogleCloudRunDomainMappingMetadataBlock>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public List<GoogleCloudRunDomainMappingSpecBlock>? Spec
    {
        get => GetProperty<List<GoogleCloudRunDomainMappingSpecBlock>>("spec");
        set => this.WithProperty("spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudRunDomainMappingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudRunDomainMappingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The current status of the DomainMapping.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
