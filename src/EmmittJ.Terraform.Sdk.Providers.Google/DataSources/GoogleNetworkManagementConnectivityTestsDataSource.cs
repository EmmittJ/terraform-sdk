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
        this.DeclareOutput("connectivity_tests");
    }

    /// <summary>
    /// Lists the ConnectivityTests that match the filter expression. A filter expression filters the resources listed in the response.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The connectivity_tests attribute.
    /// </summary>
    public TerraformExpression ConnectivityTests => this["connectivity_tests"];

}
