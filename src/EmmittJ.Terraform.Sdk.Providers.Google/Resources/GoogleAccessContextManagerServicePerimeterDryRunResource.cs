using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_dry_run_resource resource.
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunResource : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterDryRunResource(string name) : base("google_access_context_manager_service_perimeter_dry_run_resource", name)
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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    public TerraformProperty<string>? PerimeterName
    {
        get => GetProperty<TerraformProperty<string>>("perimeter_name");
        set => this.WithProperty("perimeter_name", value);
    }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
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

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of perimeter resources on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of resources. The resource to add or remove is merged into that list and then this etag is sent with the PATCH call along with the updated resource list.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
