using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_elastic_san_volume resource.
/// </summary>
public class AzurermElasticSanVolume : TerraformResource
{
    public AzurermElasticSanVolume(string name) : base("azurerm_elastic_san_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("target_iqn");
        this.DeclareOutput("target_portal_hostname");
        this.DeclareOutput("target_portal_port");
        this.DeclareOutput("volume_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SizeInGib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size_in_gib");
        set => this.WithProperty("size_in_gib", value);
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumeGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_group_id");
        set => this.WithProperty("volume_group_id", value);
    }

    /// <summary>
    /// The target_iqn attribute.
    /// </summary>
    public TerraformExpression TargetIqn => this["target_iqn"];

    /// <summary>
    /// The target_portal_hostname attribute.
    /// </summary>
    public TerraformExpression TargetPortalHostname => this["target_portal_hostname"];

    /// <summary>
    /// The target_portal_port attribute.
    /// </summary>
    public TerraformExpression TargetPortalPort => this["target_portal_port"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

}
