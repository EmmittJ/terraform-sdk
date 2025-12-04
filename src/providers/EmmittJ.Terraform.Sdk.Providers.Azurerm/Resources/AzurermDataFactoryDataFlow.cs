using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sink in AzurermDataFactoryDataFlow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sink";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSinkBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSinkBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Flowlet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flowlet block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSinkBlockFlowletBlock>? Flowlet
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSinkBlockFlowletBlock>>("flowlet");
        set => SetArgument("flowlet", value);
    }

    /// <summary>
    /// LinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSinkBlockLinkedServiceBlock>? LinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSinkBlockLinkedServiceBlock>>("linked_service");
        set => SetArgument("linked_service", value);
    }

    /// <summary>
    /// RejectedLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectedLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSinkBlockRejectedLinkedServiceBlock>? RejectedLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSinkBlockRejectedLinkedServiceBlock>>("rejected_linked_service");
        set => SetArgument("rejected_linked_service", value);
    }

    /// <summary>
    /// SchemaLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSinkBlockSchemaLinkedServiceBlock>? SchemaLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSinkBlockSchemaLinkedServiceBlock>>("schema_linked_service");
        set => SetArgument("schema_linked_service", value);
    }

}

/// <summary>
/// Block type for dataset in AzurermDataFactoryDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSinkBlockDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for flowlet in AzurermDataFactoryDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSinkBlockFlowletBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flowlet";

    /// <summary>
    /// The dataset_parameters attribute.
    /// </summary>
    public TerraformValue<string>? DatasetParameters
    {
        get => GetArgument<TerraformValue<string>>("dataset_parameters");
        set => SetArgument("dataset_parameters", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for linked_service in AzurermDataFactoryDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSinkBlockLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for rejected_linked_service in AzurermDataFactoryDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSinkBlockRejectedLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rejected_linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for schema_linked_service in AzurermDataFactoryDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSinkBlockSchemaLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for source in AzurermDataFactoryDataFlow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSourceBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSourceBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Flowlet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flowlet block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSourceBlockFlowletBlock>? Flowlet
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSourceBlockFlowletBlock>>("flowlet");
        set => SetArgument("flowlet", value);
    }

    /// <summary>
    /// LinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSourceBlockLinkedServiceBlock>? LinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSourceBlockLinkedServiceBlock>>("linked_service");
        set => SetArgument("linked_service", value);
    }

    /// <summary>
    /// RejectedLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectedLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSourceBlockRejectedLinkedServiceBlock>? RejectedLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSourceBlockRejectedLinkedServiceBlock>>("rejected_linked_service");
        set => SetArgument("rejected_linked_service", value);
    }

    /// <summary>
    /// SchemaLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowSourceBlockSchemaLinkedServiceBlock>? SchemaLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowSourceBlockSchemaLinkedServiceBlock>>("schema_linked_service");
        set => SetArgument("schema_linked_service", value);
    }

}

/// <summary>
/// Block type for dataset in AzurermDataFactoryDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSourceBlockDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for flowlet in AzurermDataFactoryDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSourceBlockFlowletBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flowlet";

    /// <summary>
    /// The dataset_parameters attribute.
    /// </summary>
    public TerraformValue<string>? DatasetParameters
    {
        get => GetArgument<TerraformValue<string>>("dataset_parameters");
        set => SetArgument("dataset_parameters", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for linked_service in AzurermDataFactoryDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSourceBlockLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for rejected_linked_service in AzurermDataFactoryDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSourceBlockRejectedLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rejected_linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for schema_linked_service in AzurermDataFactoryDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowSourceBlockSchemaLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for timeouts in AzurermDataFactoryDataFlow.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDataFlowTimeoutsBlock : TerraformBlock
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
/// Block type for transformation in AzurermDataFactoryDataFlow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowTransformationBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowTransformationBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Flowlet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flowlet block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowTransformationBlockFlowletBlock>? Flowlet
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowTransformationBlockFlowletBlock>>("flowlet");
        set => SetArgument("flowlet", value);
    }

    /// <summary>
    /// LinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryDataFlowTransformationBlockLinkedServiceBlock>? LinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowTransformationBlockLinkedServiceBlock>>("linked_service");
        set => SetArgument("linked_service", value);
    }

}

/// <summary>
/// Block type for dataset in AzurermDataFactoryDataFlowTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowTransformationBlockDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for flowlet in AzurermDataFactoryDataFlowTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowTransformationBlockFlowletBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flowlet";

    /// <summary>
    /// The dataset_parameters attribute.
    /// </summary>
    public TerraformValue<string>? DatasetParameters
    {
        get => GetArgument<TerraformValue<string>>("dataset_parameters");
        set => SetArgument("dataset_parameters", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Block type for linked_service in AzurermDataFactoryDataFlowTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDataFlowTransformationBlockLinkedServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_service";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
/// Represents a azurerm_data_factory_data_flow Terraform resource.
/// Manages a azurerm_data_factory_data_flow resource.
/// </summary>
public partial class AzurermDataFactoryDataFlow(string name) : TerraformResource("azurerm_data_factory_data_flow", name)
{
    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_factory_id");
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
    /// The folder attribute.
    /// </summary>
    public TerraformValue<string>? Folder
    {
        get => GetArgument<TerraformValue<string>>("folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    public TerraformValue<string>? Script
    {
        get => GetArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// The script_lines attribute.
    /// </summary>
    public TerraformList<string>? ScriptLines
    {
        get => GetArgument<TerraformList<string>>("script_lines");
        set => SetArgument("script_lines", value);
    }

    /// <summary>
    /// Sink block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sink block(s) required")]
    public required TerraformList<AzurermDataFactoryDataFlowSinkBlock> Sink
    {
        get => GetRequiredArgument<TerraformList<AzurermDataFactoryDataFlowSinkBlock>>("sink");
        set => SetArgument("sink", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    public required TerraformList<AzurermDataFactoryDataFlowSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AzurermDataFactoryDataFlowSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryDataFlowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryDataFlowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Transformation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryDataFlowTransformationBlock>? Transformation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryDataFlowTransformationBlock>>("transformation");
        set => SetArgument("transformation", value);
    }

}
