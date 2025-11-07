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
    public TerraformProperty<List<string>>? BackupRepeatingTimeIntervals
    {
        get => GetProperty<TerraformProperty<List<string>>>("backup_repeating_time_intervals");
        set => this.WithProperty("backup_repeating_time_intervals", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    public TerraformProperty<string>? VaultName
    {
        get => GetProperty<TerraformProperty<string>>("vault_name");
        set => this.WithProperty("vault_name", value);
    }

}
