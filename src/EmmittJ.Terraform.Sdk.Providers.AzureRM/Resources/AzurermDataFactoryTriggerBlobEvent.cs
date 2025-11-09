using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformMapProperty<string>? AdditionalProperties
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_properties");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

}
