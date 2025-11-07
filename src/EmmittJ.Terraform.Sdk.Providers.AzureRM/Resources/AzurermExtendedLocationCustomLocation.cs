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
    public TerraformProperty<List<string>>? ClusterExtensionIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("cluster_extension_ids");
        set => this.WithProperty("cluster_extension_ids", value);
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
    /// The host_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceId
    {
        get => GetProperty<TerraformProperty<string>>("host_resource_id");
        set => this.WithProperty("host_resource_id", value);
    }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    public TerraformProperty<string>? HostType
    {
        get => GetProperty<TerraformProperty<string>>("host_type");
        set => this.WithProperty("host_type", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
