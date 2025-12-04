using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for features in AzurermProvider.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "features";

    /// <summary>
    /// ApiManagement block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockApiManagementBlock>? ApiManagement
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockApiManagementBlock>>("api_management");
        set => SetArgument("api_management", value);
    }

    /// <summary>
    /// AppConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockAppConfigurationBlock>? AppConfiguration
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockAppConfigurationBlock>>("app_configuration");
        set => SetArgument("app_configuration", value);
    }

    /// <summary>
    /// ApplicationInsights block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockApplicationInsightsBlock>? ApplicationInsights
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockApplicationInsightsBlock>>("application_insights");
        set => SetArgument("application_insights", value);
    }

    /// <summary>
    /// CognitiveAccount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockCognitiveAccountBlock>? CognitiveAccount
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockCognitiveAccountBlock>>("cognitive_account");
        set => SetArgument("cognitive_account", value);
    }

    /// <summary>
    /// DatabricksWorkspace block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockDatabricksWorkspaceBlock>? DatabricksWorkspace
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockDatabricksWorkspaceBlock>>("databricks_workspace");
        set => SetArgument("databricks_workspace", value);
    }

    /// <summary>
    /// KeyVault block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockKeyVaultBlock>? KeyVault
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockKeyVaultBlock>>("key_vault");
        set => SetArgument("key_vault", value);
    }

    /// <summary>
    /// LogAnalyticsWorkspace block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockLogAnalyticsWorkspaceBlock>? LogAnalyticsWorkspace
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockLogAnalyticsWorkspaceBlock>>("log_analytics_workspace");
        set => SetArgument("log_analytics_workspace", value);
    }

    /// <summary>
    /// MachineLearning block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockMachineLearningBlock>? MachineLearning
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockMachineLearningBlock>>("machine_learning");
        set => SetArgument("machine_learning", value);
    }

    /// <summary>
    /// ManagedDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockManagedDiskBlock>? ManagedDisk
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockManagedDiskBlock>>("managed_disk");
        set => SetArgument("managed_disk", value);
    }

    /// <summary>
    /// Netapp block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockNetappBlock>? Netapp
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockNetappBlock>>("netapp");
        set => SetArgument("netapp", value);
    }

    /// <summary>
    /// PostgresqlFlexibleServer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockPostgresqlFlexibleServerBlock>? PostgresqlFlexibleServer
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockPostgresqlFlexibleServerBlock>>("postgresql_flexible_server");
        set => SetArgument("postgresql_flexible_server", value);
    }

    /// <summary>
    /// RecoveryService block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockRecoveryServiceBlock>? RecoveryService
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockRecoveryServiceBlock>>("recovery_service");
        set => SetArgument("recovery_service", value);
    }

    /// <summary>
    /// RecoveryServicesVaults block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockRecoveryServicesVaultsBlock>? RecoveryServicesVaults
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockRecoveryServicesVaultsBlock>>("recovery_services_vaults");
        set => SetArgument("recovery_services_vaults", value);
    }

    /// <summary>
    /// ResourceGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockResourceGroupBlock>? ResourceGroup
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockResourceGroupBlock>>("resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Subscription block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockSubscriptionBlock>? Subscription
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockSubscriptionBlock>>("subscription");
        set => SetArgument("subscription", value);
    }

    /// <summary>
    /// TemplateDeployment block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockTemplateDeploymentBlock>? TemplateDeployment
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockTemplateDeploymentBlock>>("template_deployment");
        set => SetArgument("template_deployment", value);
    }

    /// <summary>
    /// VirtualMachine block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockVirtualMachineBlock>? VirtualMachine
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockVirtualMachineBlock>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

    /// <summary>
    /// VirtualMachineScaleSet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlockVirtualMachineScaleSetBlock>? VirtualMachineScaleSet
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlockVirtualMachineScaleSetBlock>>("virtual_machine_scale_set");
        set => SetArgument("virtual_machine_scale_set", value);
    }

}

/// <summary>
/// Block type for api_management in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockApiManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_management";

    /// <summary>
    /// The purge_soft_delete_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeleteOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_delete_on_destroy");
        set => SetArgument("purge_soft_delete_on_destroy", value);
    }

    /// <summary>
    /// The recover_soft_deleted attribute.
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeleted
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted");
        set => SetArgument("recover_soft_deleted", value);
    }

}

