using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappSnapshot.
/// Nesting mode: single
/// </summary>
public class AzurermNetappSnapshotTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_snapshot Terraform resource.
/// Manages a azurerm_netapp_snapshot resource.
/// </summary>
public partial class AzurermNetappSnapshot(string name) : TerraformResource("azurerm_netapp_snapshot", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => GetArgument<TerraformValue<string>>("pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappSnapshotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappSnapshotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
