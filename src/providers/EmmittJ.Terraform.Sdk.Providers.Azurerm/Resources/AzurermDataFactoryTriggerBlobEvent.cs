using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for pipeline in AzurermDataFactoryTriggerBlobEvent.
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryTriggerBlobEventPipelineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryTriggerBlobEvent.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerBlobEventTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_factory_trigger_blob_event Terraform resource.
/// Manages a azurerm_data_factory_trigger_blob_event resource.
/// </summary>
public partial class AzurermDataFactoryTriggerBlobEvent(string name) : TerraformResource("azurerm_data_factory_trigger_blob_event", name)
{
    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformValue<bool>? Activated
    {
        get => GetArgument<TerraformValue<bool>>("activated");
        set => SetArgument("activated", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => GetArgument<TerraformMap<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The blob_path_begins_with attribute.
    /// </summary>
    public TerraformValue<string>? BlobPathBeginsWith
    {
        get => GetArgument<TerraformValue<string>>("blob_path_begins_with");
        set => SetArgument("blob_path_begins_with", value);
    }

    /// <summary>
    /// The blob_path_ends_with attribute.
    /// </summary>
    public TerraformValue<string>? BlobPathEndsWith
    {
        get => GetArgument<TerraformValue<string>>("blob_path_ends_with");
        set => SetArgument("blob_path_ends_with", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
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
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public required TerraformSet<string> Events
    {
        get => GetArgument<TerraformSet<string>>("events");
        set => SetArgument("events", value);
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
    /// The ignore_empty_blobs attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreEmptyBlobs
    {
        get => GetArgument<TerraformValue<bool>>("ignore_empty_blobs");
        set => SetArgument("ignore_empty_blobs", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Pipeline block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pipeline is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    public required TerraformSet<AzurermDataFactoryTriggerBlobEventPipelineBlock> Pipeline
    {
        get => GetRequiredArgument<TerraformSet<AzurermDataFactoryTriggerBlobEventPipelineBlock>>("pipeline");
        set => SetArgument("pipeline", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryTriggerBlobEventTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryTriggerBlobEventTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
