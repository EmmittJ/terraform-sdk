using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_network_management_connectivity_test_run Terraform data source.
/// Retrieves information about a google_network_management_connectivity_test_run.
/// </summary>
public partial class GoogleNetworkManagementConnectivityTestRunDataSource(string name) : TerraformDataSource("google_network_management_connectivity_test_run", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Connectivity test reachability details.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReachabilityDetails
        => AsReference("reachability_details");

}
