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
    public TerraformProperty<string>? ConfigurationBlobUri
    {
        get => GetProperty<TerraformProperty<string>>("configuration_blob_uri");
        set => this.WithProperty("configuration_blob_uri", value);
    }

    /// <summary>
    /// The gallery_application_version_id attribute.
    /// </summary>
    public TerraformProperty<string>? GalleryApplicationVersionId
    {
        get => GetProperty<TerraformProperty<string>>("gallery_application_version_id");
        set => this.WithProperty("gallery_application_version_id", value);
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
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => this.WithProperty("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => this.WithProperty("tag", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

}
