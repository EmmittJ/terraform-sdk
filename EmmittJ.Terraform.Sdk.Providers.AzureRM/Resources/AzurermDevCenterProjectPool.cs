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
    public string? DevBoxDefinitionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_box_definition_name")?.Value;
        set => this.WithProperty("dev_box_definition_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    public string? DevCenterAttachedNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_attached_network_name")?.Value;
        set => this.WithProperty("dev_center_attached_network_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    public string? DevCenterProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_project_id")?.Value;
        set => this.WithProperty("dev_center_project_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    public bool? LocalAdministratorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_administrator_enabled")?.Value;
        set => this.WithProperty("local_administrator_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_virtual_network_regions attribute.
    /// </summary>
    public List<string>? ManagedVirtualNetworkRegions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("managed_virtual_network_regions")?.Value;
        set => this.WithProperty("managed_virtual_network_regions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public bool? SingleSignOnEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("single_sign_on_enabled")?.Value;
        set => this.WithProperty("single_sign_on_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public double? StopOnDisconnectGracePeriodMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("stop_on_disconnect_grace_period_minutes")?.Value;
        set => this.WithProperty("stop_on_disconnect_grace_period_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
