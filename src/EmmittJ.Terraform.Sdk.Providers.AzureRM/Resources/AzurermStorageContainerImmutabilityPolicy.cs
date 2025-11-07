using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The immutability_period_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ImmutabilityPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("immutability_period_in_days");
        set => this.WithProperty("immutability_period_in_days", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Locked
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("locked");
        set => this.WithProperty("locked", value);
    }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ProtectedAppendWritesAllEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("protected_append_writes_all_enabled");
        set => this.WithProperty("protected_append_writes_all_enabled", value);
    }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ProtectedAppendWritesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("protected_append_writes_enabled");
        set => this.WithProperty("protected_append_writes_enabled", value);
    }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageContainerResourceManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_resource_manager_id");
        set => this.WithProperty("storage_container_resource_manager_id", value);
    }

}
