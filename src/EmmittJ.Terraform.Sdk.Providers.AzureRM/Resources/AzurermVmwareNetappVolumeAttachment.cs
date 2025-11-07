using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The netapp_volume_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetappVolumeId
    {
        get => GetProperty<TerraformProperty<string>>("netapp_volume_id");
        set => this.WithProperty("netapp_volume_id", value);
    }

    /// <summary>
    /// The vmware_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? VmwareClusterId
    {
        get => GetProperty<TerraformProperty<string>>("vmware_cluster_id");
        set => this.WithProperty("vmware_cluster_id", value);
    }

}
