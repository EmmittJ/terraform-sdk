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
    public TerraformLiteralProperty<string>? ArcVirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_virtual_machine_id");
        set => this.WithProperty("arc_virtual_machine_id", value);
    }

    /// <summary>
    /// The arc_virtual_machine_uuid attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ArcVirtualMachineUuid
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_virtual_machine_uuid");
        set => this.WithProperty("arc_virtual_machine_uuid", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageMoverId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_mover_id");
        set => this.WithProperty("storage_mover_id", value);
    }

}
