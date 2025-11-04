using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_resource resource.
/// </summary>
public class GoogleAccessContextManagerServicePerimeterResource : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterResource(string name) : base("google_access_context_manager_service_perimeter_resource", name)
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
    public string? PerimeterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("perimeter_name")?.Value;
        set => this.WithProperty("perimeter_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
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

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of perimeter resources on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of resources. The resource to add or remove is merged into that list and then this etag is sent with the PATCH call along with the updated resource list.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
