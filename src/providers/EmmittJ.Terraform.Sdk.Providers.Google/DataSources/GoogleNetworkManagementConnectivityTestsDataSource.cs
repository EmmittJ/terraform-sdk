using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_network_management_connectivity_tests Terraform data source.
/// Retrieves information about a google_network_management_connectivity_tests.
/// </summary>
public partial class GoogleNetworkManagementConnectivityTestsDataSource(string name) : TerraformDataSource("google_network_management_connectivity_tests", name)
{
    /// <summary>
    /// Lists the ConnectivityTests that match the filter expression. A filter expression filters the resources listed in the response.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The connectivity_tests attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectivityTests
        => CreateReference("connectivity_tests");

}
