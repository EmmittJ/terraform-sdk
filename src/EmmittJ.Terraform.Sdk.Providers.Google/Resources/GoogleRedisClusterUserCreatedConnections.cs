using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_endpoints in .
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_redis_cluster_user_created_connections resource.
/// </summary>
public class GoogleRedisClusterUserCreatedConnections : TerraformResource
{
    public GoogleRedisClusterUserCreatedConnections(string name) : base("google_redis_cluster_user_created_connections", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name of the Redis cluster these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the region of the Redis cluster these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetRequiredProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for cluster_endpoints.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock>? ClusterEndpoints
    {
        get => GetProperty<List<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock>>("cluster_endpoints");
        set => this.WithProperty("cluster_endpoints", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
