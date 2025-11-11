using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_apphub_discovered_workload.
/// </summary>
public class GoogleApphubDiscoveredWorkloadDataSource : TerraformDataSource
{
    public GoogleApphubDiscoveredWorkloadDataSource(string name) : base("google_apphub_discovered_workload", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The workload_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadUri is required")]
    [TerraformPropertyName("workload_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkloadUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The workload_properties attribute.
    /// </summary>
    [TerraformPropertyName("workload_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkloadProperties => new TerraformReference(this, "workload_properties");

    /// <summary>
    /// The workload_reference attribute.
    /// </summary>
    [TerraformPropertyName("workload_reference")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkloadReference => new TerraformReference(this, "workload_reference");

}
