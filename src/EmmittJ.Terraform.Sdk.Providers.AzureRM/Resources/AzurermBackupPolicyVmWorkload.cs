using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for protection_policy in .
/// Nesting mode: set
/// </summary>
public class AzurermBackupPolicyVmWorkloadProtectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformProperty<string> PolicyType
    {
        get => GetProperty<TerraformProperty<string>>("policy_type");
        set => WithProperty("policy_type", value);
    }

}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AzurermBackupPolicyVmWorkloadSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CompressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("compression_enabled");
        set => WithProperty("compression_enabled", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupPolicyVmWorkloadTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_backup_policy_vm_workload resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBackupPolicyVmWorkload : TerraformResource
{
    public AzurermBackupPolicyVmWorkload(string name) : base("azurerm_backup_policy_vm_workload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The workload_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadType is required")]
    public required TerraformProperty<string> WorkloadType
    {
        get => GetProperty<TerraformProperty<string>>("workload_type");
        set => this.WithProperty("workload_type", value);
    }

    /// <summary>
    /// Block for protection_policy.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProtectionPolicy block(s) required")]
    public HashSet<AzurermBackupPolicyVmWorkloadProtectionPolicyBlock>? ProtectionPolicy
    {
        get => GetProperty<HashSet<AzurermBackupPolicyVmWorkloadProtectionPolicyBlock>>("protection_policy");
        set => this.WithProperty("protection_policy", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public List<AzurermBackupPolicyVmWorkloadSettingsBlock>? Settings
    {
        get => GetProperty<List<AzurermBackupPolicyVmWorkloadSettingsBlock>>("settings");
        set => this.WithProperty("settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBackupPolicyVmWorkloadTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBackupPolicyVmWorkloadTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
