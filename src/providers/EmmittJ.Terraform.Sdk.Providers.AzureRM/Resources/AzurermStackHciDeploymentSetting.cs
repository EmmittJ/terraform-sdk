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
        set => SetProperty("active_directory_organizational_unit_path", value);
    }

    /// <summary>
    /// The bitlocker_boot_volume_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BitlockerBootVolumeEnabled
    {
        set => SetProperty("bitlocker_boot_volume_enabled", value);
    }

    /// <summary>
    /// The bitlocker_data_volume_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BitlockerDataVolumeEnabled
    {
        set => SetProperty("bitlocker_data_volume_enabled", value);
    }

    /// <summary>
    /// The credential_guard_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CredentialGuardEnabled
    {
        set => SetProperty("credential_guard_enabled", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainFqdn is required")]
    public required TerraformProperty<string> DomainFqdn
    {
        set => SetProperty("domain_fqdn", value);
    }

    /// <summary>
    /// The drift_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DriftControlEnabled
    {
        set => SetProperty("drift_control_enabled", value);
    }

    /// <summary>
    /// The drtm_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DrtmProtectionEnabled
    {
        set => SetProperty("drtm_protection_enabled", value);
    }

    /// <summary>
    /// The episodic_data_upload_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EpisodicDataUploadEnabled
    {
        set => SetProperty("episodic_data_upload_enabled", value);
    }

    /// <summary>
    /// The eu_location_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EuLocationEnabled
    {
        set => SetProperty("eu_location_enabled", value);
    }

    /// <summary>
    /// The hvci_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HvciProtectionEnabled
    {
        set => SetProperty("hvci_protection_enabled", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    public required TerraformProperty<string> NamePrefix
    {
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The secrets_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretsLocation is required")]
    public required TerraformProperty<string> SecretsLocation
    {
        set => SetProperty("secrets_location", value);
    }

    /// <summary>
    /// The side_channel_mitigation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SideChannelMitigationEnabled
    {
        set => SetProperty("side_channel_mitigation_enabled", value);
    }

    /// <summary>
    /// The smb_cluster_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmbClusterEncryptionEnabled
    {
        set => SetProperty("smb_cluster_encryption_enabled", value);
    }

    /// <summary>
    /// The smb_signing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmbSigningEnabled
    {
        set => SetProperty("smb_signing_enabled", value);
    }

    /// <summary>
    /// The streaming_data_client_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StreamingDataClientEnabled
    {
        set => SetProperty("streaming_data_client_enabled", value);
    }

    /// <summary>
    /// The wdac_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WdacEnabled
    {
        set => SetProperty("wdac_enabled", value);
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
        SetOutput("arc_resource_ids");
        SetOutput("id");
        SetOutput("stack_hci_cluster_id");
        SetOutput("version");
    }

    /// <summary>
    /// The arc_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcResourceIds is required")]
    public List<TerraformProperty<string>> ArcResourceIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("arc_resource_ids");
        set => SetProperty("arc_resource_ids", value);
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
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackHciClusterId is required")]
    public required TerraformProperty<string> StackHciClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_hci_cluster_id");
        set => SetProperty("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for scale_unit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleUnit block(s) required")]
    public List<AzurermStackHciDeploymentSettingScaleUnitBlock>? ScaleUnit
    {
        set => SetProperty("scale_unit", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciDeploymentSettingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
