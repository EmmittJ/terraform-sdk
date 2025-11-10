using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleParameterManagerRegionalParameterVersionTimeoutsBlock : TerraformBlock
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
/// Manages a google_parameter_manager_regional_parameter_version resource.
/// </summary>
public class GoogleParameterManagerRegionalParameterVersion : TerraformResource
{
    public GoogleParameterManagerRegionalParameterVersion(string name) : base("google_parameter_manager_regional_parameter_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("kms_key_version");
        this.DeclareOutput("location");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The current state of Regional Parameter Version. This field is only applicable for updating Regional Parameter Version.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
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
    /// Parameter Manager Regional Parameter resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformProperty<string> Parameter
    {
        get => GetProperty<TerraformProperty<string>>("parameter");
        set => this.WithProperty("parameter", value);
    }

    /// <summary>
    /// The Regional Parameter data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterData is required")]
    public required TerraformProperty<string> ParameterData
    {
        get => GetProperty<TerraformProperty<string>>("parameter_data");
        set => this.WithProperty("parameter_data", value);
    }

    /// <summary>
    /// Version ID of the Regional Parameter Version Resource. This must be unique within the Regional Parameter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformProperty<string> ParameterVersionId
    {
        get => GetProperty<TerraformProperty<string>>("parameter_version_id");
        set => this.WithProperty("parameter_version_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleParameterManagerRegionalParameterVersionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleParameterManagerRegionalParameterVersionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time at which the Regional Parameter Version was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKeyVersion used to decrypt regional parameter version payload. Format
    /// &#39;projects/{{project}}/locations/{{location}}/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}/cryptoKeyVersions/{{crypto_key_version}}&#39;
    /// </summary>
    public TerraformExpression KmsKeyVersion => this["kms_key_version"];

    /// <summary>
    /// Location of Parameter Manager Regional parameter resource.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The resource name of the Regional Parameter Version. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/parameters/{{parameter_id}}/versions/{{parameter_version_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time at which the Regional Parameter Version was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
