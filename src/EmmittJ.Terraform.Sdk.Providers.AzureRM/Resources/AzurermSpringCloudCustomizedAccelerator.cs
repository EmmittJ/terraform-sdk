using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
public class AzurermSpringCloudCustomizedAccelerator : TerraformResource
{
    public AzurermSpringCloudCustomizedAccelerator(string name) : base("azurerm_spring_cloud_customized_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    public List<string>? AcceleratorTags
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("accelerator_tags")?.Value;
        set => this.WithProperty("accelerator_tags", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public string? AcceleratorType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accelerator_type")?.Value;
        set => this.WithProperty("accelerator_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public string? IconUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon_url")?.Value;
        set => this.WithProperty("icon_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    public string? SpringCloudAcceleratorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_accelerator_id")?.Value;
        set => this.WithProperty("spring_cloud_accelerator_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
