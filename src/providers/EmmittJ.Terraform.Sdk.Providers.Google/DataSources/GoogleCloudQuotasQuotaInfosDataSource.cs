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
        SetOutput("quota_infos");
        SetOutput("id");
        SetOutput("parent");
        SetOutput("service");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The quota_infos attribute.
    /// </summary>
    public TerraformExpression QuotaInfos => this["quota_infos"];

}
