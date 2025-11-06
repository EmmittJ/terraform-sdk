using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_mover_target_endpoint resource.
/// </summary>
public class AzurermStorageMoverTargetEndpoint : TerraformResource
{
    public AzurermStorageMoverTargetEndpoint(string name) : base("azurerm_storage_mover_target_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public string? StorageContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_name")?.Value;
        set => this.WithProperty("storage_container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
