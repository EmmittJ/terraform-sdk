using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_network_management_connectivity_test_run.
/// </summary>
public class GoogleNetworkManagementConnectivityTestRunDataSource : TerraformDataSource
{
    public GoogleNetworkManagementConnectivityTestRunDataSource(string name) : base("google_network_management_connectivity_test_run", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("reachability_details");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Connectivity test reachability details.
    /// </summary>
    public TerraformExpression ReachabilityDetails => this["reachability_details"];

}
