using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryTriggerBlobEventPipelineBlock : TerraformBlock
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
public class AzurermDataFactoryTriggerBlobEventTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_trigger_blob_event resource.
/// </summary>
public class AzurermDataFactoryTriggerBlobEvent : TerraformResource
{
    public AzurermDataFactoryTriggerBlobEvent(string name) : base("azurerm_data_factory_trigger_blob_event", name)
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
    /// The blob_path_begins_with attribute.
    /// </summary>
    public TerraformProperty<string>? BlobPathBeginsWith
    {
        get => GetProperty<TerraformProperty<string>>("blob_path_begins_with");
        set => this.WithProperty("blob_path_begins_with", value);
    }

    /// <summary>
    /// The blob_path_ends_with attribute.
    /// </summary>
    public TerraformProperty<string>? BlobPathEndsWith
    {
        get => GetProperty<TerraformProperty<string>>("blob_path_ends_with");
        set => this.WithProperty("blob_path_ends_with", value);
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
    /// The ignore_empty_blobs attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreEmptyBlobs
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_empty_blobs");
        set => this.WithProperty("ignore_empty_blobs", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    public HashSet<AzurermDataFactoryTriggerBlobEventPipelineBlock>? Pipeline
    {
        get => GetProperty<HashSet<AzurermDataFactoryTriggerBlobEventPipelineBlock>>("pipeline");
        set => this.WithProperty("pipeline", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTriggerBlobEventTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryTriggerBlobEventTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
