using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_service_fabric_managed_cluster resource.
/// </summary>
public class AzurermServiceFabricManagedCluster : TerraformResource
{
    public AzurermServiceFabricManagedCluster(string name) : base("azurerm_service_fabric_managed_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackupServiceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("backup_service_enabled");
        set => this.WithProperty("backup_service_enabled", value);
    }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    public TerraformProperty<double>? ClientConnectionPort
    {
        get => GetProperty<TerraformProperty<double>>("client_connection_port");
        set => this.WithProperty("client_connection_port", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformProperty<string>? DnsName
    {
        get => GetProperty<TerraformProperty<string>>("dns_name");
        set => this.WithProperty("dns_name", value);
    }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsServiceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dns_service_enabled");
        set => this.WithProperty("dns_service_enabled", value);
    }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpGatewayPort
    {
        get => GetProperty<TerraformProperty<double>>("http_gateway_port");
        set => this.WithProperty("http_gateway_port", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeWave
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_wave");
        set => this.WithProperty("upgrade_wave", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
