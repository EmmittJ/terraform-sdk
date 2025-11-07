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
    public TerraformProperty<List<string>>? AcceleratorTags
    {
        get => GetProperty<TerraformProperty<List<string>>>("accelerator_tags");
        set => this.WithProperty("accelerator_tags", value);
    }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => this.WithProperty("accelerator_type", value);
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
    /// The icon_url attribute.
    /// </summary>
    public TerraformProperty<string>? IconUrl
    {
        get => GetProperty<TerraformProperty<string>>("icon_url");
        set => this.WithProperty("icon_url", value);
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
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudAcceleratorId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_accelerator_id");
        set => this.WithProperty("spring_cloud_accelerator_id", value);
    }

}
