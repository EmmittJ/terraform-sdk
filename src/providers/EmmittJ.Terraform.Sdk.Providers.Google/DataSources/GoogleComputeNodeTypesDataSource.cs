using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_node_types.
/// </summary>
public partial class GoogleComputeNodeTypesDataSource : TerraformDataSource
{
    public GoogleComputeNodeTypesDataSource(string name) : base("google_compute_node_types", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformProperty("names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Names { get; }

}
