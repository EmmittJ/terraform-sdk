using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for single_region_keys in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock
{
    /// <summary>
    /// Single-regional kms key resource name which will be used to encrypt
    /// resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineCmekConfigTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_cmek_config resource.
/// </summary>
public class GoogleDiscoveryEngineCmekConfig : TerraformResource
{
    public GoogleDiscoveryEngineCmekConfig(string name) : base("google_discovery_engine_cmek_config", name)
    {
    }

    /// <summary>
    /// The unique id of the cmek config.
    /// </summary>
    [TerraformPropertyName("cmek_config_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CmekConfigId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KmsKey { get; set; }

    /// <summary>
    /// The geographic location where the CMEK config should reside. The value can
    /// only be one of &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Set the following CmekConfig as the default to be used for child resources
    /// if one is not specified. The default value is true.
    /// </summary>
    [TerraformPropertyName("set_default")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SetDefault { get; set; }

    /// <summary>
    /// Block for single_region_keys.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("single_region_keys")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock>>? SingleRegionKeys { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineCmekConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The default CmekConfig for the Customer.
    /// </summary>
    [TerraformPropertyName("is_default")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsDefault => new TerraformReference(this, "is_default");

    /// <summary>
    /// KMS key version resource name which will be used to encrypt resources
    /// &#39;&amp;lt;kms_key&amp;gt;/cryptoKeyVersions/{keyVersion}&#39;.
    /// </summary>
    [TerraformPropertyName("kms_key_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyVersion => new TerraformReference(this, "kms_key_version");

    /// <summary>
    /// The timestamp of the last key rotation.
    /// </summary>
    [TerraformPropertyName("last_rotation_timestamp_micros")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LastRotationTimestampMicros => new TerraformReference(this, "last_rotation_timestamp_micros");

    /// <summary>
    /// The unique full resource name of the cmek config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/cmekConfigs/{cmek_config_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Whether the NotebookLM Corpus is ready to be used.
    /// </summary>
    [TerraformPropertyName("notebooklm_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotebooklmState => new TerraformReference(this, "notebooklm_state");

    /// <summary>
    /// The state of the CmekConfig.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
