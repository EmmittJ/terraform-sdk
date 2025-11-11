using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBuildSourceBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingBuildTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_firebase_app_hosting_build resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirebaseAppHostingBuild : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The ID of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    [TerraformPropertyName("backend")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Backend { get; set; }

    /// <summary>
    /// The user-specified ID of the build being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildId is required")]
    [TerraformPropertyName("build_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BuildId { get; set; }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<GoogleFirebaseAppHostingBuildSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirebaseAppHostingBuildTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location of the [Cloud Build
    /// logs](https://cloud.google.com/build/docs/view-build-results) for the build
    /// process.
    /// </summary>
    [TerraformPropertyName("build_logs_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BuildLogsUri => new TerraformReference(this, "build_logs_uri");

    /// <summary>
    /// Time at which the build was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

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
    /// The environment name of the backend when this build was created.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Environment => new TerraformReference(this, "environment");

    /// <summary>
    /// The &#39;Status&#39; type defines a logical error model that is suitable for
    /// different programming environments, including REST APIs and RPC APIs. It is
    /// used by [gRPC](https://github.com/grpc). Each &#39;Status&#39; message contains
    /// three pieces of data: error code, error message, and error details.
    /// 
    /// You can find out more about this error model and how to work with it in the
    /// [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    [TerraformPropertyName("error")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Error => new TerraformReference(this, "error");

    /// <summary>
    /// The source of the error for the build, if in a &#39;FAILED&#39; state.
    /// Possible values:
    /// CLOUD_BUILD
    /// CLOUD_RUN
    /// </summary>
    [TerraformPropertyName("error_source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorSource => new TerraformReference(this, "error_source");

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The Artifact Registry
    /// [container
    /// image](https://cloud.google.com/artifact-registry/docs/reference/rest/v1/projects.locations.repositories.dockerImages)
    /// URI, used by the Cloud Run
    /// [&#39;revision&#39;](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services.revisions)
    /// for this build.
    /// </summary>
    [TerraformPropertyName("image")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Image => new TerraformReference(this, "image");

    /// <summary>
    /// Identifier. The resource name of the build.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/builds/{buildId}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The state of the build.
    /// Possible values:
    /// BUILDING
    /// BUILT
    /// DEPLOYING
    /// READY
    /// FAILED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Time at which the build was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
