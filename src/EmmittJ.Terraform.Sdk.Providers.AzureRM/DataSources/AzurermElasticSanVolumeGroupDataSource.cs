using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_elastic_san_volume_group.
/// </summary>
public class AzurermElasticSanVolumeGroupDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeGroupDataSource(string name) : base("azurerm_elastic_san_volume_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("encryption");
        this.DeclareOutput("encryption_type");
        this.DeclareOutput("identity");
        this.DeclareOutput("network_rule");
        this.DeclareOutput("protocol_type");
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
    /// The encryption attribute.
    /// </summary>
    public TerraformExpression Encryption => this["encryption"];

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformExpression EncryptionType => this["encryption_type"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The network_rule attribute.
    /// </summary>
    public TerraformExpression NetworkRule => this["network_rule"];

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformExpression ProtocolType => this["protocol_type"];

}
