using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for elasticity_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock : TerraformBlock
{
    /// <summary>
    /// The max_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReadyCapacity is required")]
    public required TerraformProperty<double> MaxReadyCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_ready_capacity");
        set => WithProperty("max_ready_capacity", value);
    }

    /// <summary>
    /// The min_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReadyCapacity is required")]
    public required TerraformProperty<double> MinReadyCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_ready_capacity");
        set => WithProperty("min_ready_capacity", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_machine_scale_set_standby_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedVirtualMachineScaleSetId is required")]
    public required TerraformProperty<string> AttachedVirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("attached_virtual_machine_scale_set_id");
        set => this.WithProperty("attached_virtual_machine_scale_set_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The virtual_machine_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineState is required")]
    public required TerraformProperty<string> VirtualMachineState
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_state");
        set => this.WithProperty("virtual_machine_state", value);
    }

    /// <summary>
    /// Block for elasticity_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ElasticityProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticityProfile block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock>? ElasticityProfile
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock>>("elasticity_profile");
        set => this.WithProperty("elasticity_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
