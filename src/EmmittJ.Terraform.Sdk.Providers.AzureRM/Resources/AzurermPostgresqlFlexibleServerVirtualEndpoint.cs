using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_flexible_server_virtual_endpoint resource.
/// </summary>
public class AzurermPostgresqlFlexibleServerVirtualEndpoint : TerraformResource
{
    public AzurermPostgresqlFlexibleServerVirtualEndpoint(string name) : base("azurerm_postgresql_flexible_server_virtual_endpoint", name)
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
    /// The name of the Virtual Endpoint
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Resource ID of the *Replica* Postgres Flexible Server this should be associated with
    /// </summary>
    public TerraformProperty<string>? ReplicaServerId
    {
        get => GetProperty<TerraformProperty<string>>("replica_server_id");
        set => this.WithProperty("replica_server_id", value);
    }

    /// <summary>
    /// The Resource ID of the *Source* Postgres Flexible Server this should be associated with
    /// </summary>
    public TerraformProperty<string>? SourceServerId
    {
        get => GetProperty<TerraformProperty<string>>("source_server_id");
        set => this.WithProperty("source_server_id", value);
    }

    /// <summary>
    /// The type of Virtual Endpoint
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
