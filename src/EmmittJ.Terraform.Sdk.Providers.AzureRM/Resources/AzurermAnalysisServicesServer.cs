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
    public HashSet<string>? AdminUsers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("admin_users")?.Value;
        set => this.WithProperty("admin_users", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The backup_blob_container_uri attribute.
    /// </summary>
    public string? BackupBlobContainerUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_blob_container_uri")?.Value;
        set => this.WithProperty("backup_blob_container_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The power_bi_service_enabled attribute.
    /// </summary>
    public bool? PowerBiServiceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("power_bi_service_enabled")?.Value;
        set => this.WithProperty("power_bi_service_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The querypool_connection_mode attribute.
    /// </summary>
    public string? QuerypoolConnectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("querypool_connection_mode")?.Value;
        set => this.WithProperty("querypool_connection_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The server_full_name attribute.
    /// </summary>
    public TerraformExpression ServerFullName => this["server_full_name"];

}
