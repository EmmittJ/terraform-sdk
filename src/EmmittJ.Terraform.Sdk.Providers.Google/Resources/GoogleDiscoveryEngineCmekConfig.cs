using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_cmek_config resource.
/// </summary>
public class GoogleDiscoveryEngineCmekConfig : TerraformResource
{
    public GoogleDiscoveryEngineCmekConfig(string name) : base("google_discovery_engine_cmek_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("is_default");
        this.DeclareOutput("kms_key_version");
        this.DeclareOutput("last_rotation_timestamp_micros");
        this.DeclareOutput("name");
        this.DeclareOutput("notebooklm_state");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The unique id of the cmek config.
    /// </summary>
    public TerraformProperty<string>? CmekConfigId
    {
        get => GetProperty<TerraformProperty<string>>("cmek_config_id");
        set => this.WithProperty("cmek_config_id", value);
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
    /// KMS key resource name which will be used to encrypt resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The geographic location where the CMEK config should reside. The value can
    /// only be one of &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Set the following CmekConfig as the default to be used for child resources
    /// if one is not specified. The default value is true.
    /// </summary>
    public TerraformProperty<bool>? SetDefault
    {
        get => GetProperty<TerraformProperty<bool>>("set_default");
        set => this.WithProperty("set_default", value);
    }

    /// <summary>
    /// The default CmekConfig for the Customer.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

    /// <summary>
    /// KMS key version resource name which will be used to encrypt resources
    /// &#39;&amp;lt;kms_key&amp;gt;/cryptoKeyVersions/{keyVersion}&#39;.
    /// </summary>
    public TerraformExpression KmsKeyVersion => this["kms_key_version"];

    /// <summary>
    /// The timestamp of the last key rotation.
    /// </summary>
    public TerraformExpression LastRotationTimestampMicros => this["last_rotation_timestamp_micros"];

    /// <summary>
    /// The unique full resource name of the cmek config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/cmekConfigs/{cmek_config_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Whether the NotebookLM Corpus is ready to be used.
    /// </summary>
    public TerraformExpression NotebooklmState => this["notebooklm_state"];

    /// <summary>
    /// The state of the CmekConfig.
    /// </summary>
    public TerraformExpression State => this["state"];

}
