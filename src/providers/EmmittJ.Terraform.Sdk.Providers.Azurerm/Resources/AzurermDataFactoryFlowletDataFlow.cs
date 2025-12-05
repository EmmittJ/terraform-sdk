using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sink in AzurermDataFactoryFlowletDataFlow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSinkBlock : TerraformBlock
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
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Flowlet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flowlet block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockFlowletBlock>? Flowlet
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockFlowletBlock>>("flowlet");
        set => SetArgument("flowlet", value);
    }

    /// <summary>
    /// LinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockLinkedServiceBlock>? LinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockLinkedServiceBlock>>("linked_service");
        set => SetArgument("linked_service", value);
    }

    /// <summary>
    /// RejectedLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectedLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockRejectedLinkedServiceBlock>? RejectedLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockRejectedLinkedServiceBlock>>("rejected_linked_service");
        set => SetArgument("rejected_linked_service", value);
    }

    /// <summary>
    /// SchemaLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockSchemaLinkedServiceBlock>? SchemaLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlockSchemaLinkedServiceBlock>>("schema_linked_service");
        set => SetArgument("schema_linked_service", value);
    }

}

/// <summary>
/// Block type for dataset in AzurermDataFactoryFlowletDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSinkBlockDatasetBlock : TerraformBlock
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
/// Block type for flowlet in AzurermDataFactoryFlowletDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSinkBlockFlowletBlock : TerraformBlock
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
/// Block type for linked_service in AzurermDataFactoryFlowletDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSinkBlockLinkedServiceBlock : TerraformBlock
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
/// Block type for rejected_linked_service in AzurermDataFactoryFlowletDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSinkBlockRejectedLinkedServiceBlock : TerraformBlock
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
/// Block type for schema_linked_service in AzurermDataFactoryFlowletDataFlowSinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSinkBlockSchemaLinkedServiceBlock : TerraformBlock
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
/// Block type for source in AzurermDataFactoryFlowletDataFlow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSourceBlock : TerraformBlock
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
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Flowlet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flowlet block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockFlowletBlock>? Flowlet
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockFlowletBlock>>("flowlet");
        set => SetArgument("flowlet", value);
    }

    /// <summary>
    /// LinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockLinkedServiceBlock>? LinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockLinkedServiceBlock>>("linked_service");
        set => SetArgument("linked_service", value);
    }

    /// <summary>
    /// RejectedLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectedLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockRejectedLinkedServiceBlock>? RejectedLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockRejectedLinkedServiceBlock>>("rejected_linked_service");
        set => SetArgument("rejected_linked_service", value);
    }

    /// <summary>
    /// SchemaLinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaLinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockSchemaLinkedServiceBlock>? SchemaLinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlockSchemaLinkedServiceBlock>>("schema_linked_service");
        set => SetArgument("schema_linked_service", value);
    }

}

/// <summary>
/// Block type for dataset in AzurermDataFactoryFlowletDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSourceBlockDatasetBlock : TerraformBlock
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
/// Block type for flowlet in AzurermDataFactoryFlowletDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSourceBlockFlowletBlock : TerraformBlock
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
/// Block type for linked_service in AzurermDataFactoryFlowletDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSourceBlockLinkedServiceBlock : TerraformBlock
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
/// Block type for rejected_linked_service in AzurermDataFactoryFlowletDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSourceBlockRejectedLinkedServiceBlock : TerraformBlock
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
/// Block type for schema_linked_service in AzurermDataFactoryFlowletDataFlowSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowSourceBlockSchemaLinkedServiceBlock : TerraformBlock
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
/// Block type for timeouts in AzurermDataFactoryFlowletDataFlow.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryFlowletDataFlowTimeoutsBlock : TerraformBlock
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
/// Block type for transformation in AzurermDataFactoryFlowletDataFlow.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowTransformationBlock : TerraformBlock
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
    public TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Flowlet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flowlet block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlockFlowletBlock>? Flowlet
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlockFlowletBlock>>("flowlet");
        set => SetArgument("flowlet", value);
    }

    /// <summary>
    /// LinkedService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinkedService block(s) allowed")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlockLinkedServiceBlock>? LinkedService
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlockLinkedServiceBlock>>("linked_service");
        set => SetArgument("linked_service", value);
    }

}

/// <summary>
/// Block type for dataset in AzurermDataFactoryFlowletDataFlowTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowTransformationBlockDatasetBlock : TerraformBlock
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
/// Block type for flowlet in AzurermDataFactoryFlowletDataFlowTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowTransformationBlockFlowletBlock : TerraformBlock
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
/// Block type for linked_service in AzurermDataFactoryFlowletDataFlowTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryFlowletDataFlowTransformationBlockLinkedServiceBlock : TerraformBlock
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
/// Represents a azurerm_data_factory_flowlet_data_flow Terraform resource.
/// Manages a azurerm_data_factory_flowlet_data_flow resource.
/// </summary>
public partial class AzurermDataFactoryFlowletDataFlow(string name) : TerraformResource("azurerm_data_factory_flowlet_data_flow", name)
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// </summary>
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlock>? Sink
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlock>>("sink");
        set => SetArgument("sink", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryFlowletDataFlowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryFlowletDataFlowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Transformation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlock>? Transformation
    {
        get => GetArgument<TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlock>>("transformation");
        set => SetArgument("transformation", value);
    }

}
