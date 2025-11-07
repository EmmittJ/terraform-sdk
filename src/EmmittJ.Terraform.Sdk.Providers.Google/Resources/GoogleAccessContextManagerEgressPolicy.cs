using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("access_policy_id");
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    public TerraformProperty<string>? EgressPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("egress_policy_name");
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
    public TerraformProperty<string>? Resource
    {
        get => GetProperty<TerraformProperty<string>>("resource");
        set => this.WithProperty("resource", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

}
