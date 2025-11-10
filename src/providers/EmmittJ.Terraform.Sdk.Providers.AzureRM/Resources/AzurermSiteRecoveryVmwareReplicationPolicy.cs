using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryVmwareReplicationPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replication_policy resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicationPolicy : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicationPolicy(string name) : base("azurerm_site_recovery_vmware_replication_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_consistent_snapshot_frequency_in_minutes");
        SetOutput("id");
        SetOutput("name");
        SetOutput("recovery_point_retention_in_minutes");
        SetOutput("recovery_vault_id");
    }

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationConsistentSnapshotFrequencyInMinutes is required")]
    public required TerraformProperty<double> ApplicationConsistentSnapshotFrequencyInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("application_consistent_snapshot_frequency_in_minutes");
        set => SetProperty("application_consistent_snapshot_frequency_in_minutes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointRetentionInMinutes is required")]
    public required TerraformProperty<double> RecoveryPointRetentionInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("recovery_point_retention_in_minutes");
        set => SetProperty("recovery_point_retention_in_minutes", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_id");
        set => SetProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicationPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
