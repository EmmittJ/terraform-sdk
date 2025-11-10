using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleParameterManagerParameterVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_parameter_manager_parameter_version resource.
/// </summary>
public class GoogleParameterManagerParameterVersion : TerraformResource
{
    public GoogleParameterManagerParameterVersion(string name) : base("google_parameter_manager_parameter_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("kms_key_version");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("parameter");
        SetOutput("parameter_data");
        SetOutput("parameter_version_id");
    }

    /// <summary>
    /// The current state of Parameter Version. This field is only applicable for updating Parameter Version.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Parameter Manager Parameter resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformProperty<string> Parameter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter");
        set => SetProperty("parameter", value);
    }

    /// <summary>
    /// The Parameter data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterData is required")]
    public required TerraformProperty<string> ParameterData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_data");
        set => SetProperty("parameter_data", value);
    }

    /// <summary>
    /// Version ID of the Parameter Version Resource. This must be unique within the Parameter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformProperty<string> ParameterVersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_version_id");
        set => SetProperty("parameter_version_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleParameterManagerParameterVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time at which the Parameter Version was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKeyVersion used to decrypt parameter version payload. Format
    /// &#39;projects/{{project}}/locations/global/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}/cryptoKeyVersions/{{crypto_key_version}}&#39;
    /// </summary>
    public TerraformExpression KmsKeyVersion => this["kms_key_version"];

    /// <summary>
    /// The resource name of the Parameter Version. Format:
    /// &#39;projects/{{project}}/locations/global/parameters/{{parameter_id}}/versions/{{parameter_version_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time at which the Parameter Version was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
