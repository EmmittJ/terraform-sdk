using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_qumulo_file_system resource.
/// </summary>
public class AzurermQumuloFileSystem : TerraformResource
{
    public AzurermQumuloFileSystem(string name) : base("azurerm_qumulo_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email");
        set => this.WithProperty("email", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The offer_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OfferId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offer_id");
        set => this.WithProperty("offer_id", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan_id");
        set => this.WithProperty("plan_id", value);
    }

    /// <summary>
    /// The publisher_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublisherId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher_id");
        set => this.WithProperty("publisher_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sku");
        set => this.WithProperty("storage_sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

}
