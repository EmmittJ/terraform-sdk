using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for scale_unit in .
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_organizational_unit_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActiveDirectoryOrganizationalUnitPath is required")]
    public required TerraformProperty<string> ActiveDirectoryOrganizationalUnitPath
    {
        get => GetProperty<TerraformProperty<string>>("active_directory_organizational_unit_path");
        set => WithProperty("active_directory_organizational_unit_path", value);
    }

    /// <summary>
    /// The bitlocker_boot_volume_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BitlockerBootVolumeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bitlocker_boot_volume_enabled");
        set => WithProperty("bitlocker_boot_volume_enabled", value);
    }

    /// <summary>
    /// The bitlocker_data_volume_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BitlockerDataVolumeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bitlocker_data_volume_enabled");
        set => WithProperty("bitlocker_data_volume_enabled", value);
    }

    /// <summary>
    /// The credential_guard_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CredentialGuardEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("credential_guard_enabled");
        set => WithProperty("credential_guard_enabled", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainFqdn is required")]
    public required TerraformProperty<string> DomainFqdn
    {
        get => GetProperty<TerraformProperty<string>>("domain_fqdn");
        set => WithProperty("domain_fqdn", value);
    }

    /// <summary>
    /// The drift_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DriftControlEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("drift_control_enabled");
        set => WithProperty("drift_control_enabled", value);
    }

    /// <summary>
    /// The drtm_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DrtmProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("drtm_protection_enabled");
        set => WithProperty("drtm_protection_enabled", value);
    }

    /// <summary>
    /// The episodic_data_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EpisodicDataUploadEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("episodic_data_upload_enabled");
        set => WithProperty("episodic_data_upload_enabled", value);
    }

    /// <summary>
    /// The eu_location_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EuLocationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("eu_location_enabled");
        set => WithProperty("eu_location_enabled", value);
    }

    /// <summary>
    /// The hvci_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HvciProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hvci_protection_enabled");
        set => WithProperty("hvci_protection_enabled", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    public required TerraformProperty<string> NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The secrets_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretsLocation is required")]
    public required TerraformProperty<string> SecretsLocation
    {
        get => GetProperty<TerraformProperty<string>>("secrets_location");
        set => WithProperty("secrets_location", value);
    }

    /// <summary>
    /// The side_channel_mitigation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SideChannelMitigationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("side_channel_mitigation_enabled");
        set => WithProperty("side_channel_mitigation_enabled", value);
    }

    /// <summary>
    /// The smb_cluster_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmbClusterEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb_cluster_encryption_enabled");
        set => WithProperty("smb_cluster_encryption_enabled", value);
    }

    /// <summary>
    /// The smb_signing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmbSigningEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb_signing_enabled");
        set => WithProperty("smb_signing_enabled", value);
    }

    /// <summary>
    /// The streaming_data_client_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StreamingDataClientEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("streaming_data_client_enabled");
        set => WithProperty("streaming_data_client_enabled", value);
    }

    /// <summary>
    /// The wdac_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WdacEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("wdac_enabled");
        set => WithProperty("wdac_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciDeploymentSettingTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stack_hci_deployment_setting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStackHciDeploymentSetting : TerraformResource
{
    public AzurermStackHciDeploymentSetting(string name) : base("azurerm_stack_hci_deployment_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arc_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcResourceIds is required")]
    public List<TerraformProperty<string>>? ArcResourceIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("arc_resource_ids");
        set => this.WithProperty("arc_resource_ids", value);
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
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackHciClusterId is required")]
    public required TerraformProperty<string> StackHciClusterId
    {
        get => GetProperty<TerraformProperty<string>>("stack_hci_cluster_id");
        set => this.WithProperty("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for scale_unit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleUnit block(s) required")]
    public List<AzurermStackHciDeploymentSettingScaleUnitBlock>? ScaleUnit
    {
        get => GetProperty<List<AzurermStackHciDeploymentSettingScaleUnitBlock>>("scale_unit");
        set => this.WithProperty("scale_unit", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciDeploymentSettingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStackHciDeploymentSettingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
