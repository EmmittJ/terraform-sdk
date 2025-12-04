using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVmwareNetappVolumeAttachment.
/// Nesting mode: single
/// </summary>
public class AzurermVmwareNetappVolumeAttachmentTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_vmware_netapp_volume_attachment Terraform resource.
/// Manages a azurerm_vmware_netapp_volume_attachment resource.
/// </summary>
public partial class AzurermVmwareNetappVolumeAttachment(string name) : TerraformResource("azurerm_vmware_netapp_volume_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The netapp_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappVolumeId is required")]
    public required TerraformValue<string> NetappVolumeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("netapp_volume_id");
        set => SetArgument("netapp_volume_id", value);
    }

    /// <summary>
    /// The vmware_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareClusterId is required")]
    public required TerraformValue<string> VmwareClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vmware_cluster_id");
        set => SetArgument("vmware_cluster_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVmwareNetappVolumeAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVmwareNetappVolumeAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
