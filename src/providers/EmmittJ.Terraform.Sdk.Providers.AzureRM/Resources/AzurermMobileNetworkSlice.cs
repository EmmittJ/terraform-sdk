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
/// Block type for single_network_slice_selection_assistance_information in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_network_slice_selection_assistance_information";

    /// <summary>
    /// The slice_differentiator attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("slice_differentiator")]
    public TerraformValue<string>? SliceDifferentiator
    {
        get => new TerraformReference<string>(this, "slice_differentiator");
        set => SetArgument("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceServiceType is required")]
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("slice_service_type")]
    public required TerraformValue<double> SliceServiceType
    {
        get => new TerraformReference<double>(this, "slice_service_type");
        set => SetArgument("slice_service_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSliceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mobile_network_slice resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkSlice : TerraformResource
{
    public AzurermMobileNetworkSlice(string name) : base("azurerm_mobile_network_slice", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    [TerraformArgument("mobile_network_id")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => new TerraformReference<string>(this, "mobile_network_id");
        set => SetArgument("mobile_network_id", value);
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
    /// The slice_differentiator attribute.
    /// </summary>
    [TerraformArgument("slice_differentiator")]
    public TerraformValue<string> SliceDifferentiator
    {
        get => new TerraformReference<string>(this, "slice_differentiator");
        set => SetArgument("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    [TerraformArgument("slice_service_type")]
    public TerraformValue<double> SliceServiceType
    {
        get => new TerraformReference<double>(this, "slice_service_type");
        set => SetArgument("slice_service_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for single_network_slice_selection_assistance_information.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleNetworkSliceSelectionAssistanceInformation block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("single_network_slice_selection_assistance_information")]
    public TerraformList<AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock> SingleNetworkSliceSelectionAssistanceInformation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkSliceTimeoutsBlock Timeouts { get; set; } = new();

}
