using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_services_vault_hyperv_site resource.
/// </summary>
public class AzurermSiteRecoveryServicesVaultHypervSite : TerraformResource
{
    public AzurermSiteRecoveryServicesVaultHypervSite(string name) : base("azurerm_site_recovery_services_vault_hyperv_site", name)
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public string? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id")?.Value;
        set => this.WithProperty("recovery_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
