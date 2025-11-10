using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for single_network_slice_selection_assistance_information in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock : TerraformBlock
{
    /// <summary>
    /// The slice_differentiator attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? SliceDifferentiator
    {
        set => SetProperty("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceServiceType is required")]
    [Obsolete("This property is deprecated.")]
    public required TerraformProperty<double> SliceServiceType
    {
        set => SetProperty("slice_service_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSliceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mobile_network_slice resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkSlice : TerraformResource
{
    public AzurermMobileNetworkSlice(string name) : base("azurerm_mobile_network_slice", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("mobile_network_id");
        SetOutput("name");
        SetOutput("slice_differentiator");
        SetOutput("slice_service_type");
        SetOutput("tags");
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
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformProperty<string> MobileNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_network_id");
        set => SetProperty("mobile_network_id", value);
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
    /// The slice_differentiator attribute.
    /// </summary>
    public TerraformProperty<string> SliceDifferentiator
    {
        get => GetRequiredOutput<TerraformProperty<string>>("slice_differentiator");
        set => SetProperty("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    public TerraformProperty<double> SliceServiceType
    {
        get => GetRequiredOutput<TerraformProperty<double>>("slice_service_type");
        set => SetProperty("slice_service_type", value);
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
    /// Block for single_network_slice_selection_assistance_information.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleNetworkSliceSelectionAssistanceInformation block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AzurermMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationBlock>? SingleNetworkSliceSelectionAssistanceInformation
    {
        set => SetProperty("single_network_slice_selection_assistance_information", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSliceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
