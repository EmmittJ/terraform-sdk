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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
