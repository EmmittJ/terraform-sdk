using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_build_pack_binding resource.
/// </summary>
public class AzurermSpringCloudBuildPackBinding : TerraformResource
{
    public AzurermSpringCloudBuildPackBinding(string name) : base("azurerm_spring_cloud_build_pack_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The binding_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BindingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("binding_type");
        set => this.WithProperty("binding_type", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_builder_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudBuilderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_builder_id");
        set => this.WithProperty("spring_cloud_builder_id", value);
    }

}
