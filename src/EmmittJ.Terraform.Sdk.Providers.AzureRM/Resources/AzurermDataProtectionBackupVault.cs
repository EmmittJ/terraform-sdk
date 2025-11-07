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
    public TerraformLiteralProperty<bool>? CrossRegionRestoreEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cross_region_restore_enabled");
        set => this.WithProperty("cross_region_restore_enabled", value);
    }

    /// <summary>
    /// The datastore_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatastoreType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("datastore_type");
        set => this.WithProperty("datastore_type", value);
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
    /// The immutability attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Immutability
    {
        get => GetProperty<TerraformLiteralProperty<string>>("immutability");
        set => this.WithProperty("immutability", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The redundancy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Redundancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redundancy");
        set => this.WithProperty("redundancy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_duration_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionDurationInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_duration_in_days");
        set => this.WithProperty("retention_duration_in_days", value);
    }

    /// <summary>
    /// The soft_delete attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SoftDelete
    {
        get => GetProperty<TerraformLiteralProperty<string>>("soft_delete");
        set => this.WithProperty("soft_delete", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
