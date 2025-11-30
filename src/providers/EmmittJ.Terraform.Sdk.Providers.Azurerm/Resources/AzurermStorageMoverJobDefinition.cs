using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageMoverJobDefinition.
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
/// Represents a azurerm_storage_mover_job_definition Terraform resource.
/// Manages a azurerm_storage_mover_job_definition resource.
/// </summary>
public partial class AzurermStorageMoverJobDefinition(string name) : TerraformResource("azurerm_storage_mover_job_definition", name)
{
    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    public TerraformValue<string>? AgentName
    {
        get => new TerraformReference<string>(this, "agent_name");
        set => SetArgument("agent_name", value);
    }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyMode is required")]
    public required TerraformValue<string> CopyMode
    {
        get => new TerraformReference<string>(this, "copy_mode");
        set => SetArgument("copy_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    public TerraformValue<string>? SourceSubPath
    {
        get => new TerraformReference<string>(this, "source_sub_path");
        set => SetArgument("source_sub_path", value);
    }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverProjectId is required")]
    public required TerraformValue<string> StorageMoverProjectId
    {
        get => new TerraformReference<string>(this, "storage_mover_project_id");
        set => SetArgument("storage_mover_project_id", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    public required TerraformValue<string> TargetName
    {
        get => new TerraformReference<string>(this, "target_name");
        set => SetArgument("target_name", value);
    }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    public TerraformValue<string>? TargetSubPath
    {
        get => new TerraformReference<string>(this, "target_sub_path");
        set => SetArgument("target_sub_path", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageMoverJobDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageMoverJobDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
