using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleParameterManagerParameterVersionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_parameter_manager_parameter_version resource.
/// </summary>
public partial class GoogleParameterManagerParameterVersion : TerraformResource
{
    public GoogleParameterManagerParameterVersion(string name) : base("google_parameter_manager_parameter_version", name)
    {
    }

    /// <summary>
    /// The current state of Parameter Version. This field is only applicable for updating Parameter Version.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Parameter Manager Parameter resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformProperty("parameter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parameter { get; set; }

    /// <summary>
    /// The Parameter data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterData is required")]
    [TerraformProperty("parameter_data")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParameterData { get; set; }

    /// <summary>
    /// Version ID of the Parameter Version Resource. This must be unique within the Parameter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    [TerraformProperty("parameter_version_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParameterVersionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleParameterManagerParameterVersionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time at which the Parameter Version was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKeyVersion used to decrypt parameter version payload. Format
    /// &#39;projects/{{project}}/locations/global/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}/cryptoKeyVersions/{{crypto_key_version}}&#39;
    /// </summary>
    [TerraformProperty("kms_key_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyVersion { get; }

    /// <summary>
    /// The resource name of the Parameter Version. Format:
    /// &#39;projects/{{project}}/locations/global/parameters/{{parameter_id}}/versions/{{parameter_version_id}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The time at which the Parameter Version was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
