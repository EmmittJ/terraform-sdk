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
    public string? AdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password")?.Value;
        set => this.WithProperty("admin_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The offer_id attribute.
    /// </summary>
    public string? OfferId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offer_id")?.Value;
        set => this.WithProperty("offer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public string? PlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan_id")?.Value;
        set => this.WithProperty("plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publisher_id attribute.
    /// </summary>
    public string? PublisherId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher_id")?.Value;
        set => this.WithProperty("publisher_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_sku attribute.
    /// </summary>
    public string? StorageSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_sku")?.Value;
        set => this.WithProperty("storage_sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
