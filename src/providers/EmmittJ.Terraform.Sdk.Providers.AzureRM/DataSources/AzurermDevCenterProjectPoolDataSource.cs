using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dev_center_project_pool.
/// </summary>
public class AzurermDevCenterProjectPoolDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectPoolDataSource(string name) : base("azurerm_dev_center_project_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dev_box_definition_name");
        SetOutput("dev_center_attached_network_name");
        SetOutput("local_administrator_enabled");
        SetOutput("location");
        SetOutput("single_sign_on_enabled");
        SetOutput("stop_on_disconnect_grace_period_minutes");
        SetOutput("tags");
        SetOutput("dev_center_project_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformProperty<string> DevCenterProjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dev_center_project_id");
        set => SetProperty("dev_center_project_id", value);
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
    public AzurermDevCenterProjectPoolDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    public TerraformExpression DevBoxDefinitionName => this["dev_box_definition_name"];

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    public TerraformExpression DevCenterAttachedNetworkName => this["dev_center_attached_network_name"];

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    public TerraformExpression LocalAdministratorEnabled => this["local_administrator_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformExpression SingleSignOnEnabled => this["single_sign_on_enabled"];

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformExpression StopOnDisconnectGracePeriodMinutes => this["stop_on_disconnect_grace_period_minutes"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
