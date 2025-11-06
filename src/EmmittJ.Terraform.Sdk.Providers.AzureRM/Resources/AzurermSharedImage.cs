using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_shared_image resource.
/// </summary>
public class AzurermSharedImage : TerraformResource
{
    public AzurermSharedImage(string name) : base("azurerm_shared_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    public bool? AcceleratedNetworkSupportEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("accelerated_network_support_enabled")?.Value;
        set => this.WithProperty("accelerated_network_support_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public string? Architecture
    {
        get => GetProperty<TerraformLiteralProperty<string>>("architecture")?.Value;
        set => this.WithProperty("architecture", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public bool? ConfidentialVmEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("confidential_vm_enabled")?.Value;
        set => this.WithProperty("confidential_vm_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public bool? ConfidentialVmSupported
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("confidential_vm_supported")?.Value;
        set => this.WithProperty("confidential_vm_supported", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    public bool? DiskControllerTypeNvmeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disk_controller_type_nvme_enabled")?.Value;
        set => this.WithProperty("disk_controller_type_nvme_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    public HashSet<string>? DiskTypesNotAllowed
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disk_types_not_allowed")?.Value;
        set => this.WithProperty("disk_types_not_allowed", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public string? EndOfLifeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_of_life_date")?.Value;
        set => this.WithProperty("end_of_life_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public string? Eula
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eula")?.Value;
        set => this.WithProperty("eula", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public string? GalleryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_name")?.Value;
        set => this.WithProperty("gallery_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public bool? HibernationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hibernation_enabled")?.Value;
        set => this.WithProperty("hibernation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public string? HyperVGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyper_v_generation")?.Value;
        set => this.WithProperty("hyper_v_generation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    public double? MaxRecommendedMemoryInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_recommended_memory_in_gb")?.Value;
        set => this.WithProperty("max_recommended_memory_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    public double? MaxRecommendedVcpuCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_recommended_vcpu_count")?.Value;
        set => this.WithProperty("max_recommended_vcpu_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    public double? MinRecommendedMemoryInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_recommended_memory_in_gb")?.Value;
        set => this.WithProperty("min_recommended_memory_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    public double? MinRecommendedVcpuCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_recommended_vcpu_count")?.Value;
        set => this.WithProperty("min_recommended_vcpu_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public string? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type")?.Value;
        set => this.WithProperty("os_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public string? PrivacyStatementUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_uri")?.Value;
        set => this.WithProperty("privacy_statement_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public string? ReleaseNoteUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_note_uri")?.Value;
        set => this.WithProperty("release_note_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public bool? Specialized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("specialized")?.Value;
        set => this.WithProperty("specialized", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public bool? TrustedLaunchEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trusted_launch_enabled")?.Value;
        set => this.WithProperty("trusted_launch_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public bool? TrustedLaunchSupported
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trusted_launch_supported")?.Value;
        set => this.WithProperty("trusted_launch_supported", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
