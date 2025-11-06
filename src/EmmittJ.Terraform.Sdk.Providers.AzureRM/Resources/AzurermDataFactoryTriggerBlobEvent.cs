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
    public bool? Activated
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("activated")?.Value;
        set => this.WithProperty("activated", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties")?.Value;
        set => this.WithProperty("additional_properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The blob_path_begins_with attribute.
    /// </summary>
    public string? BlobPathBeginsWith
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_path_begins_with")?.Value;
        set => this.WithProperty("blob_path_begins_with", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The blob_path_ends_with attribute.
    /// </summary>
    public string? BlobPathEndsWith
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_path_ends_with")?.Value;
        set => this.WithProperty("blob_path_ends_with", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public string? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id")?.Value;
        set => this.WithProperty("data_factory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    public HashSet<string>? Events
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("events")?.Value;
        set => this.WithProperty("events", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ignore_empty_blobs attribute.
    /// </summary>
    public bool? IgnoreEmptyBlobs
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_empty_blobs")?.Value;
        set => this.WithProperty("ignore_empty_blobs", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
