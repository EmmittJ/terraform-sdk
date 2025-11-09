using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_maps_creator resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermMapsCreator : TerraformResource
{
    public AzurermMapsCreator(string name) : base("azurerm_maps_creator", name)
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maps_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? MapsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("maps_account_id");
        set => this.WithProperty("maps_account_id", value);
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
    /// The storage_units attribute.
    /// </summary>
    public TerraformProperty<double>? StorageUnits
    {
        get => GetProperty<TerraformProperty<double>>("storage_units");
        set => this.WithProperty("storage_units", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