/// <summary>
/// Block type for app_configuration in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockAppConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_configuration";

    /// <summary>
    /// The purge_soft_delete_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeleteOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_delete_on_destroy");
        set => SetArgument("purge_soft_delete_on_destroy", value);
    }

    /// <summary>
    /// The recover_soft_deleted attribute.
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeleted
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted");
        set => SetArgument("recover_soft_deleted", value);
    }

}

/// <summary>
/// Block type for application_insights in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockApplicationInsightsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_insights";

    /// <summary>
    /// The disable_generated_rule attribute.
    /// </summary>
    public TerraformValue<bool>? DisableGeneratedRule
    {
        get => GetArgument<TerraformValue<bool>>("disable_generated_rule");
        set => SetArgument("disable_generated_rule", value);
    }

}

/// <summary>
/// Block type for cognitive_account in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockCognitiveAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognitive_account";

    /// <summary>
    /// The purge_soft_delete_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeleteOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_delete_on_destroy");
        set => SetArgument("purge_soft_delete_on_destroy", value);
    }

}

/// <summary>
/// Block type for databricks_workspace in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockDatabricksWorkspaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "databricks_workspace";

    /// <summary>
    /// When enabled, the managed resource group that contains the Unity Catalog data will be forcibly deleted when the workspace is destroyed, regardless of contents.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("force_delete");
        set => SetArgument("force_delete", value);
    }

}

/// <summary>
/// Block type for key_vault in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockKeyVaultBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_vault";

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault` resources will be permanently deleted (e.g purged), when destroyed
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeleteOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_delete_on_destroy");
        set => SetArgument("purge_soft_delete_on_destroy", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_certificate` resources will be permanently deleted (e.g purged), when destroyed
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeletedCertificatesOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_deleted_certificates_on_destroy");
        set => SetArgument("purge_soft_deleted_certificates_on_destroy", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module_key` resources will be permanently deleted (e.g purged), when destroyed
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeletedHardwareSecurityModuleKeysOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_deleted_hardware_security_module_keys_on_destroy");
        set => SetArgument("purge_soft_deleted_hardware_security_module_keys_on_destroy", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module` resources will be permanently deleted (e.g purged), when destroyed
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeletedHardwareSecurityModulesOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_deleted_hardware_security_modules_on_destroy");
        set => SetArgument("purge_soft_deleted_hardware_security_modules_on_destroy", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_key` resources will be permanently deleted (e.g purged), when destroyed
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeletedKeysOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_deleted_keys_on_destroy");
        set => SetArgument("purge_soft_deleted_keys_on_destroy", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_secret` resources will be permanently deleted (e.g purged), when destroyed
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeletedSecretsOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_deleted_secrets_on_destroy");
        set => SetArgument("purge_soft_deleted_secrets_on_destroy", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_certificate` resources will be restored, instead of creating new ones
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeletedCertificates
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted_certificates");
        set => SetArgument("recover_soft_deleted_certificates", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module_key` resources will be restored, instead of creating new ones
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeletedHardwareSecurityModuleKeys
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted_hardware_security_module_keys");
        set => SetArgument("recover_soft_deleted_hardware_security_module_keys", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault` resources will be restored, instead of creating new ones
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeletedKeyVaults
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted_key_vaults");
        set => SetArgument("recover_soft_deleted_key_vaults", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_key` resources will be restored, instead of creating new ones
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeletedKeys
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted_keys");
        set => SetArgument("recover_soft_deleted_keys", value);
    }

    /// <summary>
    /// When enabled soft-deleted `azurerm_key_vault_secret` resources will be restored, instead of creating new ones
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeletedSecrets
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted_secrets");
        set => SetArgument("recover_soft_deleted_secrets", value);
    }

}

/// <summary>
/// Block type for log_analytics_workspace in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockLogAnalyticsWorkspaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_analytics_workspace";

    /// <summary>
    /// The permanently_delete_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PermanentlyDeleteOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("permanently_delete_on_destroy");
        set => SetArgument("permanently_delete_on_destroy", value);
    }

}

/// <summary>
/// Block type for machine_learning in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockMachineLearningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_learning";

    /// <summary>
    /// The purge_soft_deleted_workspace_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeSoftDeletedWorkspaceOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_soft_deleted_workspace_on_destroy");
        set => SetArgument("purge_soft_deleted_workspace_on_destroy", value);
    }

}

