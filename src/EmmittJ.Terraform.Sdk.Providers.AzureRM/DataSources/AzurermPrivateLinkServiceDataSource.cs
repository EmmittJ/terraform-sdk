using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_private_link_service.
/// </summary>
public class AzurermPrivateLinkServiceDataSource : TerraformDataSource
{
    public AzurermPrivateLinkServiceDataSource(string name) : base("azurerm_private_link_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
        this.DeclareOutput("auto_approval_subscription_ids");
        this.DeclareOutput("enable_proxy_protocol");
        this.DeclareOutput("load_balancer_frontend_ip_configuration_ids");
        this.DeclareOutput("location");
        this.DeclareOutput("nat_ip_configuration");
        this.DeclareOutput("tags");
        this.DeclareOutput("visibility_subscription_ids");
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
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    public TerraformExpression AutoApprovalSubscriptionIds => this["auto_approval_subscription_ids"];

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public TerraformExpression EnableProxyProtocol => this["enable_proxy_protocol"];

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public TerraformExpression LoadBalancerFrontendIpConfigurationIds => this["load_balancer_frontend_ip_configuration_ids"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    public TerraformExpression NatIpConfiguration => this["nat_ip_configuration"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public TerraformExpression VisibilitySubscriptionIds => this["visibility_subscription_ids"];

}
