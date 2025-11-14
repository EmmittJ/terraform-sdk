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
public class AzurermArcMachineExtensionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_arc_machine_extension resource.
/// </summary>
public class AzurermArcMachineExtension : TerraformResource
{
    public AzurermArcMachineExtension(string name) : base("azurerm_arc_machine_extension", name)
    {
    }

    /// <summary>
    /// The arc_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcMachineId is required")]
    [TerraformArgument("arc_machine_id")]
    public required TerraformValue<string> ArcMachineId
    {
        get => new TerraformReference<string>(this, "arc_machine_id");
        set => SetArgument("arc_machine_id", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformArgument("automatic_upgrade_enabled")]
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformArgument("force_update_tag")]
    public TerraformValue<string>? ForceUpdateTag
    {
        get => new TerraformReference<string>(this, "force_update_tag");
        set => SetArgument("force_update_tag", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformArgument("protected_settings")]
    public TerraformValue<string>? ProtectedSettings
    {
        get => new TerraformReference<string>(this, "protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformArgument("settings")]
    public TerraformValue<string>? Settings
    {
        get => new TerraformReference<string>(this, "settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [TerraformArgument("type_handler_version")]
    public TerraformValue<string>? TypeHandlerVersion
    {
        get => new TerraformReference<string>(this, "type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermArcMachineExtensionTimeoutsBlock Timeouts { get; set; } = new();

}
