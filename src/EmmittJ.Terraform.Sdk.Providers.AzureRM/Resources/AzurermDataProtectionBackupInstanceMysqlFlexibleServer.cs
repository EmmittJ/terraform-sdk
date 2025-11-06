using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_mysql_flexible_server resource.
/// </summary>
public class AzurermDataProtectionBackupInstanceMysqlFlexibleServer : TerraformResource
{
    public AzurermDataProtectionBackupInstanceMysqlFlexibleServer(string name) : base("azurerm_data_protection_backup_instance_mysql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public string? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id")?.Value;
        set => this.WithProperty("backup_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
