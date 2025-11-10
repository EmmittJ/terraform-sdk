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
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    public required TerraformProperty<double> ImmutabilityPeriodInDays
    {
        get => GetRequiredProperty<TerraformProperty<double>>("immutability_period_in_days");
        set => this.WithProperty("immutability_period_in_days", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformProperty<bool>? Locked
    {
        get => GetProperty<TerraformProperty<bool>>("locked");
        set => this.WithProperty("locked", value);
    }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ProtectedAppendWritesAllEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("protected_append_writes_all_enabled");
        set => this.WithProperty("protected_append_writes_all_enabled", value);
    }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ProtectedAppendWritesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("protected_append_writes_enabled");
        set => this.WithProperty("protected_append_writes_enabled", value);
    }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    public required TerraformProperty<string> StorageContainerResourceManagerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_container_resource_manager_id");
        set => this.WithProperty("storage_container_resource_manager_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageContainerImmutabilityPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageContainerImmutabilityPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