/// <summary>
/// Block type for managed_disk in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockManagedDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_disk";

    /// <summary>
    /// The expand_without_downtime attribute.
    /// </summary>
    public TerraformValue<bool>? ExpandWithoutDowntime
    {
        get => GetArgument<TerraformValue<bool>>("expand_without_downtime");
        set => SetArgument("expand_without_downtime", value);
    }

}

/// <summary>
/// Block type for netapp in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockNetappBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "netapp";

    /// <summary>
    /// When enabled, backups will be deleted when the `azurerm_netapp_backup_vault` resource is destroyed
    /// </summary>
    public TerraformValue<bool>? DeleteBackupsOnBackupVaultDestroy
    {
        get => GetArgument<TerraformValue<bool>>("delete_backups_on_backup_vault_destroy");
        set => SetArgument("delete_backups_on_backup_vault_destroy", value);
    }

    /// <summary>
    /// When enabled, the volume will not be destroyed, safeguarding from severe data loss
    /// </summary>
    public TerraformValue<bool>? PreventVolumeDestruction
    {
        get => GetArgument<TerraformValue<bool>>("prevent_volume_destruction");
        set => SetArgument("prevent_volume_destruction", value);
    }

}

/// <summary>
/// Block type for postgresql_flexible_server in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockPostgresqlFlexibleServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql_flexible_server";

    /// <summary>
    /// The restart_server_on_configuration_value_change attribute.
    /// </summary>
    public TerraformValue<bool>? RestartServerOnConfigurationValueChange
    {
        get => GetArgument<TerraformValue<bool>>("restart_server_on_configuration_value_change");
        set => SetArgument("restart_server_on_configuration_value_change", value);
    }

}

/// <summary>
/// Block type for recovery_service in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockRecoveryServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recovery_service";

    /// <summary>
    /// The purge_protected_items_from_vault_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeProtectedItemsFromVaultOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("purge_protected_items_from_vault_on_destroy");
        set => SetArgument("purge_protected_items_from_vault_on_destroy", value);
    }

    /// <summary>
    /// The vm_backup_stop_protection_and_retain_data_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? VmBackupStopProtectionAndRetainDataOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("vm_backup_stop_protection_and_retain_data_on_destroy");
        set => SetArgument("vm_backup_stop_protection_and_retain_data_on_destroy", value);
    }

    /// <summary>
    /// The vm_backup_suspend_protection_and_retain_data_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? VmBackupSuspendProtectionAndRetainDataOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("vm_backup_suspend_protection_and_retain_data_on_destroy");
        set => SetArgument("vm_backup_suspend_protection_and_retain_data_on_destroy", value);
    }

}

/// <summary>
/// Block type for recovery_services_vaults in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockRecoveryServicesVaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recovery_services_vaults";

    /// <summary>
    /// The recover_soft_deleted_backup_protected_vm attribute.
    /// </summary>
    public TerraformValue<bool>? RecoverSoftDeletedBackupProtectedVm
    {
        get => GetArgument<TerraformValue<bool>>("recover_soft_deleted_backup_protected_vm");
        set => SetArgument("recover_soft_deleted_backup_protected_vm", value);
    }

}

/// <summary>
/// Block type for resource_group in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockResourceGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_group";

    /// <summary>
    /// The prevent_deletion_if_contains_resources attribute.
    /// </summary>
    public TerraformValue<bool>? PreventDeletionIfContainsResources
    {
        get => GetArgument<TerraformValue<bool>>("prevent_deletion_if_contains_resources");
        set => SetArgument("prevent_deletion_if_contains_resources", value);
    }

}

/// <summary>
/// Block type for storage in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// The data_plane_available attribute.
    /// </summary>
    public TerraformValue<bool>? DataPlaneAvailable
    {
        get => GetArgument<TerraformValue<bool>>("data_plane_available");
        set => SetArgument("data_plane_available", value);
    }

}

/// <summary>
/// Block type for subscription in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockSubscriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subscription";

    /// <summary>
    /// The prevent_cancellation_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? PreventCancellationOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("prevent_cancellation_on_destroy");
        set => SetArgument("prevent_cancellation_on_destroy", value);
    }

}

/// <summary>
/// Block type for template_deployment in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockTemplateDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_deployment";

    /// <summary>
    /// The delete_nested_items_during_deletion attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeleteNestedItemsDuringDeletion is required")]
    public required TerraformValue<bool> DeleteNestedItemsDuringDeletion
    {
        get => GetArgument<TerraformValue<bool>>("delete_nested_items_during_deletion");
        set => SetArgument("delete_nested_items_during_deletion", value);
    }

}

