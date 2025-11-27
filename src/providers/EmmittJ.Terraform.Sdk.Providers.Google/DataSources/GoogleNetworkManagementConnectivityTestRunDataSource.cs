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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Connectivity test reachability details.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReachabilityDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "reachability_details").ResolveNodes(ctx));
    }

}
