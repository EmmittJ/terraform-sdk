using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_recovery_services_vault_resource_guard_association resource.
/// </summary>
public class AzurermRecoveryServicesVaultResourceGuardAssociation : TerraformResource
{
    public AzurermRecoveryServicesVaultResourceGuardAssociation(string name) : base("azurerm_recovery_services_vault_resource_guard_association", name)
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
    /// The resource_guard_id attribute.
    /// </summary>
    public string? ResourceGuardId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_guard_id")?.Value;
        set => this.WithProperty("resource_guard_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    public string? VaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_id")?.Value;
        set => this.WithProperty("vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
