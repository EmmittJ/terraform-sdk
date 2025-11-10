using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for single_region_keys in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock : TerraformBlock
{
    /// <summary>
    /// Single-regional kms key resource name which will be used to encrypt
    /// resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformProperty<string> KmsKey
    {
        set => SetProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineCmekConfigTimeoutsBlock : TerraformBlock
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
        SetOutput("is_default");
        SetOutput("kms_key_version");
        SetOutput("last_rotation_timestamp_micros");
        SetOutput("name");
        SetOutput("notebooklm_state");
        SetOutput("state");
        SetOutput("cmek_config_id");
        SetOutput("id");
        SetOutput("kms_key");
        SetOutput("location");
        SetOutput("project");
        SetOutput("set_default");
    }

    /// <summary>
    /// The unique id of the cmek config.
    /// </summary>
    public TerraformProperty<string> CmekConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cmek_config_id");
        set => SetProperty("cmek_config_id", value);
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
    /// KMS key resource name which will be used to encrypt resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The geographic location where the CMEK config should reside. The value can
    /// only be one of &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Set the following CmekConfig as the default to be used for child resources
    /// if one is not specified. The default value is true.
    /// </summary>
    public TerraformProperty<bool> SetDefault
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("set_default");
        set => SetProperty("set_default", value);
    }

    /// <summary>
    /// Block for single_region_keys.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock>? SingleRegionKeys
    {
        set => SetProperty("single_region_keys", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineCmekConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
