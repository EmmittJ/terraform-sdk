using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSharedImageDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_shared_image Terraform data source.
/// Retrieves information about a azurerm_shared_image.
/// </summary>
public partial class AzurermSharedImageDataSource(string name) : TerraformDataSource("azurerm_shared_image", name)
{
    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformValue<string> GalleryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("gallery_name");
        set => SetArgument("gallery_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AcceleratedNetworkSupportEnabled
        => CreateReference("accelerated_network_support_enabled");

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string> Architecture
        => CreateReference("architecture");

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ConfidentialVmEnabled
        => CreateReference("confidential_vm_enabled");

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformValue<bool> ConfidentialVmSupported
        => CreateReference("confidential_vm_supported");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformValue<string> Eula
        => CreateReference("eula");

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HibernationEnabled
        => CreateReference("hibernation_enabled");

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformValue<string> HyperVGeneration
        => CreateReference("hyper_v_generation");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identifier
        => CreateReference("identifier");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
        => CreateReference("os_type");

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformValue<string> PrivacyStatementUri
        => CreateReference("privacy_statement_uri");

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PurchasePlan
        => CreateReference("purchase_plan");

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformValue<string> ReleaseNoteUri
        => CreateReference("release_note_uri");

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformValue<bool> Specialized
        => CreateReference("specialized");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TrustedLaunchEnabled
        => CreateReference("trusted_launch_enabled");

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformValue<bool> TrustedLaunchSupported
        => CreateReference("trusted_launch_supported");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
