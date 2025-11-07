using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? DevBoxDefinitionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_box_definition_name");
        set => this.WithProperty("dev_box_definition_name", value);
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DevCenterAttachedNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_attached_network_name");
        set => this.WithProperty("dev_center_attached_network_name", value);
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DevCenterProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_project_id");
        set => this.WithProperty("dev_center_project_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LocalAdministratorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_administrator_enabled");
        set => this.WithProperty("local_administrator_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_virtual_network_regions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ManagedVirtualNetworkRegions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("managed_virtual_network_regions");
        set => this.WithProperty("managed_virtual_network_regions", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SingleSignOnEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("single_sign_on_enabled");
        set => this.WithProperty("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StopOnDisconnectGracePeriodMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("stop_on_disconnect_grace_period_minutes");
        set => this.WithProperty("stop_on_disconnect_grace_period_minutes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
