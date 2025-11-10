using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryTriggerCustomEventPipelineBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerCustomEventTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory_trigger_custom_event resource.
/// </summary>
public class AzurermDataFactoryTriggerCustomEvent : TerraformResource
{
    public AzurermDataFactoryTriggerCustomEvent(string name) : base("azurerm_data_factory_trigger_custom_event", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    public TerraformProperty<bool>? Activated
    {
        get => GetProperty<TerraformProperty<bool>>("activated");
        set => this.WithProperty("activated", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The eventgrid_topic_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicId is required")]
    public required TerraformProperty<string> EventgridTopicId
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_id");
        set => this.WithProperty("eventgrid_topic_id", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public HashSet<TerraformProperty<string>>? Events
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("events");
        set => this.WithProperty("events", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The subject_begins_with attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectBeginsWith
    {
        get => GetProperty<TerraformProperty<string>>("subject_begins_with");
        set => this.WithProperty("subject_begins_with", value);
    }

    /// <summary>
    /// The subject_ends_with attribute.
    /// </summary>
    public TerraformProperty<string>? SubjectEndsWith
    {
        get => GetProperty<TerraformProperty<string>>("subject_ends_with");
        set => this.WithProperty("subject_ends_with", value);
    }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    public HashSet<AzurermDataFactoryTriggerCustomEventPipelineBlock>? Pipeline
    {
        get => GetProperty<HashSet<AzurermDataFactoryTriggerCustomEventPipelineBlock>>("pipeline");
        set => this.WithProperty("pipeline", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTriggerCustomEventTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryTriggerCustomEventTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
