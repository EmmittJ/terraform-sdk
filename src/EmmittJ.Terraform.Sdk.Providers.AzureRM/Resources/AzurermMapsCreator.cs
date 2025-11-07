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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maps_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MapsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maps_account_id");
        set => this.WithProperty("maps_account_id", value);
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
    /// The storage_units attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_units");
        set => this.WithProperty("storage_units", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
