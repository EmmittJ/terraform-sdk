using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_arc_resource_bridge_appliance.
/// </summary>
public class AzurermArcResourceBridgeApplianceDataSource : TerraformDataSource
{
    public AzurermArcResourceBridgeApplianceDataSource(string name) : base("azurerm_arc_resource_bridge_appliance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("distro");
        this.DeclareOutput("identity");
        this.DeclareOutput("infrastructure_provider");
        this.DeclareOutput("location");
        this.DeclareOutput("public_key_base64");
        this.DeclareOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The distro attribute.
    /// </summary>
    public TerraformExpression Distro => this["distro"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The infrastructure_provider attribute.
    /// </summary>
    public TerraformExpression InfrastructureProvider => this["infrastructure_provider"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The public_key_base64 attribute.
    /// </summary>
    public TerraformExpression PublicKeyBase64 => this["public_key_base64"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
