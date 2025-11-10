using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for module in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisEnterpriseDatabaseModuleBlock : TerraformBlock
{
    /// <summary>
    /// The args attribute.
    /// </summary>
    public TerraformProperty<string>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisEnterpriseDatabaseTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_redis_enterprise_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedisEnterpriseDatabase : TerraformResource
{
    public AzurermRedisEnterpriseDatabase(string name) : base("azurerm_redis_enterprise_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("primary_access_key");
        SetOutput("secondary_access_key");
        SetOutput("client_protocol");
        SetOutput("cluster_id");
        SetOutput("clustering_policy");
        SetOutput("eviction_policy");
        SetOutput("id");
        SetOutput("linked_database_group_nickname");
        SetOutput("linked_database_id");
        SetOutput("name");
        SetOutput("port");
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    public TerraformProperty<string> ClientProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_protocol");
        set => SetProperty("client_protocol", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformProperty<string> ClusteringPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("clustering_policy");
        set => SetProperty("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string> EvictionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eviction_policy");
        set => SetProperty("eviction_policy", value);
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
    /// The linked_database_group_nickname attribute.
    /// </summary>
    public TerraformProperty<string> LinkedDatabaseGroupNickname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("linked_database_group_nickname");
        set => SetProperty("linked_database_group_nickname", value);
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> LinkedDatabaseId
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("linked_database_id");
        set => SetProperty("linked_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Block for module.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Module block(s) allowed")]
    public List<AzurermRedisEnterpriseDatabaseModuleBlock>? Module
    {
        set => SetProperty("module", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedisEnterpriseDatabaseTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}
