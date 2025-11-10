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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevBoxDefinitionName is required")]
    public required TerraformProperty<string> DevBoxDefinitionName
    {
        get => GetProperty<TerraformProperty<string>>("dev_box_definition_name");
        set => this.WithProperty("dev_box_definition_name", value);
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterAttachedNetworkName is required")]
    public required TerraformProperty<string> DevCenterAttachedNetworkName
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_attached_network_name");
        set => this.WithProperty("dev_center_attached_network_name", value);
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformProperty<string> DevCenterProjectId
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_project_id");
        set => this.WithProperty("dev_center_project_id", value);
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
    /// The local_administrator_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAdministratorEnabled is required")]
    public required TerraformProperty<bool> LocalAdministratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_administrator_enabled");
        set => this.WithProperty("local_administrator_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_virtual_network_regions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ManagedVirtualNetworkRegions
    {
        get => GetProperty<List<TerraformProperty<string>>>("managed_virtual_network_regions");
        set => this.WithProperty("managed_virtual_network_regions", value);
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
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SingleSignOnEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("single_sign_on_enabled");
        set => this.WithProperty("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? StopOnDisconnectGracePeriodMinutes
    {
        get => GetProperty<TerraformProperty<double>>("stop_on_disconnect_grace_period_minutes");
        set => this.WithProperty("stop_on_disconnect_grace_period_minutes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterProjectPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevCenterProjectPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
