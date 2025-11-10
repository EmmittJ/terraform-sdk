using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMongoClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("connection_strings");
        SetOutput("administrator_password");
        SetOutput("administrator_username");
        SetOutput("compute_tier");
        SetOutput("create_mode");
        SetOutput("high_availability_mode");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("preview_features");
        SetOutput("public_network_access");
        SetOutput("resource_group_name");
        SetOutput("shard_count");
        SetOutput("source_location");
        SetOutput("source_server_id");
        SetOutput("storage_size_in_gb");
        SetOutput("tags");
        SetOutput("version");
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_password");
        set => SetProperty("administrator_password", value);
    }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_username");
        set => SetProperty("administrator_username", value);
    }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    public TerraformProperty<string> ComputeTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_tier");
        set => SetProperty("compute_tier", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string> CreateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_mode");
        set => SetProperty("create_mode", value);
    }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    public TerraformProperty<string> HighAvailabilityMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("high_availability_mode");
        set => SetProperty("high_availability_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The preview_features attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreviewFeatures
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preview_features");
        set => SetProperty("preview_features", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string> PublicNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_network_access");
        set => SetProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double> ShardCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("shard_count");
        set => SetProperty("shard_count", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformProperty<string> SourceLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_location");
        set => SetProperty("source_location", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_server_id");
        set => SetProperty("source_server_id", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double> StorageSizeInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_size_in_gb");
        set => SetProperty("storage_size_in_gb", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMongoClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformExpression ConnectionStrings => this["connection_strings"];

}
