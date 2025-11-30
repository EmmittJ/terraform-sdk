using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataFactoryPipeline.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryPipelineTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_factory_pipeline Terraform resource.
/// Manages a azurerm_data_factory_pipeline resource.
/// </summary>
public partial class AzurermDataFactoryPipeline(string name) : TerraformResource("azurerm_data_factory_pipeline", name)
{
    /// <summary>
    /// The activities_json attribute.
    /// </summary>
    public TerraformValue<string>? ActivitiesJson
    {
        get => new TerraformReference<string>(this, "activities_json");
        set => SetArgument("activities_json", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    public TerraformValue<double>? Concurrency
    {
        get => new TerraformReference<double>(this, "concurrency");
        set => SetArgument("concurrency", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
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
    /// The folder attribute.
    /// </summary>
    public TerraformValue<string>? Folder
    {
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
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
    /// The moniter_metrics_after_duration attribute.
    /// </summary>
    public TerraformValue<string>? MoniterMetricsAfterDuration
    {
        get => new TerraformReference<string>(this, "moniter_metrics_after_duration");
        set => SetArgument("moniter_metrics_after_duration", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public TerraformMap<string>? Variables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "variables").ResolveNodes(ctx));
        set => SetArgument("variables", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryPipelineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryPipelineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
