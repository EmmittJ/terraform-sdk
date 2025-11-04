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
    public string? EgressPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("egress_policy_name")?.Value;
        set => this.WithProperty("egress_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// </summary>
    public string? Resource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource")?.Value;
        set => this.WithProperty("resource", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

}
