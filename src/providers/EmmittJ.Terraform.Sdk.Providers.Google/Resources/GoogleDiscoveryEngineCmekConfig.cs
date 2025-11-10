using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for single_region_keys in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock : ITerraformBlock
{
    /// <summary>
    /// Single-regional kms key resource name which will be used to encrypt
    /// resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineCmekConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? CmekConfigId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKey { get; set; }

    /// <summary>
    /// The geographic location where the CMEK config should reside. The value can
    /// only be one of &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Set the following CmekConfig as the default to be used for child resources
    /// if one is not specified. The default value is true.
    /// </summary>
    [TerraformPropertyName("set_default")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SetDefault { get; set; }

    /// <summary>
    /// Block for single_region_keys.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("single_region_keys")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock>>? SingleRegionKeys { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineCmekConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The default CmekConfig for the Customer.
    /// </summary>
    [TerraformPropertyName("is_default")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsDefault => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_default");

    /// <summary>
    /// KMS key version resource name which will be used to encrypt resources
    /// &#39;&amp;lt;kms_key&amp;gt;/cryptoKeyVersions/{keyVersion}&#39;.
    /// </summary>
    [TerraformPropertyName("kms_key_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_version");

    /// <summary>
    /// The timestamp of the last key rotation.
    /// </summary>
    [TerraformPropertyName("last_rotation_timestamp_micros")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LastRotationTimestampMicros => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "last_rotation_timestamp_micros");

    /// <summary>
    /// The unique full resource name of the cmek config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/cmekConfigs/{cmek_config_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Whether the NotebookLM Corpus is ready to be used.
    /// </summary>
    [TerraformPropertyName("notebooklm_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotebooklmState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "notebooklm_state");

    /// <summary>
    /// The state of the CmekConfig.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
