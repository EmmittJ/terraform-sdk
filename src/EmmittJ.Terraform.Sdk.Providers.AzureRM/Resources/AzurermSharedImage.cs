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
    public TerraformLiteralProperty<bool>? AcceleratedNetworkSupportEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("accelerated_network_support_enabled");
        set => this.WithProperty("accelerated_network_support_enabled", value);
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Architecture
    {
        get => GetProperty<TerraformLiteralProperty<string>>("architecture");
        set => this.WithProperty("architecture", value);
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ConfidentialVmEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("confidential_vm_enabled");
        set => this.WithProperty("confidential_vm_enabled", value);
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ConfidentialVmSupported
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("confidential_vm_supported");
        set => this.WithProperty("confidential_vm_supported", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DiskControllerTypeNvmeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disk_controller_type_nvme_enabled");
        set => this.WithProperty("disk_controller_type_nvme_enabled", value);
    }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DiskTypesNotAllowed
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disk_types_not_allowed");
        set => this.WithProperty("disk_types_not_allowed", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndOfLifeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_of_life_date");
        set => this.WithProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Eula
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eula");
        set => this.WithProperty("eula", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GalleryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_name");
        set => this.WithProperty("gallery_name", value);
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HibernationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hibernation_enabled");
        set => this.WithProperty("hibernation_enabled", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HyperVGeneration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hyper_v_generation");
        set => this.WithProperty("hyper_v_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxRecommendedMemoryInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_recommended_memory_in_gb");
        set => this.WithProperty("max_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxRecommendedVcpuCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_recommended_vcpu_count");
        set => this.WithProperty("max_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinRecommendedMemoryInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_recommended_memory_in_gb");
        set => this.WithProperty("min_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinRecommendedVcpuCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_recommended_vcpu_count");
        set => this.WithProperty("min_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivacyStatementUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("privacy_statement_uri");
        set => this.WithProperty("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReleaseNoteUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_note_uri");
        set => this.WithProperty("release_note_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Specialized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("specialized");
        set => this.WithProperty("specialized", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TrustedLaunchEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trusted_launch_enabled");
        set => this.WithProperty("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TrustedLaunchSupported
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trusted_launch_supported");
        set => this.WithProperty("trusted_launch_supported", value);
    }

}
