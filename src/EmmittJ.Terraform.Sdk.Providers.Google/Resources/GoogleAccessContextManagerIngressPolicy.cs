using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_ingress_policy resource.
/// </summary>
public class GoogleAccessContextManagerIngressPolicy : TerraformResource
{
    public GoogleAccessContextManagerIngressPolicy(string name) : base("google_access_context_manager_ingress_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_id");
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
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    public TerraformProperty<string>? IngressPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("ingress_policy_name");
        set => this.WithProperty("ingress_policy_name", value);
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
