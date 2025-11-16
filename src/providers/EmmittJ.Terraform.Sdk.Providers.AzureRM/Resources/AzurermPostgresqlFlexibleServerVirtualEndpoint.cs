using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_postgresql_flexible_server_virtual_endpoint Terraform resource.
/// Manages a azurerm_postgresql_flexible_server_virtual_endpoint resource.
/// </summary>
public partial class AzurermPostgresqlFlexibleServerVirtualEndpoint(string name) : TerraformResource("azurerm_postgresql_flexible_server_virtual_endpoint", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Virtual Endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Resource ID of the *Replica* Postgres Flexible Server this should be associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaServerId is required")]
    public required TerraformValue<string> ReplicaServerId
    {
        get => new TerraformReference<string>(this, "replica_server_id");
        set => SetArgument("replica_server_id", value);
    }

    /// <summary>
    /// The Resource ID of the *Source* Postgres Flexible Server this should be associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceServerId is required")]
    public required TerraformValue<string> SourceServerId
    {
        get => new TerraformReference<string>(this, "source_server_id");
        set => SetArgument("source_server_id", value);
    }

    /// <summary>
    /// The type of Virtual Endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
