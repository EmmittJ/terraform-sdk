using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_policy_kubernetes_cluster resource.
/// </summary>
public class AzurermDataProtectionBackupPolicyKubernetesCluster : TerraformResource
{
    public AzurermDataProtectionBackupPolicyKubernetesCluster(string name) : base("azurerm_data_protection_backup_policy_kubernetes_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    public List<string>? BackupRepeatingTimeIntervals
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("backup_repeating_time_intervals")?.Value;
        set => this.WithProperty("backup_repeating_time_intervals", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    public string? VaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_name")?.Value;
        set => this.WithProperty("vault_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
