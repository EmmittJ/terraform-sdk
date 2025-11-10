using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_quotas_quota_infos.
/// </summary>
public class GoogleCloudQuotasQuotaInfosDataSource : TerraformDataSource
{
    public GoogleCloudQuotasQuotaInfosDataSource(string name) : base("google_cloud_quotas_quota_infos", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("quota_infos");
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
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The quota_infos attribute.
    /// </summary>
    public TerraformExpression QuotaInfos => this["quota_infos"];

}
