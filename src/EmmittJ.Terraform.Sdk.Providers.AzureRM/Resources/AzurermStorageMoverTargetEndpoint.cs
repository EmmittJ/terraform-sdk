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
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_name");
        set => this.WithProperty("storage_container_name", value);
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
