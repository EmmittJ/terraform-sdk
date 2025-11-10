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
        SetOutput("id");
        SetOutput("name");
        SetOutput("netapp_volume_id");
        SetOutput("vmware_cluster_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The netapp_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetappVolumeId is required")]
    public required TerraformProperty<string> NetappVolumeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("netapp_volume_id");
        set => SetProperty("netapp_volume_id", value);
    }

    /// <summary>
    /// The vmware_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareClusterId is required")]
    public required TerraformProperty<string> VmwareClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vmware_cluster_id");
        set => SetProperty("vmware_cluster_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVmwareNetappVolumeAttachmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
