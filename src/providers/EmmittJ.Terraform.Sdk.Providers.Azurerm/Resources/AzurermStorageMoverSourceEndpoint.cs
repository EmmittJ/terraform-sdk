using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageMoverSourceEndpoint.
/// Nesting mode: single
/// </summary>
public class AzurermStorageMoverSourceEndpointTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_mover_source_endpoint Terraform resource.
/// Manages a azurerm_storage_mover_source_endpoint resource.
/// </summary>
public partial class AzurermStorageMoverSourceEndpoint(string name) : TerraformResource("azurerm_storage_mover_source_endpoint", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformValue<string>? Export
    {
        get => new TerraformReference<string>(this, "export");
        set => SetArgument("export", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nfs_version attribute.
    /// </summary>
    public TerraformValue<string>? NfsVersion
    {
        get => new TerraformReference<string>(this, "nfs_version");
        set => SetArgument("nfs_version", value);
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverId is required")]
    public required TerraformValue<string> StorageMoverId
    {
        get => new TerraformReference<string>(this, "storage_mover_id");
        set => SetArgument("storage_mover_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageMoverSourceEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageMoverSourceEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
