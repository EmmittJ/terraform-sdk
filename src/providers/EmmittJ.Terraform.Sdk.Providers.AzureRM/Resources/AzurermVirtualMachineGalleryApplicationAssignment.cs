using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_virtual_machine_gallery_application_assignment Terraform resource.
/// Manages a azurerm_virtual_machine_gallery_application_assignment resource.
/// </summary>
public partial class AzurermVirtualMachineGalleryApplicationAssignment(string name) : TerraformResource("azurerm_virtual_machine_gallery_application_assignment", name)
{
    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationBlobUri
    {
        get => new TerraformReference<string>(this, "configuration_blob_uri");
        set => SetArgument("configuration_blob_uri", value);
    }

    /// <summary>
    /// The gallery_application_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationVersionId is required")]
    public required TerraformValue<string> GalleryApplicationVersionId
    {
        get => new TerraformReference<string>(this, "gallery_application_version_id");
        set => SetArgument("gallery_application_version_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double>? Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformValue<string> VirtualMachineId
    {
        get => new TerraformReference<string>(this, "virtual_machine_id");
        set => SetArgument("virtual_machine_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineGalleryApplicationAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
