using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_managed_disk_sas_token resource.
/// </summary>
public class AzurermManagedDiskSasToken : TerraformResource
{
    public AzurermManagedDiskSasToken(string name) : base("azurerm_managed_disk_sas_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sas_url");
    }

    /// <summary>
    /// The access_level attribute.
    /// </summary>
    public string? AccessLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_level")?.Value;
        set => this.WithProperty("access_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    public double? DurationInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_in_seconds")?.Value;
        set => this.WithProperty("duration_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The managed_disk_id attribute.
    /// </summary>
    public string? ManagedDiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_id")?.Value;
        set => this.WithProperty("managed_disk_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    public TerraformExpression SasUrl => this["sas_url"];

}
