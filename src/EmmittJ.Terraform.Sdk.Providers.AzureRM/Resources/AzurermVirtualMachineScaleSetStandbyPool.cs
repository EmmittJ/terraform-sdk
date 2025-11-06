using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_scale_set_standby_pool resource.
/// </summary>
public class AzurermVirtualMachineScaleSetStandbyPool : TerraformResource
{
    public AzurermVirtualMachineScaleSetStandbyPool(string name) : base("azurerm_virtual_machine_scale_set_standby_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The attached_virtual_machine_scale_set_id attribute.
    /// </summary>
    public string? AttachedVirtualMachineScaleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attached_virtual_machine_scale_set_id")?.Value;
        set => this.WithProperty("attached_virtual_machine_scale_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_machine_state attribute.
    /// </summary>
    public string? VirtualMachineState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_state")?.Value;
        set => this.WithProperty("virtual_machine_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
