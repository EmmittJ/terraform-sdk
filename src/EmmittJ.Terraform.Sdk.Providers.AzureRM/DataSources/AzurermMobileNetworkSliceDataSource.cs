using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSliceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_slice.
/// </summary>
public class AzurermMobileNetworkSliceDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSliceDataSource(string name) : base("azurerm_mobile_network_slice", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("location");
        this.DeclareOutput("single_network_slice_selection_assistance_information");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformProperty<string> MobileNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSliceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkSliceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The single_network_slice_selection_assistance_information attribute.
    /// </summary>
    public TerraformExpression SingleNetworkSliceSelectionAssistanceInformation => this["single_network_slice_selection_assistance_information"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
