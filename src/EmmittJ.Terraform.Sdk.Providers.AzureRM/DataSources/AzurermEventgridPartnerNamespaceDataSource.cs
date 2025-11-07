using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_eventgrid_partner_namespace.
/// </summary>
public class AzurermEventgridPartnerNamespaceDataSource : TerraformDataSource
{
    public AzurermEventgridPartnerNamespaceDataSource(string name) : base("azurerm_eventgrid_partner_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("inbound_ip_rule");
        this.DeclareOutput("local_authentication_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("partner_registration_id");
        this.DeclareOutput("partner_topic_routing_mode");
        this.DeclareOutput("public_network_access");
        this.DeclareOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    public TerraformExpression InboundIpRule => this["inbound_ip_rule"];

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression LocalAuthenticationEnabled => this["local_authentication_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    public TerraformExpression PartnerRegistrationId => this["partner_registration_id"];

    /// <summary>
    /// The partner_topic_routing_mode attribute.
    /// </summary>
    public TerraformExpression PartnerTopicRoutingMode => this["partner_topic_routing_mode"];

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccess => this["public_network_access"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
