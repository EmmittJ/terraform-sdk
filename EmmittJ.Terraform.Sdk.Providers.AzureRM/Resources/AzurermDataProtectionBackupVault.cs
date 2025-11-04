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
    public bool? CrossRegionRestoreEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cross_region_restore_enabled")?.Value;
        set => this.WithProperty("cross_region_restore_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The datastore_type attribute.
    /// </summary>
    public string? DatastoreType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("datastore_type")?.Value;
        set => this.WithProperty("datastore_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The immutability attribute.
    /// </summary>
    public string? Immutability
    {
        get => GetProperty<TerraformLiteralProperty<string>>("immutability")?.Value;
        set => this.WithProperty("immutability", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The redundancy attribute.
    /// </summary>
    public string? Redundancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redundancy")?.Value;
        set => this.WithProperty("redundancy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The retention_duration_in_days attribute.
    /// </summary>
    public double? RetentionDurationInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_duration_in_days")?.Value;
        set => this.WithProperty("retention_duration_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The soft_delete attribute.
    /// </summary>
    public string? SoftDelete
    {
        get => GetProperty<TerraformLiteralProperty<string>>("soft_delete")?.Value;
        set => this.WithProperty("soft_delete", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
