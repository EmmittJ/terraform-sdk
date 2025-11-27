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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the router to query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Best routes for this router&#39;s network.
    /// </summary>
    public TerraformList<TerraformMap<object>> BestRoutes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "best_routes").ResolveNodes(ctx));
    }

    /// <summary>
    /// Best routes learned by this router.
    /// </summary>
    public TerraformList<TerraformMap<object>> BestRoutesForRouter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "best_routes_for_router").ResolveNodes(ctx));
    }

    /// <summary>
    /// URI of the network to which this router belongs.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

}
