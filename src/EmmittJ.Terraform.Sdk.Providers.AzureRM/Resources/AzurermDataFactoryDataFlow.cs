using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_data_flow resource.
/// </summary>
public class AzurermDataFactoryDataFlow : TerraformResource
{
    public AzurermDataFactoryDataFlow(string name) : base("azurerm_data_factory_data_flow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The folder attribute.
    /// </summary>
    public string? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder")?.Value;
        set => this.WithProperty("folder", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    public string? Script
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script")?.Value;
        set => this.WithProperty("script", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script_lines attribute.
    /// </summary>
    public List<string>? ScriptLines
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("script_lines")?.Value;
        set => this.WithProperty("script_lines", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
