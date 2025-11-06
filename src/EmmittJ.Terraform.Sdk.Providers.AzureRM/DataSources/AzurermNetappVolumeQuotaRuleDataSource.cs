using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_quota_rule.
/// </summary>
public class AzurermNetappVolumeQuotaRuleDataSource : TerraformDataSource
{
    public AzurermNetappVolumeQuotaRuleDataSource(string name) : base("azurerm_netapp_volume_quota_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("quota_size_in_kib");
        this.DeclareOutput("quota_target");
        this.DeclareOutput("quota_type");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public string? VolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_id")?.Value;
        set => this.WithProperty("volume_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    public TerraformExpression QuotaSizeInKib => this["quota_size_in_kib"];

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformExpression QuotaTarget => this["quota_target"];

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    public TerraformExpression QuotaType => this["quota_type"];

}
