using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_router_status.
/// </summary>
public class GoogleComputeRouterStatusDataSource : TerraformDataSource
{
    public GoogleComputeRouterStatusDataSource(string name) : base("google_compute_router_status", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("best_routes");
        this.DeclareOutput("best_routes_for_router");
        this.DeclareOutput("network");
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
    /// Name of the router to query.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Best routes for this router&#39;s network.
    /// </summary>
    public TerraformExpression BestRoutes => this["best_routes"];

    /// <summary>
    /// Best routes learned by this router.
    /// </summary>
    public TerraformExpression BestRoutesForRouter => this["best_routes_for_router"];

    /// <summary>
    /// URI of the network to which this router belongs.
    /// </summary>
    public TerraformExpression Network => this["network"];

}
