using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_private_link_scope resource.
/// </summary>
public class AzurermMonitorPrivateLinkScope : TerraformResource
{
    public AzurermMonitorPrivateLinkScope(string name) : base("azurerm_monitor_private_link_scope", name)
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
    /// The ingestion_access_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IngestionAccessMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingestion_access_mode");
        set => this.WithProperty("ingestion_access_mode", value);
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
    /// The query_access_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryAccessMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_access_mode");
        set => this.WithProperty("query_access_mode", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
