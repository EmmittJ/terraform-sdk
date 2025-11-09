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
    public TerraformProperty<string>? AdministratorPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_password");
        set => this.WithProperty("administrator_password", value);
    }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorUsername
    {
        get => GetProperty<TerraformProperty<string>>("administrator_username");
        set => this.WithProperty("administrator_username", value);
    }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeTier
    {
        get => GetProperty<TerraformProperty<string>>("compute_tier");
        set => this.WithProperty("compute_tier", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    public TerraformProperty<string>? HighAvailabilityMode
    {
        get => GetProperty<TerraformProperty<string>>("high_availability_mode");
        set => this.WithProperty("high_availability_mode", value);
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
    /// The preview_features attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreviewFeatures
    {
        get => GetProperty<TerraformProperty<List<string>>>("preview_features");
        set => this.WithProperty("preview_features", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double>? ShardCount
    {
        get => GetProperty<TerraformProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformProperty<string>? SourceLocation
    {
        get => GetProperty<TerraformProperty<string>>("source_location");
        set => this.WithProperty("source_location", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceServerId
    {
        get => GetProperty<TerraformProperty<string>>("source_server_id");
        set => this.WithProperty("source_server_id", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? StorageSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("storage_size_in_gb");
        set => this.WithProperty("storage_size_in_gb", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformExpression ConnectionStrings => this["connection_strings"];

}
