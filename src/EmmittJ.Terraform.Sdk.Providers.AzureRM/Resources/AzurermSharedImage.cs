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
    public TerraformProperty<bool>? AcceleratedNetworkSupportEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("accelerated_network_support_enabled");
        set => this.WithProperty("accelerated_network_support_enabled", value);
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string>? Architecture
    {
        get => GetProperty<TerraformProperty<string>>("architecture");
        set => this.WithProperty("architecture", value);
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ConfidentialVmEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("confidential_vm_enabled");
        set => this.WithProperty("confidential_vm_enabled", value);
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformProperty<bool>? ConfidentialVmSupported
    {
        get => GetProperty<TerraformProperty<bool>>("confidential_vm_supported");
        set => this.WithProperty("confidential_vm_supported", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiskControllerTypeNvmeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("disk_controller_type_nvme_enabled");
        set => this.WithProperty("disk_controller_type_nvme_enabled", value);
    }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DiskTypesNotAllowed
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("disk_types_not_allowed");
        set => this.WithProperty("disk_types_not_allowed", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndOfLifeDate
    {
        get => GetProperty<TerraformProperty<string>>("end_of_life_date");
        set => this.WithProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformProperty<string>? Eula
    {
        get => GetProperty<TerraformProperty<string>>("eula");
        set => this.WithProperty("eula", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public TerraformProperty<string>? GalleryName
    {
        get => GetProperty<TerraformProperty<string>>("gallery_name");
        set => this.WithProperty("gallery_name", value);
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HibernationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hibernation_enabled");
        set => this.WithProperty("hibernation_enabled", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string>? HyperVGeneration
    {
        get => GetProperty<TerraformProperty<string>>("hyper_v_generation");
        set => this.WithProperty("hyper_v_generation", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRecommendedMemoryInGb
    {
        get => GetProperty<TerraformProperty<double>>("max_recommended_memory_in_gb");
        set => this.WithProperty("max_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRecommendedVcpuCount
    {
        get => GetProperty<TerraformProperty<double>>("max_recommended_vcpu_count");
        set => this.WithProperty("max_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? MinRecommendedMemoryInGb
    {
        get => GetProperty<TerraformProperty<double>>("min_recommended_memory_in_gb");
        set => this.WithProperty("min_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformProperty<double>? MinRecommendedVcpuCount
    {
        get => GetProperty<TerraformProperty<double>>("min_recommended_vcpu_count");
        set => this.WithProperty("min_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformProperty<string>? PrivacyStatementUri
    {
        get => GetProperty<TerraformProperty<string>>("privacy_statement_uri");
        set => this.WithProperty("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseNoteUri
    {
        get => GetProperty<TerraformProperty<string>>("release_note_uri");
        set => this.WithProperty("release_note_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformProperty<bool>? Specialized
    {
        get => GetProperty<TerraformProperty<bool>>("specialized");
        set => this.WithProperty("specialized", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrustedLaunchEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("trusted_launch_enabled");
        set => this.WithProperty("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformProperty<bool>? TrustedLaunchSupported
    {
        get => GetProperty<TerraformProperty<bool>>("trusted_launch_supported");
        set => this.WithProperty("trusted_launch_supported", value);
    }

}
