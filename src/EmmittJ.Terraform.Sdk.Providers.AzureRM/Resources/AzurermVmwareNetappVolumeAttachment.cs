using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwareNetappVolumeAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_vmware_netapp_volume_attachment resource.
/// </summary>
public class AzurermVmwareNetappVolumeAttachment : TerraformResource
{
    public AzurermVmwareNetappVolumeAttachment(string name) : base("azurerm_vmware_netapp_volume_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The netapp_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappVolumeId is required")]
    public required TerraformProperty<string> NetappVolumeId
    {
        get => GetProperty<TerraformProperty<string>>("netapp_volume_id");
        set => this.WithProperty("netapp_volume_id", value);
    }

    /// <summary>
    /// The vmware_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareClusterId is required")]
    public required TerraformProperty<string> VmwareClusterId
    {
        get => GetProperty<TerraformProperty<string>>("vmware_cluster_id");
        set => this.WithProperty("vmware_cluster_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVmwareNetappVolumeAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVmwareNetappVolumeAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
