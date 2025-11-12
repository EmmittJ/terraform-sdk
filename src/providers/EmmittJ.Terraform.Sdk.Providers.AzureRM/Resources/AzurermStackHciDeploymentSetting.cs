using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for scale_unit in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStackHciDeploymentSettingScaleUnitBlock() : TerraformBlock("scale_unit")
{
    /// <summary>
    /// The active_directory_organizational_unit_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActiveDirectoryOrganizationalUnitPath is required")]
    [TerraformProperty("active_directory_organizational_unit_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ActiveDirectoryOrganizationalUnitPath { get; set; }

    /// <summary>
    /// The bitlocker_boot_volume_enabled attribute.
    /// </summary>
    [TerraformProperty("bitlocker_boot_volume_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BitlockerBootVolumeEnabled { get; set; }

    /// <summary>
    /// The bitlocker_data_volume_enabled attribute.
    /// </summary>
    [TerraformProperty("bitlocker_data_volume_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BitlockerDataVolumeEnabled { get; set; }

    /// <summary>
    /// The credential_guard_enabled attribute.
    /// </summary>
    [TerraformProperty("credential_guard_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CredentialGuardEnabled { get; set; }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainFqdn is required")]
    [TerraformProperty("domain_fqdn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainFqdn { get; set; }

    /// <summary>
    /// The drift_control_enabled attribute.
    /// </summary>
    [TerraformProperty("drift_control_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DriftControlEnabled { get; set; }

    /// <summary>
    /// The drtm_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("drtm_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DrtmProtectionEnabled { get; set; }

    /// <summary>
    /// The episodic_data_upload_enabled attribute.
    /// </summary>
    [TerraformProperty("episodic_data_upload_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EpisodicDataUploadEnabled { get; set; }

    /// <summary>
    /// The eu_location_enabled attribute.
    /// </summary>
    [TerraformProperty("eu_location_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EuLocationEnabled { get; set; }

    /// <summary>
    /// The hvci_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("hvci_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HvciProtectionEnabled { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    [TerraformProperty("name_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The secrets_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretsLocation is required")]
    [TerraformProperty("secrets_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretsLocation { get; set; }

    /// <summary>
    /// The side_channel_mitigation_enabled attribute.
    /// </summary>
    [TerraformProperty("side_channel_mitigation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SideChannelMitigationEnabled { get; set; }

    /// <summary>
    /// The smb_cluster_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("smb_cluster_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmbClusterEncryptionEnabled { get; set; }

    /// <summary>
    /// The smb_signing_enabled attribute.
    /// </summary>
    [TerraformProperty("smb_signing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmbSigningEnabled { get; set; }

    /// <summary>
    /// The streaming_data_client_enabled attribute.
    /// </summary>
    [TerraformProperty("streaming_data_client_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StreamingDataClientEnabled { get; set; }

    /// <summary>
    /// The wdac_enabled attribute.
    /// </summary>
    [TerraformProperty("wdac_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WdacEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStackHciDeploymentSettingTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_stack_hci_deployment_setting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStackHciDeploymentSetting : TerraformResource
{
    public AzurermStackHciDeploymentSetting(string name) : base("azurerm_stack_hci_deployment_setting", name)
    {
    }

    /// <summary>
    /// The arc_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcResourceIds is required")]
    [TerraformProperty("arc_resource_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? ArcResourceIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackHciClusterId is required")]
    [TerraformProperty("stack_hci_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StackHciClusterId { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for scale_unit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleUnit block(s) required")]
    [TerraformProperty("scale_unit")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlock> ScaleUnit { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStackHciDeploymentSettingTimeoutsBlock Timeouts { get; set; } = new();

}
