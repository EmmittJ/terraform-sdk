using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mongo_cluster resource.
/// </summary>
public class AzurermMongoCluster : TerraformResource
{
    public AzurermMongoCluster(string name) : base("azurerm_mongo_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_strings");
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public string? AdministratorPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_password")?.Value;
        set => this.WithProperty("administrator_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    public string? AdministratorUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_username")?.Value;
        set => this.WithProperty("administrator_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    public string? ComputeTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_tier")?.Value;
        set => this.WithProperty("compute_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public string? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode")?.Value;
        set => this.WithProperty("create_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    public string? HighAvailabilityMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("high_availability_mode")?.Value;
        set => this.WithProperty("high_availability_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The preview_features attribute.
    /// </summary>
    public List<string>? PreviewFeatures
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preview_features")?.Value;
        set => this.WithProperty("preview_features", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public string? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access")?.Value;
        set => this.WithProperty("public_network_access", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The shard_count attribute.
    /// </summary>
    public double? ShardCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("shard_count")?.Value;
        set => this.WithProperty("shard_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public string? SourceLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_location")?.Value;
        set => this.WithProperty("source_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public string? SourceServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_server_id")?.Value;
        set => this.WithProperty("source_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public double? StorageSizeInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_size_in_gb")?.Value;
        set => this.WithProperty("storage_size_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformExpression ConnectionStrings => this["connection_strings"];

}
