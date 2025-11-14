using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for retention_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_rule";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformArgument("priority")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_data_protection_backup_policy_blob_storage resource.
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorage : TerraformResource
{
    public AzurermDataProtectionBackupPolicyBlobStorage(string name) : base("azurerm_data_protection_backup_policy_blob_storage", name)
    {
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    [TerraformArgument("backup_repeating_time_intervals")]
    public TerraformList<string>? BackupRepeatingTimeIntervals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "backup_repeating_time_intervals").ResolveNodes(ctx));
        set => SetArgument("backup_repeating_time_intervals", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operational_default_retention_duration attribute.
    /// </summary>
    [TerraformArgument("operational_default_retention_duration")]
    public TerraformValue<string>? OperationalDefaultRetentionDuration
    {
        get => new TerraformReference<string>(this, "operational_default_retention_duration");
        set => SetArgument("operational_default_retention_duration", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The vault_default_retention_duration attribute.
    /// </summary>
    [TerraformArgument("vault_default_retention_duration")]
    public TerraformValue<string>? VaultDefaultRetentionDuration
    {
        get => new TerraformReference<string>(this, "vault_default_retention_duration");
        set => SetArgument("vault_default_retention_duration", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    [TerraformArgument("vault_id")]
    public required TerraformValue<string> VaultId
    {
        get => new TerraformReference<string>(this, "vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// Block for retention_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("retention_rule")]
    public TerraformList<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock> RetentionRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock Timeouts { get; set; } = new();

}
