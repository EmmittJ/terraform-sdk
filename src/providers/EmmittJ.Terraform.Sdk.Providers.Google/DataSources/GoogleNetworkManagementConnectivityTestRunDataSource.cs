using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_network_management_connectivity_test_run.
/// </summary>
public partial class GoogleNetworkManagementConnectivityTestRunDataSource : TerraformDataSource
{
    public GoogleNetworkManagementConnectivityTestRunDataSource(string name) : base("google_network_management_connectivity_test_run", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Connectivity test reachability details.
    /// </summary>
    [TerraformProperty("reachability_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReachabilityDetails { get; }

}
