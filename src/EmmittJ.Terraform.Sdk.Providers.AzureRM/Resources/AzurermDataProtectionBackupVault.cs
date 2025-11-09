using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_vault resource.
/// </summary>
public class AzurermDataProtectionBackupVault : TerraformResource
{
    public AzurermDataProtectionBackupVault(string name) : base("azurerm_data_protection_backup_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossRegionRestoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cross_region_restore_enabled");
        set => this.WithProperty("cross_region_restore_enabled", value);
    }

    /// <summary>
    /// The datastore_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatastoreType
    {
        get => GetProperty<TerraformProperty<string>>("datastore_type");
        set => this.WithProperty("datastore_type", value);
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
    /// The immutability attribute.
    /// </summary>
    public TerraformProperty<string>? Immutability
    {
        get => GetProperty<TerraformProperty<string>>("immutability");
        set => this.WithProperty("immutability", value);
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
    /// The redundancy attribute.
    /// </summary>
    public TerraformProperty<string>? Redundancy
    {
        get => GetProperty<TerraformProperty<string>>("redundancy");
        set => this.WithProperty("redundancy", value);
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
    /// The retention_duration_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionDurationInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_duration_in_days");
        set => this.WithProperty("retention_duration_in_days", value);
    }

    /// <summary>
    /// The soft_delete attribute.
    /// </summary>
    public TerraformProperty<string>? SoftDelete
    {
        get => GetProperty<TerraformProperty<string>>("soft_delete");
        set => this.WithProperty("soft_delete", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
