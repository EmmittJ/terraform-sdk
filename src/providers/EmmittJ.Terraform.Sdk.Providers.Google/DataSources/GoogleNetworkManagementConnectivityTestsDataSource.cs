using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_network_management_connectivity_tests.
/// </summary>
public class GoogleNetworkManagementConnectivityTestsDataSource : TerraformDataSource
{
    public GoogleNetworkManagementConnectivityTestsDataSource(string name) : base("google_network_management_connectivity_tests", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("connectivity_tests");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// Lists the ConnectivityTests that match the filter expression. A filter expression filters the resources listed in the response.
    /// </summary>
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The connectivity_tests attribute.
    /// </summary>
    public TerraformExpression ConnectivityTests => this["connectivity_tests"];

}
