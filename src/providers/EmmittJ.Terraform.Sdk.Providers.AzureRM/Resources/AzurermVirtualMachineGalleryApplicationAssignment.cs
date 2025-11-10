using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("configuration_blob_uri");
        SetOutput("gallery_application_version_id");
        SetOutput("id");
        SetOutput("order");
        SetOutput("tag");
        SetOutput("virtual_machine_id");
    }

    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string> ConfigurationBlobUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_blob_uri");
        set => SetProperty("configuration_blob_uri", value);
    }

    /// <summary>
    /// The gallery_application_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationVersionId is required")]
    public required TerraformProperty<string> GalleryApplicationVersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_application_version_id");
        set => SetProperty("gallery_application_version_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double> Order
    {
        get => GetRequiredOutput<TerraformProperty<double>>("order");
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string> Tag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tag");
        set => SetProperty("tag", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_id");
        set => SetProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
