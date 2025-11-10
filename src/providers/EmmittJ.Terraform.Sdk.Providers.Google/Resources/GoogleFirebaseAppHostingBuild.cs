using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBuildSourceBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingBuildTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_firebase_app_hosting_build resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirebaseAppHostingBuild : TerraformResource
{
    public GoogleFirebaseAppHostingBuild(string name) : base("google_firebase_app_hosting_build", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("build_logs_uri");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("environment");
        this.DeclareOutput("error");
        this.DeclareOutput("error_source");
        this.DeclareOutput("etag");
        this.DeclareOutput("image");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Unstructured key value map that may be set by external tools to
    /// store and arbitrary metadata. They are not queryable and should be
    /// preserved when modifying objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The ID of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformProperty<string> Backend
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backend");
        set => this.WithProperty("backend", value);
    }

    /// <summary>
    /// The user-specified ID of the build being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildId is required")]
    public required TerraformProperty<string> BuildId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("build_id");
        set => this.WithProperty("build_id", value);
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
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
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<GoogleFirebaseAppHostingBuildSourceBlock>? Source
    {
        get => GetProperty<List<GoogleFirebaseAppHostingBuildSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaseAppHostingBuildTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFirebaseAppHostingBuildTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The location of the [Cloud Build
    /// logs](https://cloud.google.com/build/docs/view-build-results) for the build
    /// process.
    /// </summary>
    public TerraformExpression BuildLogsUri => this["build_logs_uri"];

    /// <summary>
    /// Time at which the build was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The environment name of the backend when this build was created.
    /// </summary>
    public TerraformExpression Environment => this["environment"];

    /// <summary>
    /// The &#39;Status&#39; type defines a logical error model that is suitable for
    /// different programming environments, including REST APIs and RPC APIs. It is
    /// used by [gRPC](https://github.com/grpc). Each &#39;Status&#39; message contains
    /// three pieces of data: error code, error message, and error details.
    /// 
    /// You can find out more about this error model and how to work with it in the
    /// [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public TerraformExpression Error => this["error"];

    /// <summary>
    /// The source of the error for the build, if in a &#39;FAILED&#39; state.
    /// Possible values:
    /// CLOUD_BUILD
    /// CLOUD_RUN
    /// </summary>
    public TerraformExpression ErrorSource => this["error_source"];

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The Artifact Registry
    /// [container
    /// image](https://cloud.google.com/artifact-registry/docs/reference/rest/v1/projects.locations.repositories.dockerImages)
    /// URI, used by the Cloud Run
    /// [&#39;revision&#39;](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services.revisions)
    /// for this build.
    /// </summary>
    public TerraformExpression Image => this["image"];

    /// <summary>
    /// Identifier. The resource name of the build.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/builds/{buildId}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the build.
    /// Possible values:
    /// BUILDING
    /// BUILT
    /// DEPLOYING
    /// READY
    /// FAILED
    /// </summary>
    public TerraformExpression State => this["state"];

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
    /// Time at which the build was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
