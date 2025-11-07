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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    public TerraformProperty<double>? QuotaSizeInKib
    {
        get => GetProperty<TerraformProperty<double>>("quota_size_in_kib");
        set => this.WithProperty("quota_size_in_kib", value);
    }

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformProperty<string>? QuotaTarget
    {
        get => GetProperty<TerraformProperty<string>>("quota_target");
        set => this.WithProperty("quota_target", value);
    }

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    public TerraformProperty<string>? QuotaType
    {
        get => GetProperty<TerraformProperty<string>>("quota_type");
        set => this.WithProperty("quota_type", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeId
    {
        get => GetProperty<TerraformProperty<string>>("volume_id");
        set => this.WithProperty("volume_id", value);
    }

}
