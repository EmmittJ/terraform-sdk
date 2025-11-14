using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerActiveDirectoryAdministratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_postgresql_flexible_server_active_directory_administrator resource.
/// </summary>
public class AzurermPostgresqlFlexibleServerActiveDirectoryAdministrator : TerraformResource
{
    public AzurermPostgresqlFlexibleServerActiveDirectoryAdministrator(string name) : base("azurerm_postgresql_flexible_server_active_directory_administrator", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformArgument("object_id")]
    public required TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The principal_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalName is required")]
    [TerraformArgument("principal_name")]
    public required TerraformValue<string> PrincipalName
    {
        get => new TerraformReference<string>(this, "principal_name");
        set => SetArgument("principal_name", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformArgument("principal_type")]
    public required TerraformValue<string> PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
        set => SetArgument("principal_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformArgument("server_name")]
    public required TerraformValue<string> ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformArgument("tenant_id")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPostgresqlFlexibleServerActiveDirectoryAdministratorTimeoutsBlock Timeouts { get; set; } = new();

}
