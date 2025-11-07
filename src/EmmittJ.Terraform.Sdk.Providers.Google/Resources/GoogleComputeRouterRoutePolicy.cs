using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_router_route_policy resource.
/// </summary>
public class GoogleComputeRouterRoutePolicy : TerraformResource
{
    public GoogleComputeRouterRoutePolicy(string name) : base("google_compute_router_route_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fingerprint");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Name of the route policy. This policy&#39;s name, which must be a resource ID segment and unique within all policies owned by the Router
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where the router and NAT reside.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this route policy will be configured.
    /// </summary>
    public TerraformLiteralProperty<string>? Router
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// This is policy&#39;s type, which is one of IMPORT or EXPORT Possible values: [&amp;quot;ROUTE_POLICY_TYPE_IMPORT&amp;quot;, &amp;quot;ROUTE_POLICY_TYPE_EXPORT&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

}
