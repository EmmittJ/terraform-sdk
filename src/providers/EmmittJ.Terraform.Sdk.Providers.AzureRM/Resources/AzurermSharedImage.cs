using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identifier in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageIdentifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identifier";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

}

/// <summary>
/// Block type for purchase_plan in .
/// Nesting mode: list
/// </summary>
public class AzurermSharedImagePurchasePlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "purchase_plan";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    public TerraformValue<string>? Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformValue<string>? Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_shared_image Terraform resource.
/// Manages a azurerm_shared_image resource.
/// </summary>
public partial class AzurermSharedImage(string name) : TerraformResource("azurerm_shared_image", name)
{
    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AcceleratedNetworkSupportEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_network_support_enabled");
        set => SetArgument("accelerated_network_support_enabled", value);
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string>? Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ConfidentialVmEnabled
    {
        get => new TerraformReference<bool>(this, "confidential_vm_enabled");
        set => SetArgument("confidential_vm_enabled", value);
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformValue<bool>? ConfidentialVmSupported
    {
        get => new TerraformReference<bool>(this, "confidential_vm_supported");
        set => SetArgument("confidential_vm_supported", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disk_controller_type_nvme_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiskControllerTypeNvmeEnabled
    {
        get => new TerraformReference<bool>(this, "disk_controller_type_nvme_enabled");
        set => SetArgument("disk_controller_type_nvme_enabled", value);
    }

    /// <summary>
    /// The disk_types_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? DiskTypesNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "disk_types_not_allowed").ResolveNodes(ctx));
        set => SetArgument("disk_types_not_allowed", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformValue<string>? EndOfLifeDate
    {
        get => new TerraformReference<string>(this, "end_of_life_date");
        set => SetArgument("end_of_life_date", value);
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformValue<string>? Eula
    {
        get => new TerraformReference<string>(this, "eula");
        set => SetArgument("eula", value);
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformValue<string> GalleryName
    {
        get => new TerraformReference<string>(this, "gallery_name");
        set => SetArgument("gallery_name", value);
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HibernationEnabled
    {
        get => new TerraformReference<bool>(this, "hibernation_enabled");
        set => SetArgument("hibernation_enabled", value);
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformValue<string>? HyperVGeneration
    {
        get => new TerraformReference<string>(this, "hyper_v_generation");
        set => SetArgument("hyper_v_generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? MaxRecommendedMemoryInGb
    {
        get => new TerraformReference<double>(this, "max_recommended_memory_in_gb");
        set => SetArgument("max_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The max_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxRecommendedVcpuCount
    {
        get => new TerraformReference<double>(this, "max_recommended_vcpu_count");
        set => SetArgument("max_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The min_recommended_memory_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? MinRecommendedMemoryInGb
    {
        get => new TerraformReference<double>(this, "min_recommended_memory_in_gb");
        set => SetArgument("min_recommended_memory_in_gb", value);
    }

    /// <summary>
    /// The min_recommended_vcpu_count attribute.
    /// </summary>
    public TerraformValue<double>? MinRecommendedVcpuCount
    {
        get => new TerraformReference<double>(this, "min_recommended_vcpu_count");
        set => SetArgument("min_recommended_vcpu_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformValue<string>? PrivacyStatementUri
    {
        get => new TerraformReference<string>(this, "privacy_statement_uri");
        set => SetArgument("privacy_statement_uri", value);
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformValue<string>? ReleaseNoteUri
    {
        get => new TerraformReference<string>(this, "release_note_uri");
        set => SetArgument("release_note_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformValue<bool>? Specialized
    {
        get => new TerraformReference<bool>(this, "specialized");
        set => SetArgument("specialized", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrustedLaunchEnabled
    {
        get => new TerraformReference<bool>(this, "trusted_launch_enabled");
        set => SetArgument("trusted_launch_enabled", value);
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformValue<bool>? TrustedLaunchSupported
    {
        get => new TerraformReference<bool>(this, "trusted_launch_supported");
        set => SetArgument("trusted_launch_supported", value);
    }

    /// <summary>
    /// Identifier block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identifier block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identifier block(s) allowed")]
    public required TerraformList<AzurermSharedImageIdentifierBlock> Identifier
    {
        get => GetRequiredArgument<TerraformList<AzurermSharedImageIdentifierBlock>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// PurchasePlan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PurchasePlan block(s) allowed")]
    public TerraformList<AzurermSharedImagePurchasePlanBlock>? PurchasePlan
    {
        get => GetArgument<TerraformList<AzurermSharedImagePurchasePlanBlock>>("purchase_plan");
        set => SetArgument("purchase_plan", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
