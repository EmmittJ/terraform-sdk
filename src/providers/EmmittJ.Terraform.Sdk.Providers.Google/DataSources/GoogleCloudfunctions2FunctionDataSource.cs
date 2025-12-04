using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloudfunctions2_function Terraform data source.
/// Retrieves information about a google_cloudfunctions2_function.
/// </summary>
public partial class GoogleCloudfunctions2FunctionDataSource(string name) : TerraformDataSource("google_cloudfunctions2_function", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of this cloud function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must
    /// be unique globally and match pattern &#39;projects/*/locations/*/functions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Describes the Build step of the function that builds a container
    /// from the given source.
    /// </summary>
    public TerraformList<TerraformMap<object>> BuildConfig
        => AsReference("build_config");

    /// <summary>
    /// User-provided description of a function.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The environment the function is hosted on.
    /// </summary>
    public TerraformValue<string> Environment
        => AsReference("environment");

    /// <summary>
    /// An Eventarc trigger managed by Google Cloud Functions that fires events in
    /// response to a condition in another service.
    /// </summary>
    public TerraformList<TerraformMap<object>> EventTrigger
        => AsReference("event_trigger");

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    public TerraformValue<string> KmsKeyName
        => AsReference("kms_key_name");

    /// <summary>
    /// A set of key/value label pairs associated with this Cloud Function.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// Describes the Service being deployed.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceConfig
        => AsReference("service_config");

    /// <summary>
    /// Describes the current state of the function.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The last update timestamp of a Cloud Function.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Output only. The deployed url for the function.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

}
