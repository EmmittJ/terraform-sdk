using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_insights_workbook resource.
/// </summary>
public class AzurermApplicationInsightsWorkbook : TerraformResource
{
    public AzurermApplicationInsightsWorkbook(string name) : base("azurerm_application_insights_workbook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformProperty<string>? Category
    {
        get => GetProperty<TerraformProperty<string>>("category");
        set => this.WithProperty("category", value);
    }

    /// <summary>
    /// The data_json attribute.
    /// </summary>
    public TerraformProperty<string>? DataJson
    {
        get => GetProperty<TerraformProperty<string>>("data_json");
        set => this.WithProperty("data_json", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_id");
        set => this.WithProperty("source_id", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageContainerId
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_id");
        set => this.WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
