using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for single_region_keys in GoogleDiscoveryEngineCmekConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_region_keys";

    /// <summary>
    /// Single-regional kms key resource name which will be used to encrypt
    /// resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineCmekConfig.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineCmekConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_discovery_engine_cmek_config Terraform resource.
/// Manages a google_discovery_engine_cmek_config resource.
/// </summary>
public partial class GoogleDiscoveryEngineCmekConfig(string name) : TerraformResource("google_discovery_engine_cmek_config", name)
{
    /// <summary>
    /// The unique id of the cmek config.
    /// </summary>
    public TerraformValue<string>? CmekConfigId
    {
        get => GetArgument<TerraformValue<string>>("cmek_config_id");
        set => SetArgument("cmek_config_id", value);
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
    /// KMS key resource name which will be used to encrypt resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The geographic location where the CMEK config should reside. The value can
    /// only be one of &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
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
    /// Set the following CmekConfig as the default to be used for child resources
    /// if one is not specified. The default value is true.
    /// </summary>
    public TerraformValue<bool>? SetDefault
    {
        get => GetArgument<TerraformValue<bool>>("set_default");
        set => SetArgument("set_default", value);
    }

    /// <summary>
    /// The default CmekConfig for the Customer.
    /// </summary>
    public TerraformValue<bool> IsDefault
        => CreateReference("is_default");

    /// <summary>
    /// KMS key version resource name which will be used to encrypt resources
    /// &#39;&amp;lt;kms_key&amp;gt;/cryptoKeyVersions/{keyVersion}&#39;.
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
        => CreateReference("kms_key_version");

    /// <summary>
    /// The timestamp of the last key rotation.
    /// </summary>
    public TerraformValue<double> LastRotationTimestampMicros
        => CreateReference("last_rotation_timestamp_micros");

    /// <summary>
    /// The unique full resource name of the cmek config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/cmekConfigs/{cmek_config_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Whether the NotebookLM Corpus is ready to be used.
    /// </summary>
    public TerraformValue<string> NotebooklmState
        => CreateReference("notebooklm_state");

    /// <summary>
    /// The state of the CmekConfig.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// SingleRegionKeys block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock>? SingleRegionKeys
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock>>("single_region_keys");
        set => SetArgument("single_region_keys", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineCmekConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineCmekConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
