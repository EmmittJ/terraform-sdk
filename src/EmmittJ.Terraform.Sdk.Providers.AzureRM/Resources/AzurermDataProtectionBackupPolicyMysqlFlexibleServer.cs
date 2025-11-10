using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for default_retention_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock : TerraformBlock
{
}

/// <summary>
/// Block type for retention_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_data_protection_backup_policy_mysql_flexible_server resource.
/// </summary>
public class AzurermDataProtectionBackupPolicyMysqlFlexibleServer : TerraformResource
{
    public AzurermDataProtectionBackupPolicyMysqlFlexibleServer(string name) : base("azurerm_data_protection_backup_policy_mysql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRepeatingTimeIntervals is required")]
    public List<TerraformProperty<string>>? BackupRepeatingTimeIntervals
    {
        get => GetProperty<List<TerraformProperty<string>>>("backup_repeating_time_intervals");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

    /// <summary>
    /// Block for default_retention_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultRetentionRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRetentionRule block(s) allowed")]
    public List<AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock>? DefaultRetentionRule
    {
        get => GetProperty<List<AzurermDataProtectionBackupPolicyMysqlFlexibleServerDefaultRetentionRuleBlock>>("default_retention_rule");
        set => this.WithProperty("default_retention_rule", value);
    }

    /// <summary>
    /// Block for retention_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock>? RetentionRule
    {
        get => GetProperty<List<AzurermDataProtectionBackupPolicyMysqlFlexibleServerRetentionRuleBlock>>("retention_rule");
        set => this.WithProperty("retention_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupPolicyMysqlFlexibleServerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataProtectionBackupPolicyMysqlFlexibleServerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
