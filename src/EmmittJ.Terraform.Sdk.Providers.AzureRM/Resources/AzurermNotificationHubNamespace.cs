using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_notification_hub_namespace resource.
/// </summary>
public class AzurermNotificationHubNamespace : TerraformResource
{
    public AzurermNotificationHubNamespace(string name) : base("azurerm_notification_hub_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("servicebus_endpoint");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The namespace_type attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceType
    {
        get => GetProperty<TerraformProperty<string>>("namespace_type");
        set => this.WithProperty("namespace_type", value);
    }

    /// <summary>
    /// The replication_region attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationRegion
    {
        get => GetProperty<TerraformProperty<string>>("replication_region");
        set => this.WithProperty("replication_region", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => this.WithProperty("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// The servicebus_endpoint attribute.
    /// </summary>
    public TerraformExpression ServicebusEndpoint => this["servicebus_endpoint"];

}