/// <summary>
/// Block type for virtual_machine in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine";

    /// <summary>
    /// The delete_os_disk_on_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOsDiskOnDeletion
    {
        get => GetArgument<TerraformValue<bool>>("delete_os_disk_on_deletion");
        set => SetArgument("delete_os_disk_on_deletion", value);
    }

    /// <summary>
    /// The detach_implicit_data_disk_on_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? DetachImplicitDataDiskOnDeletion
    {
        get => GetArgument<TerraformValue<bool>>("detach_implicit_data_disk_on_deletion");
        set => SetArgument("detach_implicit_data_disk_on_deletion", value);
    }

    /// <summary>
    /// The graceful_shutdown attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? GracefulShutdown
    {
        get => GetArgument<TerraformValue<bool>>("graceful_shutdown");
        set => SetArgument("graceful_shutdown", value);
    }

    /// <summary>
    /// The skip_shutdown_and_force_delete attribute.
    /// </summary>
    public TerraformValue<bool>? SkipShutdownAndForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("skip_shutdown_and_force_delete");
        set => SetArgument("skip_shutdown_and_force_delete", value);
    }

}

/// <summary>
/// Block type for virtual_machine_scale_set in AzurermProviderFeaturesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermProviderFeaturesBlockVirtualMachineScaleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_scale_set";

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The reimage_on_manual_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? ReimageOnManualUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("reimage_on_manual_upgrade");
        set => SetArgument("reimage_on_manual_upgrade", value);
    }

    /// <summary>
    /// The roll_instances_when_required attribute.
    /// </summary>
    public TerraformValue<bool>? RollInstancesWhenRequired
    {
        get => GetArgument<TerraformValue<bool>>("roll_instances_when_required");
        set => SetArgument("roll_instances_when_required", value);
    }

    /// <summary>
    /// The scale_to_zero_before_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? ScaleToZeroBeforeDeletion
    {
        get => GetArgument<TerraformValue<bool>>("scale_to_zero_before_deletion");
        set => SetArgument("scale_to_zero_before_deletion", value);
    }

}


/// <summary>
/// Represents the azurerm Terraform provider.
/// Version: ~&gt; 4.0
/// Resources: 1120
/// Data Sources: 399
/// </summary>
public partial class AzurermProvider(string name = "azurerm") : TerraformProvider(name)
{
    /// <summary>
    /// The Azure DevOps Pipeline Service Connection ID.
    /// </summary>
    public TerraformValue<string>? AdoPipelineServiceConnectionId
    {
        get => GetArgument<TerraformValue<string>>("ado_pipeline_service_connection_id");
        set => SetArgument("ado_pipeline_service_connection_id", value);
    }


