using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageMoverAgentTimeoutsBlock : TerraformBlock
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
        SetOutput("arc_virtual_machine_id");
        SetOutput("arc_virtual_machine_uuid");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("storage_mover_id");
    }

    /// <summary>
    /// The arc_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcVirtualMachineId is required")]
    public required TerraformProperty<string> ArcVirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arc_virtual_machine_id");
        set => SetProperty("arc_virtual_machine_id", value);
    }

    /// <summary>
    /// The arc_virtual_machine_uuid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcVirtualMachineUuid is required")]
    public required TerraformProperty<string> ArcVirtualMachineUuid
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arc_virtual_machine_uuid");
        set => SetProperty("arc_virtual_machine_uuid", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The storage_mover_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverId is required")]
    public required TerraformProperty<string> StorageMoverId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_mover_id");
        set => SetProperty("storage_mover_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageMoverAgentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
