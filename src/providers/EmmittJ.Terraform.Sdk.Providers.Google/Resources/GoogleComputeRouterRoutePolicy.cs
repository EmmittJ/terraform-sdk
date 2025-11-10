using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for terms in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterRoutePolicyTermsBlock : TerraformBlock
{
    /// <summary>
    /// The evaluation priority for this term, which must be between 0 (inclusive) and 231 (exclusive), and unique within the list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterRoutePolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_router_route_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRouterRoutePolicy : TerraformResource
{
    public GoogleComputeRouterRoutePolicy(string name) : base("google_compute_router_route_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("fingerprint");
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
    /// Name of the route policy. This policy&#39;s name, which must be a resource ID segment and unique within all policies owned by the Router
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Region where the router and NAT reside.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this route policy will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformProperty<string> Router
    {
        get => GetRequiredProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// This is policy&#39;s type, which is one of IMPORT or EXPORT Possible values: [&amp;quot;ROUTE_POLICY_TYPE_IMPORT&amp;quot;, &amp;quot;ROUTE_POLICY_TYPE_EXPORT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for terms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Terms block(s) required")]
    public List<GoogleComputeRouterRoutePolicyTermsBlock>? Terms
    {
        get => GetProperty<List<GoogleComputeRouterRoutePolicyTermsBlock>>("terms");
        set => this.WithProperty("terms", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouterRoutePolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRouterRoutePolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

}
