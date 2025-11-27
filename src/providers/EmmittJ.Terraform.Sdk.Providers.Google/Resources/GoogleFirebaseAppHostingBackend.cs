using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for codebase in GoogleFirebaseAppHostingBackend.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBackendCodebaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "codebase";

    /// <summary>
    /// The resource name for the Developer Connect
    /// [&#39;gitRepositoryLink&#39;](https://cloud.google.com/developer-connect/docs/api/reference/rest/v1/projects.locations.connections.gitRepositoryLinks)
    /// connected to this backend, in the format:
    /// 
    /// projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{repositoryLink}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => new TerraformReference<string>(this, "repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// If &#39;repository&#39; is provided, the directory relative to the root of the
    /// repository to use as the root for the deployed web app.
    /// </summary>
    public TerraformValue<string>? RootDirectory
    {
        get => new TerraformReference<string>(this, "root_directory");
        set => SetArgument("root_directory", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFirebaseAppHostingBackend.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingBackendTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_hosting_backend Terraform resource.
/// Manages a google_firebase_app_hosting_backend resource.
/// </summary>
public partial class GoogleFirebaseAppHostingBackend(string name) : TerraformResource("google_firebase_app_hosting_backend", name)
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to
    /// store and arbitrary metadata. They are not queryable and should be
    /// preserved when modifying objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The [ID of a Web
    /// App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id)
    /// associated with the backend.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// Id of the backend. Also used as the service ID for Cloud Run, and as part
    /// of the default domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendId is required")]
    public required TerraformValue<string> BackendId
    {
        get => new TerraformReference<string>(this, "backend_id");
        set => SetArgument("backend_id", value);
    }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The environment name of the backend, used to load environment variables
    /// from environment specific configuration.
    /// </summary>
    public TerraformValue<string>? Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The canonical IDs of a Google Cloud location such as &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the service account used for Cloud Build and Cloud Run.
    /// Should have the role roles/firebaseapphosting.computeRunner
    /// or equivalent permissions.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Immutable. Specifies how App Hosting will serve the content for this backend. It will
    /// either be contained to a single region (REGIONAL_STRICT) or allowed to use
    /// App Hosting&#39;s global-replicated serving infrastructure (GLOBAL_ACCESS). Possible values: [&amp;quot;REGIONAL_STRICT&amp;quot;, &amp;quot;GLOBAL_ACCESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServingLocality is required")]
    public required TerraformValue<string> ServingLocality
    {
        get => new TerraformReference<string>(this, "serving_locality");
        set => SetArgument("serving_locality", value);
    }

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
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
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// A list of the resources managed by this backend.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedResources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "managed_resources").ResolveNodes(ctx));
    }

    /// <summary>
    /// Identifier. The resource name of the backend.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// The primary URI to communicate with the backend.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

    /// <summary>
    /// Codebase block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Codebase block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingBackendCodebaseBlock>? Codebase
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingBackendCodebaseBlock>>("codebase");
        set => SetArgument("codebase", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppHostingBackendTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppHostingBackendTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
