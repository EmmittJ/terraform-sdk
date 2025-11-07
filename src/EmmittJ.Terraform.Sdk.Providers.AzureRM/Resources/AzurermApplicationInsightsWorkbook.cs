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
    public TerraformLiteralProperty<string>? Category
    {
        get => GetProperty<TerraformLiteralProperty<string>>("category");
        set => this.WithProperty("category", value);
    }

    /// <summary>
    /// The data_json attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_json");
        set => this.WithProperty("data_json", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_id");
        set => this.WithProperty("source_id", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_id");
        set => this.WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
