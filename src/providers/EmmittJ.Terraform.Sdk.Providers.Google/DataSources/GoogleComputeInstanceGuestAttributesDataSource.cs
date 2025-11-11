using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_guest_attributes.
/// </summary>
public partial class GoogleComputeInstanceGuestAttributesDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGuestAttributesDataSource(string name) : base("google_compute_instance_guest_attributes", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The query_path attribute.
    /// </summary>
    [TerraformProperty("query_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryPath { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    [TerraformProperty("variable_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VariableKey { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// The query_value attribute.
    /// </summary>
    [TerraformProperty("query_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> QueryValue { get; }

    /// <summary>
    /// The variable_value attribute.
    /// </summary>
    [TerraformProperty("variable_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VariableValue { get; }

}
