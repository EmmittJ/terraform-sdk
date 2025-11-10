using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectPoolTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_dev_center_project_pool resource.
/// </summary>
public class AzurermDevCenterProjectPool : TerraformResource
{
    public AzurermDevCenterProjectPool(string name) : base("azurerm_dev_center_project_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dev_box_definition_name");
        SetOutput("dev_center_attached_network_name");
        SetOutput("dev_center_project_id");
        SetOutput("id");
        SetOutput("local_administrator_enabled");
        SetOutput("location");
        SetOutput("managed_virtual_network_regions");
        SetOutput("name");
        SetOutput("single_sign_on_enabled");
        SetOutput("stop_on_disconnect_grace_period_minutes");
        SetOutput("tags");
    }

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevBoxDefinitionName is required")]
    public required TerraformProperty<string> DevBoxDefinitionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dev_box_definition_name");
        set => SetProperty("dev_box_definition_name", value);
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterAttachedNetworkName is required")]
    public required TerraformProperty<string> DevCenterAttachedNetworkName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dev_center_attached_network_name");
        set => SetProperty("dev_center_attached_network_name", value);
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
    /// The local_administrator_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAdministratorEnabled is required")]
    public required TerraformProperty<bool> LocalAdministratorEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_administrator_enabled");
        set => SetProperty("local_administrator_enabled", value);
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
    /// The managed_virtual_network_regions attribute.
    /// </summary>
    public List<TerraformProperty<string>> ManagedVirtualNetworkRegions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("managed_virtual_network_regions");
        set => SetProperty("managed_virtual_network_regions", value);
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
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SingleSignOnEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("single_sign_on_enabled");
        set => SetProperty("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformProperty<double> StopOnDisconnectGracePeriodMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("stop_on_disconnect_grace_period_minutes");
        set => SetProperty("stop_on_disconnect_grace_period_minutes", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterProjectPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
