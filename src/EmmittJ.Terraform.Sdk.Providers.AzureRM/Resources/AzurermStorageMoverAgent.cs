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
    public TerraformProperty<string>? ArcVirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("arc_virtual_machine_id");
        set => this.WithProperty("arc_virtual_machine_id", value);
    }

    /// <summary>
    /// The arc_virtual_machine_uuid attribute.
    /// </summary>
    public TerraformProperty<string>? ArcVirtualMachineUuid
    {
        get => GetProperty<TerraformProperty<string>>("arc_virtual_machine_uuid");
        set => this.WithProperty("arc_virtual_machine_uuid", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageMoverId
    {
        get => GetProperty<TerraformProperty<string>>("storage_mover_id");
        set => this.WithProperty("storage_mover_id", value);
    }

}
