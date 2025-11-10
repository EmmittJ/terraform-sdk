using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for codebase in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBackendCodebaseBlock : ITerraformBlock
{
    /// <summary>
    /// The resource name for the Developer Connect
    /// [&#39;gitRepositoryLink&#39;](https://cloud.google.com/developer-connect/docs/api/reference/rest/v1/projects.locations.connections.gitRepositoryLinks)
    /// connected to this backend, in the format:
    /// 
    /// projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{repositoryLink}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformPropertyName("repository")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Repository { get; set; }

    /// <summary>
    /// If &#39;repository&#39; is provided, the directory relative to the root of the
    /// repository to use as the root for the deployed web app.
    /// </summary>
    [TerraformPropertyName("root_directory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RootDirectory { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingBackendTimeoutsBlock : ITerraformBlock
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
/// Manages a google_firebase_app_hosting_backend resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirebaseAppHostingBackend : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The [ID of a Web
    /// App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id)
    /// associated with the backend.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// Id of the backend. Also used as the service ID for Cloud Run, and as part
    /// of the default domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendId is required")]
    [TerraformPropertyName("backend_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackendId { get; set; }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The environment name of the backend, used to load environment variables
    /// from environment specific configuration.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The canonical IDs of a Google Cloud location such as &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The name of the service account used for Cloud Build and Cloud Run.
    /// Should have the role roles/firebaseapphosting.computeRunner
    /// or equivalent permissions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [TerraformPropertyName("service_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccount { get; set; }

    /// <summary>
    /// Immutable. Specifies how App Hosting will serve the content for this backend. It will
    /// either be contained to a single region (REGIONAL_STRICT) or allowed to use
    /// App Hosting&#39;s global-replicated serving infrastructure (GLOBAL_ACCESS). Possible values: [&amp;quot;REGIONAL_STRICT&amp;quot;, &amp;quot;GLOBAL_ACCESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServingLocality is required")]
    [TerraformPropertyName("serving_locality")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServingLocality { get; set; }

    /// <summary>
    /// Block for codebase.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Codebase block(s) allowed")]
    [TerraformPropertyName("codebase")]
    public TerraformList<TerraformBlock<GoogleFirebaseAppHostingBackendCodebaseBlock>>? Codebase { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirebaseAppHostingBackendTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// A list of the resources managed by this backend.
    /// </summary>
    [TerraformPropertyName("managed_resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagedResources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "managed_resources");

    /// <summary>
    /// Identifier. The resource name of the backend.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// The primary URI to communicate with the backend.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uri");

}
