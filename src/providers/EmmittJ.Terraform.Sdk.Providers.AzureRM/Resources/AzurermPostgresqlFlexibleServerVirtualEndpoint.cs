using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock : TerraformBlock
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("replica_server_id");
        SetOutput("source_server_id");
        SetOutput("type");
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
    /// The name of the Virtual Endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The Resource ID of the *Replica* Postgres Flexible Server this should be associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaServerId is required")]
    public required TerraformProperty<string> ReplicaServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replica_server_id");
        set => SetProperty("replica_server_id", value);
    }

    /// <summary>
    /// The Resource ID of the *Source* Postgres Flexible Server this should be associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceServerId is required")]
    public required TerraformProperty<string> SourceServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_server_id");
        set => SetProperty("source_server_id", value);
    }

    /// <summary>
    /// The type of Virtual Endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
