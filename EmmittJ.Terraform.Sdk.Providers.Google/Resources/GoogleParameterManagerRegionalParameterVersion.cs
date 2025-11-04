using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Parameter Manager Regional Parameter resource.
    /// </summary>
    public string? Parameter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter")?.Value;
        set => this.WithProperty("parameter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Regional Parameter data.
    /// </summary>
    public string? ParameterData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_data")?.Value;
        set => this.WithProperty("parameter_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Version ID of the Regional Parameter Version Resource. This must be unique within the Regional Parameter.
    /// </summary>
    public string? ParameterVersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_version_id")?.Value;
        set => this.WithProperty("parameter_version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
