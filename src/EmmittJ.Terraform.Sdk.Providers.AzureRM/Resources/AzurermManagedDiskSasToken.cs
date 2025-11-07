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
    public TerraformProperty<string>? AccessLevel
    {
        get => GetProperty<TerraformProperty<string>>("access_level");
        set => this.WithProperty("access_level", value);
    }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("duration_in_seconds");
        set => this.WithProperty("duration_in_seconds", value);
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
    /// The managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskId
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_id");
        set => this.WithProperty("managed_disk_id", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    public TerraformExpression SasUrl => this["sas_url"];

}
