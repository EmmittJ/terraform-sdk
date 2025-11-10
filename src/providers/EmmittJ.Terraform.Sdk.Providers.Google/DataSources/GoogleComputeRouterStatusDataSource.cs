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
        SetOutput("best_routes");
        SetOutput("best_routes_for_router");
        SetOutput("network");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
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
    /// Name of the router to query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Project ID of the target router.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Region of the target router.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
