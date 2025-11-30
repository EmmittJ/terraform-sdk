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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "gallery_name");
        set => SetArgument("gallery_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AcceleratedNetworkSupportEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_network_support_enabled");
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string> Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ConfidentialVmEnabled
    {
        get => new TerraformReference<bool>(this, "confidential_vm_enabled");
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformValue<bool> ConfidentialVmSupported
    {
        get => new TerraformReference<bool>(this, "confidential_vm_supported");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformValue<string> Eula
    {
        get => new TerraformReference<string>(this, "eula");
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HibernationEnabled
    {
        get => new TerraformReference<bool>(this, "hibernation_enabled");
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformValue<string> HyperVGeneration
    {
        get => new TerraformReference<string>(this, "hyper_v_generation");
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identifier
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identifier").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformValue<string> PrivacyStatementUri
    {
        get => new TerraformReference<string>(this, "privacy_statement_uri");
    }

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PurchasePlan
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "purchase_plan").ResolveNodes(ctx));
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformValue<string> ReleaseNoteUri
    {
        get => new TerraformReference<string>(this, "release_note_uri");
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformValue<bool> Specialized
    {
        get => new TerraformReference<bool>(this, "specialized");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TrustedLaunchEnabled
    {
        get => new TerraformReference<bool>(this, "trusted_launch_enabled");
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformValue<bool> TrustedLaunchSupported
    {
        get => new TerraformReference<bool>(this, "trusted_launch_supported");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
