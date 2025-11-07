using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_netapp_pool resource.
/// </summary>
public class AzurermNetappPool : TerraformResource
{
    public AzurermNetappPool(string name) : base("azurerm_netapp_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformProperty<string>? AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CoolAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cool_access_enabled");
        set => this.WithProperty("cool_access_enabled", value);
    }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    public TerraformProperty<double>? CustomThroughputMibps
    {
        get => GetProperty<TerraformProperty<double>>("custom_throughput_mibps");
        set => this.WithProperty("custom_throughput_mibps", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => this.WithProperty("encryption_type", value);
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
    /// The qos_type attribute.
    /// </summary>
    public TerraformProperty<string>? QosType
    {
        get => GetProperty<TerraformProperty<string>>("qos_type");
        set => this.WithProperty("qos_type", value);
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
    /// The service_level attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceLevel
    {
        get => GetProperty<TerraformProperty<string>>("service_level");
        set => this.WithProperty("service_level", value);
    }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeInTb
    {
        get => GetProperty<TerraformProperty<double>>("size_in_tb");
        set => this.WithProperty("size_in_tb", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
