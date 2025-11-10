using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for scale_unit in .
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlock : ITerraformBlock
{
    /// <summary>
    /// The active_directory_organizational_unit_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActiveDirectoryOrganizationalUnitPath is required")]
    [TerraformPropertyName("active_directory_organizational_unit_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ActiveDirectoryOrganizationalUnitPath { get; set; }

    /// <summary>
    /// The bitlocker_boot_volume_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bitlocker_boot_volume_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BitlockerBootVolumeEnabled { get; set; }

    /// <summary>
    /// The bitlocker_data_volume_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bitlocker_data_volume_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BitlockerDataVolumeEnabled { get; set; }

    /// <summary>
    /// The credential_guard_enabled attribute.
    /// </summary>
    [TerraformPropertyName("credential_guard_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CredentialGuardEnabled { get; set; }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainFqdn is required")]
    [TerraformPropertyName("domain_fqdn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainFqdn { get; set; }

    /// <summary>
    /// The drift_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("drift_control_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DriftControlEnabled { get; set; }

    /// <summary>
    /// The drtm_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("drtm_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DrtmProtectionEnabled { get; set; }

    /// <summary>
    /// The episodic_data_upload_enabled attribute.
    /// </summary>
    [TerraformPropertyName("episodic_data_upload_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EpisodicDataUploadEnabled { get; set; }

    /// <summary>
    /// The eu_location_enabled attribute.
    /// </summary>
    [TerraformPropertyName("eu_location_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EuLocationEnabled { get; set; }

    /// <summary>
    /// The hvci_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("hvci_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HvciProtectionEnabled { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    [TerraformPropertyName("name_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; }

    /// <summary>
    /// The secrets_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretsLocation is required")]
    [TerraformPropertyName("secrets_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecretsLocation { get; set; }

    /// <summary>
    /// The side_channel_mitigation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("side_channel_mitigation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SideChannelMitigationEnabled { get; set; }

    /// <summary>
    /// The smb_cluster_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("smb_cluster_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbClusterEncryptionEnabled { get; set; }

    /// <summary>
    /// The smb_signing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("smb_signing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbSigningEnabled { get; set; }

    /// <summary>
    /// The streaming_data_client_enabled attribute.
    /// </summary>
    [TerraformPropertyName("streaming_data_client_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StreamingDataClientEnabled { get; set; }

    /// <summary>
    /// The wdac_enabled attribute.
    /// </summary>
    [TerraformPropertyName("wdac_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WdacEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciDeploymentSettingTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_stack_hci_deployment_setting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStackHciDeploymentSetting : TerraformResource
{
    public AzurermStackHciDeploymentSetting(string name) : base("azurerm_stack_hci_deployment_setting", name)
    {
    }

    /// <summary>
    /// The arc_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcResourceIds is required")]
    [TerraformPropertyName("arc_resource_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ArcResourceIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackHciClusterId is required")]
    [TerraformPropertyName("stack_hci_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StackHciClusterId { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// Block for scale_unit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleUnit block(s) required")]
    [TerraformPropertyName("scale_unit")]
    public TerraformList<TerraformBlock<AzurermStackHciDeploymentSettingScaleUnitBlock>>? ScaleUnit { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStackHciDeploymentSettingTimeoutsBlock>? Timeouts { get; set; } = new();

}
