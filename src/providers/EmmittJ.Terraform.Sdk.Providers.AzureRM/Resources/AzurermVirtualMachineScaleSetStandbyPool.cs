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
        set => SetProperty("max_ready_capacity", value);
    }

    /// <summary>
    /// The min_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReadyCapacity is required")]
    public required TerraformProperty<double> MinReadyCapacity
    {
        set => SetProperty("min_ready_capacity", value);
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
        SetOutput("attached_virtual_machine_scale_set_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("virtual_machine_state");
    }

    /// <summary>
    /// The attached_virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedVirtualMachineScaleSetId is required")]
    public required TerraformProperty<string> AttachedVirtualMachineScaleSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attached_virtual_machine_scale_set_id");
        set => SetProperty("attached_virtual_machine_scale_set_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// The virtual_machine_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineState is required")]
    public required TerraformProperty<string> VirtualMachineState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_state");
        set => SetProperty("virtual_machine_state", value);
    }

    /// <summary>
    /// Block for elasticity_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticityProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ElasticityProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticityProfile block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock>? ElasticityProfile
    {
        set => SetProperty("elasticity_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
