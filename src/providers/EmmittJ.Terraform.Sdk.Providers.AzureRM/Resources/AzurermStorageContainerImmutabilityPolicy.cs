using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerImmutabilityPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_container_immutability_policy resource.
/// </summary>
public class AzurermStorageContainerImmutabilityPolicy : TerraformResource
{
    public AzurermStorageContainerImmutabilityPolicy(string name) : base("azurerm_storage_container_immutability_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("immutability_period_in_days");
        SetOutput("locked");
        SetOutput("protected_append_writes_all_enabled");
        SetOutput("protected_append_writes_enabled");
        SetOutput("storage_container_resource_manager_id");
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
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    public required TerraformProperty<double> ImmutabilityPeriodInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("immutability_period_in_days");
        set => SetProperty("immutability_period_in_days", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformProperty<bool> Locked
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("locked");
        set => SetProperty("locked", value);
    }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ProtectedAppendWritesAllEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("protected_append_writes_all_enabled");
        set => SetProperty("protected_append_writes_all_enabled", value);
    }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ProtectedAppendWritesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("protected_append_writes_enabled");
        set => SetProperty("protected_append_writes_enabled", value);
    }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    public required TerraformProperty<string> StorageContainerResourceManagerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_container_resource_manager_id");
        set => SetProperty("storage_container_resource_manager_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageContainerImmutabilityPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
