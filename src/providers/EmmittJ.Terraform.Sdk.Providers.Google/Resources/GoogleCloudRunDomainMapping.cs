using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunDomainMappingMetadataBlock : TerraformBlockBase
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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }




    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// and routes.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }





}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudRunDomainMappingSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The mode of the certificate. Default value: &amp;quot;AUTOMATIC&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    [TerraformProperty("certificate_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateMode { get; set; }

    /// <summary>
    /// If set, the mapping will override any mapping set before this spec was set.
    /// It is recommended that the user leaves this empty to receive an error
    /// warning about a potential conflict and only set it once the respective UI
    /// has given such a warning.
    /// </summary>
    [TerraformProperty("force_override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceOverride { get; set; }

    /// <summary>
    /// The name of the Cloud Run Service that this DomainMapping applies to.
    /// The route must exist.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteName is required")]
    [TerraformProperty("route_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RouteName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudRunDomainMappingTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_cloud_run_domain_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudRunDomainMapping : TerraformResource
{
    public GoogleCloudRunDomainMapping(string name) : base("google_cloud_run_domain_mapping", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the cloud run instance. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name should be a [verified](https://support.google.com/webmasters/answer/9008080) domain
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    [TerraformProperty("metadata")]
    public partial TerraformList<TerraformBlock<GoogleCloudRunDomainMappingMetadataBlock>>? Metadata { get; set; }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    [TerraformProperty("spec")]
    public partial TerraformList<TerraformBlock<GoogleCloudRunDomainMappingSpecBlock>>? Spec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleCloudRunDomainMappingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The current status of the DomainMapping.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

}
