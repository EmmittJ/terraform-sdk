using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_gallery_application_assignment resource.
/// </summary>
public class AzurermVirtualMachineGalleryApplicationAssignment : TerraformResource
{
    public AzurermVirtualMachineGalleryApplicationAssignment(string name) : base("azurerm_virtual_machine_gallery_application_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public string? ConfigurationBlobUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_blob_uri")?.Value;
        set => this.WithProperty("configuration_blob_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gallery_application_version_id attribute.
    /// </summary>
    public string? GalleryApplicationVersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_application_version_id")?.Value;
        set => this.WithProperty("gallery_application_version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The order attribute.
    /// </summary>
    public double? Order
    {
        get => GetProperty<TerraformLiteralProperty<double>>("order")?.Value;
        set => this.WithProperty("order", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public string? Tag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag")?.Value;
        set => this.WithProperty("tag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
