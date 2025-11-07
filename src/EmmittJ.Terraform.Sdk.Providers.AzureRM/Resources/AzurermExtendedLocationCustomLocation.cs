using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_extended_location_custom_location resource.
/// </summary>
public class AzurermExtendedLocationCustomLocation : TerraformResource
{
    public AzurermExtendedLocationCustomLocation(string name) : base("azurerm_extended_location_custom_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ClusterExtensionIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cluster_extension_ids");
        set => this.WithProperty("cluster_extension_ids", value);
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
    /// The host_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_resource_id");
        set => this.WithProperty("host_resource_id", value);
    }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_type");
        set => this.WithProperty("host_type", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
