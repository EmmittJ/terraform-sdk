using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirebaseAppHostingBuildSourceBlock() : TerraformBlock("source")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppHostingBuildTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_firebase_app_hosting_build resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleFirebaseAppHostingBuild : TerraformResource
{
    public GoogleFirebaseAppHostingBuild(string name) : base("google_firebase_app_hosting_build", name)
    {
    }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to
    /// store and arbitrary metadata. They are not queryable and should be
    /// preserved when modifying objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The ID of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    [TerraformProperty("backend")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Backend { get; set; }

    /// <summary>
    /// The user-specified ID of the build being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildId is required")]
    [TerraformProperty("build_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BuildId { get; set; }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public required TerraformList<GoogleFirebaseAppHostingBuildSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirebaseAppHostingBuildTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The location of the [Cloud Build
    /// logs](https://cloud.google.com/build/docs/view-build-results) for the build
    /// process.
    /// </summary>
    [TerraformProperty("build_logs_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BuildLogsUri { get; }

    /// <summary>
    /// Time at which the build was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The environment name of the backend when this build was created.
    /// </summary>
    [TerraformProperty("environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Environment { get; }

    /// <summary>
    /// The &#39;Status&#39; type defines a logical error model that is suitable for
    /// different programming environments, including REST APIs and RPC APIs. It is
    /// used by [gRPC](https://github.com/grpc). Each &#39;Status&#39; message contains
    /// three pieces of data: error code, error message, and error details.
    /// 
    /// You can find out more about this error model and how to work with it in the
    /// [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    [TerraformProperty("error")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Error { get; }

    /// <summary>
    /// The source of the error for the build, if in a &#39;FAILED&#39; state.
    /// Possible values:
    /// CLOUD_BUILD
    /// CLOUD_RUN
    /// </summary>
    [TerraformProperty("error_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorSource { get; }

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The Artifact Registry
    /// [container
    /// image](https://cloud.google.com/artifact-registry/docs/reference/rest/v1/projects.locations.repositories.dockerImages)
    /// URI, used by the Cloud Run
    /// [&#39;revision&#39;](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services.revisions)
    /// for this build.
    /// </summary>
    [TerraformProperty("image")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Image { get; }

    /// <summary>
    /// Identifier. The resource name of the build.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/builds/{buildId}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The state of the build.
    /// Possible values:
    /// BUILDING
    /// BUILT
    /// DEPLOYING
    /// READY
    /// FAILED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time at which the build was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
