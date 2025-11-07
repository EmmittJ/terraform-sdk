using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_access_context_manager_service_perimeters resource.
/// </summary>
public class GoogleAccessContextManagerServicePerimeters : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeters(string name) : base("google_access_context_manager_service_perimeters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

}
