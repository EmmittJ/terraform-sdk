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
    public TerraformLiteralProperty<string>? AccessLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_level");
        set => this.WithProperty("access_level", value);
    }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DurationInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_in_seconds");
        set => this.WithProperty("duration_in_seconds", value);
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
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedDiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_id");
        set => this.WithProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    public TerraformExpression SasUrl => this["sas_url"];

}
