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
    public string? BindingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("binding_type")?.Value;
        set => this.WithProperty("binding_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The spring_cloud_builder_id attribute.
    /// </summary>
    public string? SpringCloudBuilderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_builder_id")?.Value;
        set => this.WithProperty("spring_cloud_builder_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
