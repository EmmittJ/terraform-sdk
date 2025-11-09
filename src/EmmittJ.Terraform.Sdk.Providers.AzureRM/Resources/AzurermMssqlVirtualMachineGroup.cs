using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_virtual_machine_group resource.
/// </summary>
public class AzurermMssqlVirtualMachineGroup : TerraformResource
{
    public AzurermMssqlVirtualMachineGroup(string name) : base("azurerm_mssql_virtual_machine_group", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    public TerraformProperty<string>? SqlImageOffer
    {
        get => GetProperty<TerraformProperty<string>>("sql_image_offer");
        set => this.WithProperty("sql_image_offer", value);
    }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    public TerraformProperty<string>? SqlImageSku
    {
        get => GetProperty<TerraformProperty<string>>("sql_image_sku");
        set => this.WithProperty("sql_image_sku", value);
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
