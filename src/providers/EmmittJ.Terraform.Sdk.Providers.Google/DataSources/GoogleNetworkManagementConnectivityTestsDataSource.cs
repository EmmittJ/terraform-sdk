using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_network_management_connectivity_tests.
/// </summary>
public class GoogleNetworkManagementConnectivityTestsDataSource : TerraformDataSource
{
    public GoogleNetworkManagementConnectivityTestsDataSource(string name) : base("google_network_management_connectivity_tests", name)
    {
    }

    /// <summary>
    /// Lists the ConnectivityTests that match the filter expression. A filter expression filters the resources listed in the response.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The connectivity_tests attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_tests")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConnectivityTests => new TerraformReference(this, "connectivity_tests");

}
