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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The immutability_period_in_days attribute.
    /// </summary>
    public double? ImmutabilityPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("immutability_period_in_days")?.Value;
        set => this.WithProperty("immutability_period_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public bool? Locked
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("locked")?.Value;
        set => this.WithProperty("locked", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    public bool? ProtectedAppendWritesAllEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("protected_append_writes_all_enabled")?.Value;
        set => this.WithProperty("protected_append_writes_all_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    public bool? ProtectedAppendWritesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("protected_append_writes_enabled")?.Value;
        set => this.WithProperty("protected_append_writes_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    public string? StorageContainerResourceManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_resource_manager_id")?.Value;
        set => this.WithProperty("storage_container_resource_manager_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
