using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identifier in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageIdentifierBlock : TerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        set => SetProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        set => SetProperty("sku", value);
    }

}

/// <summary>
/// Block type for purchase_plan in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImagePurchasePlanBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    public TerraformProperty<string>? Product
    {
        set => SetProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformProperty<string>? Publisher
    {
        set => SetProperty("publisher", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_shared_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSharedImage : TerraformResource
{
    public AzurermSharedImage(string name) : base("azurerm_shared_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("accelerated_network_support_enabled");
        SetOutput("architecture");
        SetOutput("confidential_vm_enabled");
        SetOutput("confidential_vm_supported");
        SetOutput("description");
        SetOutput("disk_controller_type_nvme_enabled");
        SetOutput("disk_types_not_allowed");
        SetOutput("end_of_life_date");
        SetOutput("eula");
        SetOutput("gallery_name");
        SetOutput("hibernation_enabled");
        SetOutput("hyper_v_generation");
        SetOutput("id");
        SetOutput("location");
        SetOutput("max_recommended_memory_in_gb");
        SetOutput("max_recommended_vcpu_count");
        SetOutput("min_recommended_memory_in_gb");
        SetOutput("min_recommended_vcpu_count");
        SetOutput("name");
        SetOutput("os_type");
        SetOutput("privacy_statement_uri");
        SetOutput("release_note_uri");
        SetOutput("resource_group_name");
        SetOutput("specialized");
        SetOutput("tags");
        SetOutput("trusted_launch_enabled");
        SetOutput("trusted_launch_supported");
    }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AcceleratedNetworkSupportEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("accelerated_network_support_enabled");
        set => SetProperty("accelerated_network_support_enabled", value);
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string> Architecture
    {
        get => GetRequiredOutput<TerraformProperty<string>>("architecture");
        set => SetProperty("architecture", value);
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ConfidentialVmEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("confidential_vm_enabled");
        set => SetProperty("confidential_vm_enabled", value);
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformProperty<bool> ConfidentialVmSupported
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("confidential_vm_supported");
        set => SetProperty("confidential_vm_supported", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DiskControllerTypeNvmeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disk_controller_type_nvme_enabled");
        set => SetProperty("disk_controller_type_nvme_enabled", value);
    }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DiskTypesNotAllowed
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("disk_types_not_allowed");
        set => SetProperty("disk_types_not_allowed", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string> EndOfLifeDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_of_life_date");
        set => SetProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformProperty<string> Eula
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eula");
        set => SetProperty("eula", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformProperty<string> GalleryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_name");
        set => SetProperty("gallery_name", value);
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HibernationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hibernation_enabled");
        set => SetProperty("hibernation_enabled", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformProperty<string> HyperVGeneration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hyper_v_generation");
        set => SetProperty("hyper_v_generation", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformProperty<double> MaxRecommendedMemoryInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_recommended_memory_in_gb");
        set => SetProperty("max_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformProperty<double> MaxRecommendedVcpuCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_recommended_vcpu_count");
        set => SetProperty("max_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformProperty<double> MinRecommendedMemoryInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_recommended_memory_in_gb");
        set => SetProperty("min_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformProperty<double> MinRecommendedVcpuCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_recommended_vcpu_count");
        set => SetProperty("min_recommended_vcpu_count", value);
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
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformProperty<string> OsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_type");
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformProperty<string> PrivacyStatementUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("privacy_statement_uri");
        set => SetProperty("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformProperty<string> ReleaseNoteUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_note_uri");
        set => SetProperty("release_note_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformProperty<bool> Specialized
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("specialized");
        set => SetProperty("specialized", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TrustedLaunchEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("trusted_launch_enabled");
        set => SetProperty("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformProperty<bool> TrustedLaunchSupported
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("trusted_launch_supported");
        set => SetProperty("trusted_launch_supported", value);
    }

    /// <summary>
    /// Block for identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identifier block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identifier block(s) allowed")]
    public List<AzurermSharedImageIdentifierBlock>? Identifier
    {
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// Block for purchase_plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PurchasePlan block(s) allowed")]
    public List<AzurermSharedImagePurchasePlanBlock>? PurchasePlan
    {
        set => SetProperty("purchase_plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSharedImageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
