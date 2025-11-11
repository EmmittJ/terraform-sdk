using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for codebase in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirebaseAppHostingBackendCodebaseBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource name for the Developer Connect
    /// [&#39;gitRepositoryLink&#39;](https://cloud.google.com/developer-connect/docs/api/reference/rest/v1/projects.locations.connections.gitRepositoryLinks)
    /// connected to this backend, in the format:
    /// 
    /// projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{repositoryLink}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformProperty("repository")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Repository { get; set; }

    /// <summary>
    /// If &#39;repository&#39; is provided, the directory relative to the root of the
    /// repository to use as the root for the deployed web app.
    /// </summary>
    [TerraformProperty("root_directory")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RootDirectory { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppHostingBackendTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_firebase_app_hosting_backend resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleFirebaseAppHostingBackend : TerraformResource
{
    public GoogleFirebaseAppHostingBackend(string name) : base("google_firebase_app_hosting_backend", name)
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
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The [ID of a Web
    /// App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id)
    /// associated with the backend.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// Id of the backend. Also used as the service ID for Cloud Run, and as part
    /// of the default domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendId is required")]
    [TerraformProperty("backend_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BackendId { get; set; }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The environment name of the backend, used to load environment variables
    /// from environment specific configuration.
    /// </summary>
    [TerraformProperty("environment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The canonical IDs of a Google Cloud location such as &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the service account used for Cloud Build and Cloud Run.
    /// Should have the role roles/firebaseapphosting.computeRunner
    /// or equivalent permissions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [TerraformProperty("service_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Immutable. Specifies how App Hosting will serve the content for this backend. It will
    /// either be contained to a single region (REGIONAL_STRICT) or allowed to use
    /// App Hosting&#39;s global-replicated serving infrastructure (GLOBAL_ACCESS). Possible values: [&amp;quot;REGIONAL_STRICT&amp;quot;, &amp;quot;GLOBAL_ACCESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServingLocality is required")]
    [TerraformProperty("serving_locality")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServingLocality { get; set; }

    /// <summary>
    /// Block for codebase.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Codebase block(s) allowed")]
    [TerraformProperty("codebase")]
    public TerraformList<TerraformBlock<GoogleFirebaseAppHostingBackendCodebaseBlock>>? Codebase { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleFirebaseAppHostingBackendTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// A list of the resources managed by this backend.
    /// </summary>
    [TerraformProperty("managed_resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedResources { get; }

    /// <summary>
    /// Identifier. The resource name of the backend.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// The primary URI to communicate with the backend.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uri { get; }

}
