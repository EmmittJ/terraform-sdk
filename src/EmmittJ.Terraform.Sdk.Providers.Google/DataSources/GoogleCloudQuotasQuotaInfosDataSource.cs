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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The quota_infos attribute.
    /// </summary>
    public TerraformExpression QuotaInfos => this["quota_infos"];

}
