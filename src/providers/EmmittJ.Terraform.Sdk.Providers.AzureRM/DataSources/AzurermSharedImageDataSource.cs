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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image.
/// </summary>
public class AzurermSharedImageDataSource : TerraformDataSource
{
    public AzurermSharedImageDataSource(string name) : base("azurerm_shared_image", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformArgument("gallery_name")]
    public required TerraformValue<string> GalleryName
    {
        get => new TerraformReference<string>(this, "gallery_name");
        set => SetArgument("gallery_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSharedImageDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    [TerraformArgument("accelerated_network_support_enabled")]
    public TerraformValue<bool> AcceleratedNetworkSupportEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_network_support_enabled");
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformArgument("architecture")]
    public TerraformValue<string> Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
    }

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    [TerraformArgument("confidential_vm_enabled")]
    public TerraformValue<bool> ConfidentialVmEnabled
    {
        get => new TerraformReference<bool>(this, "confidential_vm_enabled");
    }

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    [TerraformArgument("confidential_vm_supported")]
    public TerraformValue<bool> ConfidentialVmSupported
    {
        get => new TerraformReference<bool>(this, "confidential_vm_supported");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [TerraformArgument("eula")]
    public TerraformValue<string> Eula
    {
        get => new TerraformReference<string>(this, "eula");
    }

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    [TerraformArgument("hibernation_enabled")]
    public TerraformValue<bool> HibernationEnabled
    {
        get => new TerraformReference<bool>(this, "hibernation_enabled");
    }

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    [TerraformArgument("hyper_v_generation")]
    public TerraformValue<string> HyperVGeneration
    {
        get => new TerraformReference<string>(this, "hyper_v_generation");
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformArgument("identifier")]
    public TerraformList<object> Identifier
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identifier").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformArgument("os_type")]
    public TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
    }

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    [TerraformArgument("privacy_statement_uri")]
    public TerraformValue<string> PrivacyStatementUri
    {
        get => new TerraformReference<string>(this, "privacy_statement_uri");
    }

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    [TerraformArgument("purchase_plan")]
    public TerraformList<object> PurchasePlan
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "purchase_plan").ResolveNodes(ctx));
    }

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    [TerraformArgument("release_note_uri")]
    public TerraformValue<string> ReleaseNoteUri
    {
        get => new TerraformReference<string>(this, "release_note_uri");
    }

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    [TerraformArgument("specialized")]
    public TerraformValue<bool> Specialized
    {
        get => new TerraformReference<bool>(this, "specialized");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    [TerraformArgument("trusted_launch_enabled")]
    public TerraformValue<bool> TrustedLaunchEnabled
    {
        get => new TerraformReference<bool>(this, "trusted_launch_enabled");
    }

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    [TerraformArgument("trusted_launch_supported")]
    public TerraformValue<bool> TrustedLaunchSupported
    {
        get => new TerraformReference<bool>(this, "trusted_launch_supported");
    }

}
