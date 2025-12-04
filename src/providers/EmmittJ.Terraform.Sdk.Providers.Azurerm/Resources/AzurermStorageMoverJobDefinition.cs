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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("agent_name");
        set => SetArgument("agent_name", value);
    }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyMode is required")]
    public required TerraformValue<string> CopyMode
    {
        get => GetArgument<TerraformValue<string>>("copy_mode");
        set => SetArgument("copy_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => GetArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    public TerraformValue<string>? SourceSubPath
    {
        get => GetArgument<TerraformValue<string>>("source_sub_path");
        set => SetArgument("source_sub_path", value);
    }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverProjectId is required")]
    public required TerraformValue<string> StorageMoverProjectId
    {
        get => GetArgument<TerraformValue<string>>("storage_mover_project_id");
        set => SetArgument("storage_mover_project_id", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    public required TerraformValue<string> TargetName
    {
        get => GetArgument<TerraformValue<string>>("target_name");
        set => SetArgument("target_name", value);
    }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    public TerraformValue<string>? TargetSubPath
    {
        get => GetArgument<TerraformValue<string>>("target_sub_path");
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
