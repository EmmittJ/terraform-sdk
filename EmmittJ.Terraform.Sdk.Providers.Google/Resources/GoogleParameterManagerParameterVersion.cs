using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("kms_key_version");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The current state of Parameter Version. This field is only applicable for updating Parameter Version.
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
    /// Parameter Manager Parameter resource.
    /// </summary>
    public string? Parameter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter")?.Value;
        set => this.WithProperty("parameter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Parameter data.
    /// </summary>
    public string? ParameterData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_data")?.Value;
        set => this.WithProperty("parameter_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Version ID of the Parameter Version Resource. This must be unique within the Parameter.
    /// </summary>
    public string? ParameterVersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_version_id")?.Value;
        set => this.WithProperty("parameter_version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
