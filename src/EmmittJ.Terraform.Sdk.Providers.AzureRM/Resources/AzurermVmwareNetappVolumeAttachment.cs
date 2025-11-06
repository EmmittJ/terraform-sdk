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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The netapp_volume_id attribute.
    /// </summary>
    public string? NetappVolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("netapp_volume_id")?.Value;
        set => this.WithProperty("netapp_volume_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vmware_cluster_id attribute.
    /// </summary>
    public string? VmwareClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmware_cluster_id")?.Value;
        set => this.WithProperty("vmware_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