    /// <summary>
    /// The auxiliary_tenant_ids attribute.
    /// </summary>
    public TerraformList<string>? AuxiliaryTenantIds
    {
        get => GetArgument<TerraformList<string>>("auxiliary_tenant_ids");
        set => SetArgument("auxiliary_tenant_ids", value);
    }


    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => GetArgument<TerraformValue<string>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }


    /// <summary>
    /// The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_password");
        set => SetArgument("client_certificate_password", value);
    }


    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.
    /// </summary>
    public TerraformValue<string>? ClientCertificatePath
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_path");
        set => SetArgument("client_certificate_path", value);
    }


    /// <summary>
    /// The Client ID which should be used.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }


    /// <summary>
    /// The path to a file containing the Client ID which should be used.
    /// </summary>
    public TerraformValue<string>? ClientIdFilePath
    {
        get => GetArgument<TerraformValue<string>>("client_id_file_path");
        set => SetArgument("client_id_file_path", value);
    }


    /// <summary>
    /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }


    /// <summary>
    /// The path to a file containing the Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// </summary>
    public TerraformValue<string>? ClientSecretFilePath
    {
        get => GetArgument<TerraformValue<string>>("client_secret_file_path");
        set => SetArgument("client_secret_file_path", value);
    }


    /// <summary>
    /// This will disable the x-ms-correlation-request-id header.
    /// </summary>
    public TerraformValue<bool>? DisableCorrelationRequestId
    {
        get => GetArgument<TerraformValue<bool>>("disable_correlation_request_id");
        set => SetArgument("disable_correlation_request_id", value);
    }


    /// <summary>
    /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn&#39;t specified.
    /// </summary>
    public TerraformValue<bool>? DisableTerraformPartnerId
    {
        get => GetArgument<TerraformValue<bool>>("disable_terraform_partner_id");
        set => SetArgument("disable_terraform_partner_id", value);
    }


    /// <summary>
    /// The Cloud Environment which should be used. Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when `metadata_host` is specified.
    /// </summary>
    public TerraformValue<string>? Environment
    {
        get => GetArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }


    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// </summary>
    public TerraformValue<string>? MetadataHost
    {
        get => GetArgument<TerraformValue<string>>("metadata_host");
        set => SetArgument("metadata_host", value);
    }


    /// <summary>
    /// The API version to use for Managed Service Identity (IMDS) - for cases where the default API version is not supported by the endpoint. e.g. for Azure Container Apps.
    /// </summary>
    public TerraformValue<string>? MsiApiVersion
    {
        get => GetArgument<TerraformValue<string>>("msi_api_version");
        set => SetArgument("msi_api_version", value);
    }


    /// <summary>
    /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.
    /// </summary>
    public TerraformValue<string>? MsiEndpoint
    {
        get => GetArgument<TerraformValue<string>>("msi_endpoint");
        set => SetArgument("msi_endpoint", value);
    }


    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcRequestToken
    {
        get => GetArgument<TerraformValue<string>>("oidc_request_token");
        set => SetArgument("oidc_request_token", value);
    }


    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcRequestUrl
    {
        get => GetArgument<TerraformValue<string>>("oidc_request_url");
        set => SetArgument("oidc_request_url", value);
    }


    /// <summary>
    /// The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcToken
    {
        get => GetArgument<TerraformValue<string>>("oidc_token");
        set => SetArgument("oidc_token", value);
    }


    /// <summary>
    /// The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcTokenFilePath
    {
        get => GetArgument<TerraformValue<string>>("oidc_token_file_path");
        set => SetArgument("oidc_token_file_path", value);
    }


    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.
    /// </summary>
    public TerraformValue<string>? PartnerId
    {
        get => GetArgument<TerraformValue<string>>("partner_id");
        set => SetArgument("partner_id", value);
    }


    /// <summary>
    /// The set of Resource Providers which should be automatically registered for the subscription.
    /// </summary>
    public TerraformValue<string>? ResourceProviderRegistrations
    {
        get => GetArgument<TerraformValue<string>>("resource_provider_registrations");
        set => SetArgument("resource_provider_registrations", value);
    }


    /// <summary>
    /// A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property.
    /// </summary>
    public TerraformList<string>? ResourceProvidersToRegister
    {
        get => GetArgument<TerraformList<string>>("resource_providers_to_register");
        set => SetArgument("resource_providers_to_register", value);
    }


    /// <summary>
    /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they&#39;re not already registered?
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? SkipProviderRegistration
    {
        get => GetArgument<TerraformValue<bool>>("skip_provider_registration");
        set => SetArgument("skip_provider_registration", value);
    }


    /// <summary>
    /// Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs?
    /// </summary>
    public TerraformValue<bool>? StorageUseAzuread
    {
        get => GetArgument<TerraformValue<bool>>("storage_use_azuread");
        set => SetArgument("storage_use_azuread", value);
    }


    /// <summary>
    /// The Subscription ID which should be used.
    /// </summary>
    public TerraformValue<string>? SubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("subscription_id");
        set => SetArgument("subscription_id", value);
    }


    /// <summary>
    /// The Tenant ID which should be used.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }


    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseAksWorkloadIdentity
    {
        get => GetArgument<TerraformValue<bool>>("use_aks_workload_identity");
        set => SetArgument("use_aks_workload_identity", value);
    }


    /// <summary>
    /// Allow Azure CLI to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseCli
    {
        get => GetArgument<TerraformValue<bool>>("use_cli");
        set => SetArgument("use_cli", value);
    }


    /// <summary>
    /// Allow Managed Service Identity to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseMsi
    {
        get => GetArgument<TerraformValue<bool>>("use_msi");
        set => SetArgument("use_msi", value);
    }


    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// </summary>
    public TerraformValue<bool>? UseOidc
    {
        get => GetArgument<TerraformValue<bool>>("use_oidc");
        set => SetArgument("use_oidc", value);
    }


    /// <summary>
    /// Features block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermProviderFeaturesBlock>? Features
    {
        get => GetArgument<TerraformList<AzurermProviderFeaturesBlock>>("features");
        set => SetArgument("features", value);
    }

}
