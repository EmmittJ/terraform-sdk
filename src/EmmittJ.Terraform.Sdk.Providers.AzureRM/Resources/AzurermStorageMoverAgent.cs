using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_mover_agent resource.
/// </summary>
public class AzurermStorageMoverAgent : TerraformResource
{
    public AzurermStorageMoverAgent(string name) : base("azurerm_storage_mover_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arc_virtual_machine_id attribute.
    /// </summary>
    public string? ArcVirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_virtual_machine_id")?.Value;
        set => this.WithProperty("arc_virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arc_virtual_machine_uuid attribute.
    /// </summary>
    public string? ArcVirtualMachineUuid
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_virtual_machine_uuid")?.Value;
        set => this.WithProperty("arc_virtual_machine_uuid", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    public string? StorageMoverId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_mover_id")?.Value;
        set => this.WithProperty("storage_mover_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
