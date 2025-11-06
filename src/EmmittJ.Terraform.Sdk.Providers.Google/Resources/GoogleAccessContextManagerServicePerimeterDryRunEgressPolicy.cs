using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_dry_run_egress_policy resource.
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunEgressPolicy : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterDryRunEgressPolicy(string name) : base("google_access_context_manager_service_perimeter_dry_run_egress_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_id");
        this.DeclareOutput("etag");
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
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    public string? Perimeter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("perimeter")?.Value;
        set => this.WithProperty("perimeter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public string? Title
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title")?.Value;
        set => this.WithProperty("title", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of policies on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of policies. The policy defined in this resource is added or removed from that list, and then this etag is sent with the PATCH call along with the updated policies.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
