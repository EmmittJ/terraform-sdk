using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_dev_box_definition.
/// </summary>
public class AzurermDevCenterDevBoxDefinitionDataSource : TerraformDataSource
{
    public AzurermDevCenterDevBoxDefinitionDataSource(string name) : base("azurerm_dev_center_dev_box_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("hibernate_support_enabled");
        SetOutput("image_reference_id");
        SetOutput("location");
        SetOutput("sku_name");
        SetOutput("tags");
        SetOutput("dev_center_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformProperty<string> DevCenterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dev_center_id");
        set => SetProperty("dev_center_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The hibernate_support_enabled attribute.
    /// </summary>
    public TerraformExpression HibernateSupportEnabled => this["hibernate_support_enabled"];

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformExpression ImageReferenceId => this["image_reference_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
