using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firebase_app_hosting_backend resource.
/// </summary>
public class GoogleFirebaseAppHostingBackend : TerraformResource
{
    public GoogleFirebaseAppHostingBackend(string name) : base("google_firebase_app_hosting_backend", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("managed_resources");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to
    /// store and arbitrary metadata. They are not queryable and should be
    /// preserved when modifying objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Annotations
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The [ID of a Web
    /// App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id)
    /// associated with the backend.
    /// </summary>
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// Id of the backend. Also used as the service ID for Cloud Run, and as part
    /// of the default domain name.
    /// </summary>
    public TerraformProperty<string>? BackendId
    {
        get => GetProperty<TerraformProperty<string>>("backend_id");
        set => this.WithProperty("backend_id", value);
    }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The environment name of the backend, used to load environment variables
    /// from environment specific configuration.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The canonical IDs of a Google Cloud location such as &amp;quot;us-east1&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The name of the service account used for Cloud Build and Cloud Run.
    /// Should have the role roles/firebaseapphosting.computeRunner
    /// or equivalent permissions.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Immutable. Specifies how App Hosting will serve the content for this backend. It will
    /// either be contained to a single region (REGIONAL_STRICT) or allowed to use
    /// App Hosting&#39;s global-replicated serving infrastructure (GLOBAL_ACCESS). Possible values: [&amp;quot;REGIONAL_STRICT&amp;quot;, &amp;quot;GLOBAL_ACCESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ServingLocality
    {
        get => GetProperty<TerraformProperty<string>>("serving_locality");
        set => this.WithProperty("serving_locality", value);
    }

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// A list of the resources managed by this backend.
    /// </summary>
    public TerraformExpression ManagedResources => this["managed_resources"];

    /// <summary>
    /// Identifier. The resource name of the backend.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The primary URI to communicate with the backend.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
