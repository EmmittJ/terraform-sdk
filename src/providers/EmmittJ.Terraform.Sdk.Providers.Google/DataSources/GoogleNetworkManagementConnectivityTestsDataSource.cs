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
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The connectivity_tests attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectivityTests
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connectivity_tests").ResolveNodes(ctx));
    }

}
