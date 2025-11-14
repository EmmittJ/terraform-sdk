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
public class AzurermStorageMoverJobDefinitionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_mover_job_definition resource.
/// </summary>
public class AzurermStorageMoverJobDefinition : TerraformResource
{
    public AzurermStorageMoverJobDefinition(string name) : base("azurerm_storage_mover_job_definition", name)
    {
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [TerraformArgument("agent_name")]
    public TerraformValue<string>? AgentName
    {
        get => new TerraformReference<string>(this, "agent_name");
        set => SetArgument("agent_name", value);
    }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyMode is required")]
    [TerraformArgument("copy_mode")]
    public required TerraformValue<string> CopyMode
    {
        get => new TerraformReference<string>(this, "copy_mode");
        set => SetArgument("copy_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformArgument("source_name")]
    public required TerraformValue<string> SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    [TerraformArgument("source_sub_path")]
    public TerraformValue<string>? SourceSubPath
    {
        get => new TerraformReference<string>(this, "source_sub_path");
        set => SetArgument("source_sub_path", value);
    }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverProjectId is required")]
    [TerraformArgument("storage_mover_project_id")]
    public required TerraformValue<string> StorageMoverProjectId
    {
        get => new TerraformReference<string>(this, "storage_mover_project_id");
        set => SetArgument("storage_mover_project_id", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    [TerraformArgument("target_name")]
    public required TerraformValue<string> TargetName
    {
        get => new TerraformReference<string>(this, "target_name");
        set => SetArgument("target_name", value);
    }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    [TerraformArgument("target_sub_path")]
    public TerraformValue<string>? TargetSubPath
    {
        get => new TerraformReference<string>(this, "target_sub_path");
        set => SetArgument("target_sub_path", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageMoverJobDefinitionTimeoutsBlock Timeouts { get; set; } = new();

}
