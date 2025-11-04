using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_netapp_volume_quota_rule resource.
/// </summary>
public class AzurermNetappVolumeQuotaRule : TerraformResource
{
    public AzurermNetappVolumeQuotaRule(string name) : base("azurerm_netapp_volume_quota_rule", name)
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    public double? QuotaSizeInKib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("quota_size_in_kib")?.Value;
        set => this.WithProperty("quota_size_in_kib", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public string? QuotaTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_target")?.Value;
        set => this.WithProperty("quota_target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    public string? QuotaType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_type")?.Value;
        set => this.WithProperty("quota_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public string? VolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_id")?.Value;
        set => this.WithProperty("volume_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
