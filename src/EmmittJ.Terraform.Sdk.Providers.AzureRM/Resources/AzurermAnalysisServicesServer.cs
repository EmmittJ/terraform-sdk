using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_analysis_services_server resource.
/// </summary>
public class AzurermAnalysisServicesServer : TerraformResource
{
    public AzurermAnalysisServicesServer(string name) : base("azurerm_analysis_services_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("server_full_name");
    }

    /// <summary>
    /// The admin_users attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AdminUsers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("admin_users");
        set => this.WithProperty("admin_users", value);
    }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    public TerraformProperty<string>? BackupBlobContainerUri
    {
        get => GetProperty<TerraformProperty<string>>("backup_blob_container_uri");
        set => this.WithProperty("backup_blob_container_uri", value);
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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PowerBiServiceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("power_bi_service_enabled");
        set => this.WithProperty("power_bi_service_enabled", value);
    }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? QuerypoolConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("querypool_connection_mode");
        set => this.WithProperty("querypool_connection_mode", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The server_full_name attribute.
    /// </summary>
    public TerraformExpression ServerFullName => this["server_full_name"];

}
