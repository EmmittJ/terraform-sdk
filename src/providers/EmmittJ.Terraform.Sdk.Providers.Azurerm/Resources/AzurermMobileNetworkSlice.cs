using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for single_network_slice_selection_assistance_information in AzurermMobileNetworkSlice.
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
        get => GetArgument<TerraformValue<string>>("slice_differentiator");
        set => SetArgument("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceServiceType is required")]
    [Obsolete("This property is deprecated.")]
    public required TerraformValue<double> SliceServiceType
    {
        get => GetRequiredArgument<TerraformValue<double>>("slice_service_type");
        set => SetArgument("slice_service_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMobileNetworkSlice.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("mobile_network_id");
        set => SetArgument("mobile_network_id", value);
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
    /// The slice_differentiator attribute.
    /// </summary>
    public TerraformValue<string> SliceDifferentiator
    {
        get => GetArgument<TerraformValue<string>>("slice_differentiator") ?? AsReference("slice_differentiator");
        set => SetArgument("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    public TerraformValue<double> SliceServiceType
    {
        get => GetArgument<TerraformValue<double>>("slice_service_type") ?? AsReference("slice_service_type");
        set => SetArgument("slice_service_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
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
