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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
