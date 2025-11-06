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
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    public bool? CoolAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cool_access_enabled")?.Value;
        set => this.WithProperty("cool_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    public double? CustomThroughputMibps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("custom_throughput_mibps")?.Value;
        set => this.WithProperty("custom_throughput_mibps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public string? EncryptionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_type")?.Value;
        set => this.WithProperty("encryption_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The qos_type attribute.
    /// </summary>
    public string? QosType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qos_type")?.Value;
        set => this.WithProperty("qos_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service_level attribute.
    /// </summary>
    public string? ServiceLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_level")?.Value;
        set => this.WithProperty("service_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    public double? SizeInTb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size_in_tb")?.Value;
        set => this.WithProperty("size_in_tb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
