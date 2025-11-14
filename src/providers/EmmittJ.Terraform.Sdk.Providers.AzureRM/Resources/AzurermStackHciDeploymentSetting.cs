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
/// Block type for scale_unit in .
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_unit";

    /// <summary>
    /// The active_directory_organizational_unit_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActiveDirectoryOrganizationalUnitPath is required")]
    [TerraformArgument("active_directory_organizational_unit_path")]
    public required TerraformValue<string> ActiveDirectoryOrganizationalUnitPath
    {
        get => new TerraformReference<string>(this, "active_directory_organizational_unit_path");
        set => SetArgument("active_directory_organizational_unit_path", value);
    }

    /// <summary>
    /// The bitlocker_boot_volume_enabled attribute.
    /// </summary>
    [TerraformArgument("bitlocker_boot_volume_enabled")]
    public TerraformValue<bool>? BitlockerBootVolumeEnabled
    {
        get => new TerraformReference<bool>(this, "bitlocker_boot_volume_enabled");
        set => SetArgument("bitlocker_boot_volume_enabled", value);
    }

    /// <summary>
    /// The bitlocker_data_volume_enabled attribute.
    /// </summary>
    [TerraformArgument("bitlocker_data_volume_enabled")]
    public TerraformValue<bool>? BitlockerDataVolumeEnabled
    {
        get => new TerraformReference<bool>(this, "bitlocker_data_volume_enabled");
        set => SetArgument("bitlocker_data_volume_enabled", value);
    }

    /// <summary>
    /// The credential_guard_enabled attribute.
    /// </summary>
    [TerraformArgument("credential_guard_enabled")]
    public TerraformValue<bool>? CredentialGuardEnabled
    {
        get => new TerraformReference<bool>(this, "credential_guard_enabled");
        set => SetArgument("credential_guard_enabled", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainFqdn is required")]
    [TerraformArgument("domain_fqdn")]
    public required TerraformValue<string> DomainFqdn
    {
        get => new TerraformReference<string>(this, "domain_fqdn");
        set => SetArgument("domain_fqdn", value);
    }

    /// <summary>
    /// The drift_control_enabled attribute.
    /// </summary>
    [TerraformArgument("drift_control_enabled")]
    public TerraformValue<bool>? DriftControlEnabled
    {
        get => new TerraformReference<bool>(this, "drift_control_enabled");
        set => SetArgument("drift_control_enabled", value);
    }

    /// <summary>
    /// The drtm_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("drtm_protection_enabled")]
    public TerraformValue<bool>? DrtmProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "drtm_protection_enabled");
        set => SetArgument("drtm_protection_enabled", value);
    }

    /// <summary>
    /// The episodic_data_upload_enabled attribute.
    /// </summary>
    [TerraformArgument("episodic_data_upload_enabled")]
    public TerraformValue<bool>? EpisodicDataUploadEnabled
    {
        get => new TerraformReference<bool>(this, "episodic_data_upload_enabled");
        set => SetArgument("episodic_data_upload_enabled", value);
    }

    /// <summary>
    /// The eu_location_enabled attribute.
    /// </summary>
    [TerraformArgument("eu_location_enabled")]
    public TerraformValue<bool>? EuLocationEnabled
    {
        get => new TerraformReference<bool>(this, "eu_location_enabled");
        set => SetArgument("eu_location_enabled", value);
    }

    /// <summary>
    /// The hvci_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("hvci_protection_enabled")]
    public TerraformValue<bool>? HvciProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "hvci_protection_enabled");
        set => SetArgument("hvci_protection_enabled", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    [TerraformArgument("name_prefix")]
    public required TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The secrets_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretsLocation is required")]
    [TerraformArgument("secrets_location")]
    public required TerraformValue<string> SecretsLocation
    {
        get => new TerraformReference<string>(this, "secrets_location");
        set => SetArgument("secrets_location", value);
    }

    /// <summary>
    /// The side_channel_mitigation_enabled attribute.
    /// </summary>
    [TerraformArgument("side_channel_mitigation_enabled")]
    public TerraformValue<bool>? SideChannelMitigationEnabled
    {
        get => new TerraformReference<bool>(this, "side_channel_mitigation_enabled");
        set => SetArgument("side_channel_mitigation_enabled", value);
    }

    /// <summary>
    /// The smb_cluster_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("smb_cluster_encryption_enabled")]
    public TerraformValue<bool>? SmbClusterEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "smb_cluster_encryption_enabled");
        set => SetArgument("smb_cluster_encryption_enabled", value);
    }

    /// <summary>
    /// The smb_signing_enabled attribute.
    /// </summary>
    [TerraformArgument("smb_signing_enabled")]
    public TerraformValue<bool>? SmbSigningEnabled
    {
        get => new TerraformReference<bool>(this, "smb_signing_enabled");
        set => SetArgument("smb_signing_enabled", value);
    }

    /// <summary>
    /// The streaming_data_client_enabled attribute.
    /// </summary>
    [TerraformArgument("streaming_data_client_enabled")]
    public TerraformValue<bool>? StreamingDataClientEnabled
    {
        get => new TerraformReference<bool>(this, "streaming_data_client_enabled");
        set => SetArgument("streaming_data_client_enabled", value);
    }

    /// <summary>
    /// The wdac_enabled attribute.
    /// </summary>
    [TerraformArgument("wdac_enabled")]
    public TerraformValue<bool>? WdacEnabled
    {
        get => new TerraformReference<bool>(this, "wdac_enabled");
        set => SetArgument("wdac_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciDeploymentSettingTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("arc_resource_ids")]
    public TerraformList<string>? ArcResourceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "arc_resource_ids").ResolveNodes(ctx));
        set => SetArgument("arc_resource_ids", value);
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
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackHciClusterId is required")]
    [TerraformArgument("stack_hci_cluster_id")]
    public required TerraformValue<string> StackHciClusterId
    {
        get => new TerraformReference<string>(this, "stack_hci_cluster_id");
        set => SetArgument("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for scale_unit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleUnit block(s) required")]
    [TerraformArgument("scale_unit")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlock> ScaleUnit { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStackHciDeploymentSettingTimeoutsBlock Timeouts { get; set; } = new();

}
