using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_center_dev_box_definition resource.
/// </summary>
public class AzurermDevCenterDevBoxDefinition : TerraformResource
{
    public AzurermDevCenterDevBoxDefinition(string name) : base("azurerm_dev_center_dev_box_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformProperty<string>? DevCenterId
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_id");
        set => this.WithProperty("dev_center_id", value);
    }

    /// <summary>
    /// The hibernate_support_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HibernateSupportEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hibernate_support_enabled");
        set => this.WithProperty("hibernate_support_enabled", value);
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
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageReferenceId
    {
        get => GetProperty<TerraformProperty<string>>("image_reference_id");
        set => this.WithProperty("image_reference_id", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
