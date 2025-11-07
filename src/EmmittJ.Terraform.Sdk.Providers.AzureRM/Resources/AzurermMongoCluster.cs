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
    public TerraformLiteralProperty<string>? AdministratorPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_password");
        set => this.WithProperty("administrator_password", value);
    }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdministratorUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_username");
        set => this.WithProperty("administrator_username", value);
    }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComputeTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_tier");
        set => this.WithProperty("compute_tier", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HighAvailabilityMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("high_availability_mode");
        set => this.WithProperty("high_availability_mode", value);
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
    /// The preview_features attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PreviewFeatures
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preview_features");
        set => this.WithProperty("preview_features", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ShardCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_location");
        set => this.WithProperty("source_location", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_server_id");
        set => this.WithProperty("source_server_id", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageSizeInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_size_in_gb");
        set => this.WithProperty("storage_size_in_gb", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformExpression ConnectionStrings => this["connection_strings"];

}
