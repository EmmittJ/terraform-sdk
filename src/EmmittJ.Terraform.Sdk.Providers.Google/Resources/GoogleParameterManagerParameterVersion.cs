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
    /// Parameter Manager Parameter resource.
    /// </summary>
    public TerraformProperty<string>? Parameter
    {
        get => GetProperty<TerraformProperty<string>>("parameter");
        set => this.WithProperty("parameter", value);
    }

    /// <summary>
    /// The Parameter data.
    /// </summary>
    public TerraformProperty<string>? ParameterData
    {
        get => GetProperty<TerraformProperty<string>>("parameter_data");
        set => this.WithProperty("parameter_data", value);
    }

    /// <summary>
    /// Version ID of the Parameter Version Resource. This must be unique within the Parameter.
    /// </summary>
    public TerraformProperty<string>? ParameterVersionId
    {
        get => GetProperty<TerraformProperty<string>>("parameter_version_id");
        set => this.WithProperty("parameter_version_id", value);
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
