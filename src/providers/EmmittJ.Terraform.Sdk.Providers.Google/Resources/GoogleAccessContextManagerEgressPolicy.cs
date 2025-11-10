using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerEgressPolicyTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_access_context_manager_egress_policy resource.
/// </summary>
public class GoogleAccessContextManagerEgressPolicy : TerraformResource
{
    public GoogleAccessContextManagerEgressPolicy(string name) : base("google_access_context_manager_egress_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_policy_id");
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EgressPolicyName is required")]
    public required TerraformProperty<string> EgressPolicyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("egress_policy_name");
        set => this.WithProperty("egress_policy_name", value);
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
    /// A GCP resource that is inside of the service perimeter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformProperty<string> Resource
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource");
        set => this.WithProperty("resource", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerEgressPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAccessContextManagerEgressPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

}
