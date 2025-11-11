using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter_version.
/// </summary>
public partial class GoogleParameterManagerParameterVersionDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterVersionDataSource(string name) : base("google_parameter_manager_parameter_version", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformProperty("parameter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parameter { get; set; }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    [TerraformProperty("parameter_version_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ParameterVersionId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Disabled { get; }

    /// <summary>
    /// The kms_key_version attribute.
    /// </summary>
    [TerraformProperty("kms_key_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyVersion { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    [TerraformProperty("parameter_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParameterData { get; }

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
