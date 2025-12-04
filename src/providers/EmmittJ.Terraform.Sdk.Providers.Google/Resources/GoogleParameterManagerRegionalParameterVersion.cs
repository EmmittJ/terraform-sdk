using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleParameterManagerRegionalParameterVersion.
/// Nesting mode: single
/// </summary>
public class GoogleParameterManagerRegionalParameterVersionTimeoutsBlock : TerraformBlock
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
/// Represents a google_parameter_manager_regional_parameter_version Terraform resource.
/// Manages a google_parameter_manager_regional_parameter_version resource.
/// </summary>
public partial class GoogleParameterManagerRegionalParameterVersion(string name) : TerraformResource("google_parameter_manager_regional_parameter_version", name)
{
    /// <summary>
    /// The current state of Regional Parameter Version. This field is only applicable for updating Regional Parameter Version.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Parameter Manager Regional Parameter resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformValue<string> Parameter
    {
        get => GetArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The Regional Parameter data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterData is required")]
    public required TerraformValue<string> ParameterData
    {
        get => GetArgument<TerraformValue<string>>("parameter_data");
        set => SetArgument("parameter_data", value);
    }

    /// <summary>
    /// Version ID of the Regional Parameter Version Resource. This must be unique within the Regional Parameter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformValue<string> ParameterVersionId
    {
        get => GetArgument<TerraformValue<string>>("parameter_version_id");
        set => SetArgument("parameter_version_id", value);
    }

    /// <summary>
    /// The time at which the Regional Parameter Version was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKeyVersion used to decrypt regional parameter version payload. Format
    /// &#39;projects/{{project}}/locations/{{location}}/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}/cryptoKeyVersions/{{crypto_key_version}}&#39;
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
        => AsReference("kms_key_version");

    /// <summary>
    /// Location of Parameter Manager Regional parameter resource.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The resource name of the Regional Parameter Version. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/parameters/{{parameter_id}}/versions/{{parameter_version_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The time at which the Regional Parameter Version was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleParameterManagerRegionalParameterVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleParameterManagerRegionalParameterVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
