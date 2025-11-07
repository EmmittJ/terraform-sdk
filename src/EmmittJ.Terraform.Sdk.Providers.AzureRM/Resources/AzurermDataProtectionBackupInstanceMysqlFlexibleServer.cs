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
    public TerraformLiteralProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
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
    /// The server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
