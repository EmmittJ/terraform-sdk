using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in GoogleApihubApiHubInstance.
/// Nesting mode: list
/// </summary>
public class GoogleApihubApiHubInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// Optional. The Customer Managed Encryption Key (CMEK) used for data encryption.
    /// The CMEK name should follow the format of
    /// &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;,
    /// where the location must match the instance location.
    /// If the CMEK is not provided, a GMEK will be created for the instance.
    /// </summary>
    public TerraformValue<string>? CmekKeyName
    {
        get => GetArgument<TerraformValue<string>>("cmek_key_name");
        set => SetArgument("cmek_key_name", value);
    }

    /// <summary>
    /// Optional. If true, the search will be disabled for the instance. The default value
    /// is false.
    /// </summary>
    public TerraformValue<bool>? DisableSearch
    {
        get => GetArgument<TerraformValue<bool>>("disable_search");
        set => SetArgument("disable_search", value);
    }

    /// <summary>
    /// Optional. Encryption type for the region. If the encryption type is CMEK, the
    /// cmek_key_name must be provided. If no encryption type is provided,
    /// GMEK will be used.
    /// Possible values:
    /// ENCRYPTION_TYPE_UNSPECIFIED
    /// GMEK
    /// CMEK
    /// </summary>
    public TerraformValue<string> EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type") ?? CreateReference("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// Optional. The name of the Vertex AI location where the data store is stored.
    /// </summary>
    public TerraformValue<string>? VertexLocation
    {
        get => GetArgument<TerraformValue<string>>("vertex_location");
        set => SetArgument("vertex_location", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApihubApiHubInstance.
/// Nesting mode: single
/// </summary>
public class GoogleApihubApiHubInstanceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apihub_api_hub_instance Terraform resource.
/// Manages a google_apihub_api_hub_instance resource.
/// </summary>
public partial class GoogleApihubApiHubInstance(string name) : TerraformResource("google_apihub_api_hub_instance", name)
{
    /// <summary>
    /// Optional. Identifier to assign to the Api Hub instance. Must be unique within
    /// scope of the parent resource. If the field is not provided,
    /// system generated id will be used.
    /// 
    /// This value should be 4-40 characters, and valid characters
    /// are &#39;/a-z[0-9]-_/&#39;.
    /// </summary>
    public TerraformValue<string>? ApiHubInstanceId
    {
        get => GetArgument<TerraformValue<string>>("api_hub_instance_id");
        set => SetArgument("api_hub_instance_id", value);
    }

    /// <summary>
    /// Optional. Description of the ApiHub instance.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Instance labels to represent user-provided metadata.
    /// Refer to cloud documentation on labels for more details.
    /// https://cloud.google.com/compute/docs/labeling-resources
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. Creation timestamp.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Identifier. Format:
    /// &#39;projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. The current state of the ApiHub instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// INACTIVE
    /// CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// FAILED
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Output only. Extra information about ApiHub instance state. Currently the message
    /// would be populated when state is &#39;FAILED&#39;.
    /// </summary>
    public TerraformValue<string> StateMessage
        => CreateReference("state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Output only. Last update timestamp.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleApihubApiHubInstanceConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleApihubApiHubInstanceConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApihubApiHubInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApihubApiHubInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
