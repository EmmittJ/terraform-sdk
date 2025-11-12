using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for single_region_keys in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock() : TerraformBlock("single_region_keys")
{
    /// <summary>
    /// Single-regional kms key resource name which will be used to encrypt
    /// resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformProperty("kms_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineCmekConfigTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_cmek_config resource.
/// </summary>
public partial class GoogleDiscoveryEngineCmekConfig : TerraformResource
{
    public GoogleDiscoveryEngineCmekConfig(string name) : base("google_discovery_engine_cmek_config", name)
    {
    }

    /// <summary>
    /// The unique id of the cmek config.
    /// </summary>
    [TerraformProperty("cmek_config_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CmekConfigId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources
    /// &#39;projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformProperty("kms_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKey { get; set; }

    /// <summary>
    /// The geographic location where the CMEK config should reside. The value can
    /// only be one of &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Set the following CmekConfig as the default to be used for child resources
    /// if one is not specified. The default value is true.
    /// </summary>
    [TerraformProperty("set_default")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SetDefault { get; set; }

    /// <summary>
    /// Block for single_region_keys.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("single_region_keys")]
    public TerraformList<GoogleDiscoveryEngineCmekConfigSingleRegionKeysBlock> SingleRegionKeys { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDiscoveryEngineCmekConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default CmekConfig for the Customer.
    /// </summary>
    [TerraformProperty("is_default")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsDefault { get; }

    /// <summary>
    /// KMS key version resource name which will be used to encrypt resources
    /// &#39;&amp;lt;kms_key&amp;gt;/cryptoKeyVersions/{keyVersion}&#39;.
    /// </summary>
    [TerraformProperty("kms_key_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyVersion { get; }

    /// <summary>
    /// The timestamp of the last key rotation.
    /// </summary>
    [TerraformProperty("last_rotation_timestamp_micros")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LastRotationTimestampMicros { get; }

    /// <summary>
    /// The unique full resource name of the cmek config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/cmekConfigs/{cmek_config_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Whether the NotebookLM Corpus is ready to be used.
    /// </summary>
    [TerraformProperty("notebooklm_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotebooklmState { get; }

    /// <summary>
    /// The state of the CmekConfig.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
