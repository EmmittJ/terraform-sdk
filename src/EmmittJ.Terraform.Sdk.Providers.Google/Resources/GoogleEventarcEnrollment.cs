using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEventarcEnrollmentTimeoutsBlock : TerraformBlock
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
/// Manages a google_eventarc_enrollment resource.
/// </summary>
public class GoogleEventarcEnrollment : TerraformResource
{
    public GoogleEventarcEnrollment(string name) : base("google_eventarc_enrollment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Resource annotations.
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
    /// A CEL expression identifying which messages this enrollment applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CelMatch is required")]
    public required TerraformProperty<string> CelMatch
    {
        get => GetProperty<TerraformProperty<string>>("cel_match");
        set => this.WithProperty("cel_match", value);
    }

    /// <summary>
    /// Destination is the Pipeline that the Enrollment is delivering to. It must
    /// point to the full resource name of a Pipeline. Format:
    /// &amp;quot;projects/{PROJECT_ID}/locations/{region}/pipelines/{PIPELINE_ID)&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetProperty<TerraformProperty<string>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// Resource display name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The user-provided ID to be assigned to the Enrollment. It should match the
    /// format &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrollmentId is required")]
    public required TerraformProperty<string> EnrollmentId
    {
        get => GetProperty<TerraformProperty<string>>("enrollment_id");
        set => this.WithProperty("enrollment_id", value);
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
    /// Resource labels.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Resource name of the message bus identifying the source of the messages. It
    /// matches the form
    /// projects/{project}/locations/{location}/messageBuses/{messageBus}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageBus is required")]
    public required TerraformProperty<string> MessageBus
    {
        get => GetProperty<TerraformProperty<string>>("message_bus");
        set => this.WithProperty("message_bus", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEventarcEnrollmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleEventarcEnrollmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The creation time.
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
    /// This checksum is computed by the server based on the value of other
    /// fields, and might be sent only on update and delete requests to ensure that
    /// the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Resource name of the form
    /// projects/{project}/locations/{location}/enrollments/{enrollment}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server assigned unique identifier for the channel. The value is a UUID4
    /// string and guaranteed to remain unchanged until the resource is deleted.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The last-modified time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
