using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_extended_custom_location resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermExtendedCustomLocation : TerraformResource
{
    public AzurermExtendedCustomLocation(string name) : base("azurerm_extended_custom_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    public List<string>? ClusterExtensionIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cluster_extension_ids")?.Value;
        set => this.WithProperty("cluster_extension_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The host_resource_id attribute.
    /// </summary>
    public string? HostResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_resource_id")?.Value;
        set => this.WithProperty("host_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    public string? HostType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_type")?.Value;
        set => this.WithProperty("host_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The namespace attribute.
    /// </summary>
    public string? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace")?.Value;
        set => this.WithProperty("namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
