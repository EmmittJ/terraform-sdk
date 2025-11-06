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
    public string? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter")?.Value;
        set => this.WithProperty("filter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connectivity_tests attribute.
    /// </summary>
    public TerraformExpression ConnectivityTests => this["connectivity_tests"];

}
