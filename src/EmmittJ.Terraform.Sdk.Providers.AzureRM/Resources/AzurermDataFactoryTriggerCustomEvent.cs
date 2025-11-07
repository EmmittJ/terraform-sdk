using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<Dictionary<string, string>>? AdditionalProperties
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
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
    public TerraformProperty<string>? EventgridTopicId
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_id");
        set => this.WithProperty("eventgrid_topic_id", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Events
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("events");
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
    public TerraformProperty<string>? Name
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

}
