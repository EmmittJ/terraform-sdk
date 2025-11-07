using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_settings resource.
/// </summary>
public class GoogleIapSettings : TerraformResource
{
    public GoogleIapSettings(string name) : base("google_iap_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The resource name of the IAP protected resource. Name can have below resources:
    /// * organizations/{organization_id}
    /// * folders/{folder_id}
    /// * projects/{project_id}
    /// * projects/{project_id}/iap_web
    /// * projects/{project_id}/iap_web/compute
    /// * projects/{project_id}/iap_web/compute-{region}
    /// * projects/{project_id}/iap_web/compute/services/{service_id}
    /// * projects/{project_id}/iap_web/compute-{region}/services/{service_id}
    /// * projects/{project_id}/iap_web/appengine-{app_id}
    /// * projects/{project_id}/iap_web/appengine-{app_id}/services/{service_id}
    /// * projects/{project_id}/iap_web/appengine-{app_id}/services/{service_id}/version/{version_id}
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
