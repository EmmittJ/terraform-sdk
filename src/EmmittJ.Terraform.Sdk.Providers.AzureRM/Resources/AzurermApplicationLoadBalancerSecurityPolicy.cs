using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_load_balancer_security_policy resource.
/// </summary>
public class AzurermApplicationLoadBalancerSecurityPolicy : TerraformResource
{
    public AzurermApplicationLoadBalancerSecurityPolicy(string name) : base("azurerm_application_load_balancer_security_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_load_balancer_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationLoadBalancerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_load_balancer_id");
        set => this.WithProperty("application_load_balancer_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebApplicationFirewallPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_application_firewall_policy_id");
        set => this.WithProperty("web_application_firewall_policy_id", value);
    }

}
