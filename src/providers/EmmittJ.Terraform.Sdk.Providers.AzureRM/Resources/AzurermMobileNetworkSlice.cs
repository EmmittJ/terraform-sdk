using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
/// Represents a azurerm_mobile_network_slice Terraform resource.
/// Manages a azurerm_mobile_network_slice resource.
/// </summary>
public partial class AzurermMobileNetworkSlice(string name) : TerraformResource("azurerm_mobile_network_slice", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => new TerraformReference<string>(this, "mobile_network_id");
        set => SetArgument("mobile_network_id", value);
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
    /// The slice_differentiator attribute.
    /// </summary>
    public TerraformValue<string> SliceDifferentiator
    {
        get => new TerraformReference<string>(this, "slice_differentiator");
        set => SetArgument("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    public TerraformValue<double> SliceServiceType
    {
        get => new TerraformReference<double>(this, "slice_service_type");
        set => SetArgument("slice_service_type", value);
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
    /// SingleNetworkSliceSelectionAssistanceInformation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleNetworkSliceSelectionAssistanceInformation block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock>? SingleNetworkSliceSelectionAssistanceInformation
    {
        get => GetArgument<TerraformList<AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock>>("single_network_slice_selection_assistance_information");
        set => SetArgument("single_network_slice_selection_assistance_information", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkSliceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkSliceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
