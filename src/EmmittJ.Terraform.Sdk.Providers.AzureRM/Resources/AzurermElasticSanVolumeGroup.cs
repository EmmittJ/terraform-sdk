using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_elastic_san_volume_group resource.
/// </summary>
public class AzurermElasticSanVolumeGroup : TerraformResource
{
    public AzurermElasticSanVolumeGroup(string name) : base("azurerm_elastic_san_volume_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticSanId
    {
        get => GetProperty<TerraformProperty<string>>("elastic_san_id");
        set => this.WithProperty("elastic_san_id", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => this.WithProperty("encryption_type", value);
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
    /// The protocol_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProtocolType
    {
        get => GetProperty<TerraformProperty<string>>("protocol_type");
        set => this.WithProperty("protocol_type", value);
    }

}
