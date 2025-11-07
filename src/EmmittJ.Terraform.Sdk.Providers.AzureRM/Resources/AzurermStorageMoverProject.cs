using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_mover_project resource.
/// </summary>
public class AzurermStorageMoverProject : TerraformResource
{
    public AzurermStorageMoverProject(string name) : base("azurerm_storage_mover_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
