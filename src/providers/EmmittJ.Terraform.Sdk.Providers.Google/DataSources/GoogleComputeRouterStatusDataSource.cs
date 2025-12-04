using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_router_status Terraform data source.
/// Retrieves information about a google_compute_router_status.
/// </summary>
public partial class GoogleComputeRouterStatusDataSource(string name) : TerraformDataSource("google_compute_router_status", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the router to query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Best routes for this router&#39;s network.
    /// </summary>
    public TerraformList<TerraformMap<object>> BestRoutes
        => AsReference("best_routes");

    /// <summary>
    /// Best routes learned by this router.
    /// </summary>
    public TerraformList<TerraformMap<object>> BestRoutesForRouter
        => AsReference("best_routes_for_router");

    /// <summary>
    /// URI of the network to which this router belongs.
    /// </summary>
    public TerraformValue<string> Network
        => AsReference("network");

}
