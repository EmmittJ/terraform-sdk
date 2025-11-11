using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_guest_attributes.
/// </summary>
public class GoogleComputeInstanceGuestAttributesDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGuestAttributesDataSource(string name) : base("google_compute_instance_guest_attributes", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The query_path attribute.
    /// </summary>
    [TerraformPropertyName("query_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueryPath { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    [TerraformPropertyName("variable_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VariableKey { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Zone { get; set; } = default!;

    /// <summary>
    /// The query_value attribute.
    /// </summary>
    [TerraformPropertyName("query_value")]
    // Output-only attribute - read-only reference
    public TerraformList<object> QueryValue => new TerraformReference(this, "query_value");

    /// <summary>
    /// The variable_value attribute.
    /// </summary>
    [TerraformPropertyName("variable_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VariableValue => new TerraformReference(this, "variable_value");

}
