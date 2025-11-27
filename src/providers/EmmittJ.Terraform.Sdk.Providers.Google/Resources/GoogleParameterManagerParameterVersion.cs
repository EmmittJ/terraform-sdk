using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleParameterManagerParameterVersion.
/// Nesting mode: single
/// </summary>
public class GoogleParameterManagerParameterVersionTimeoutsBlock : TerraformBlock
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
/// Represents a google_parameter_manager_parameter_version Terraform resource.
/// Manages a google_parameter_manager_parameter_version resource.
/// </summary>
public partial class GoogleParameterManagerParameterVersion(string name) : TerraformResource("google_parameter_manager_parameter_version", name)
{
    /// <summary>
    /// The current state of Parameter Version. This field is only applicable for updating Parameter Version.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
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
    /// Parameter Manager Parameter resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformValue<string> Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The Parameter data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterData is required")]
    public required TerraformValue<string> ParameterData
    {
        get => new TerraformReference<string>(this, "parameter_data");
        set => SetArgument("parameter_data", value);
    }

    /// <summary>
    /// Version ID of the Parameter Version Resource. This must be unique within the Parameter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformValue<string> ParameterVersionId
    {
        get => new TerraformReference<string>(this, "parameter_version_id");
        set => SetArgument("parameter_version_id", value);
    }

    /// <summary>
    /// The time at which the Parameter Version was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKeyVersion used to decrypt parameter version payload. Format
    /// &#39;projects/{{project}}/locations/global/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}/cryptoKeyVersions/{{crypto_key_version}}&#39;
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
    {
        get => new TerraformReference<string>(this, "kms_key_version");
    }

    /// <summary>
    /// The resource name of the Parameter Version. Format:
    /// &#39;projects/{{project}}/locations/global/parameters/{{parameter_id}}/versions/{{parameter_version_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The time at which the Parameter Version was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleParameterManagerParameterVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleParameterManagerParameterVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
