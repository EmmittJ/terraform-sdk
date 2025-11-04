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
    public string? ElasticSanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_san_id")?.Value;
        set => this.WithProperty("elastic_san_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public string? EncryptionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_type")?.Value;
        set => this.WithProperty("encryption_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The protocol_type attribute.
    /// </summary>
    public string? ProtocolType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol_type")?.Value;
        set => this.WithProperty("protocol_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
