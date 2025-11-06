using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_link_service resource.
/// </summary>
public class AzurermPrivateLinkService : TerraformResource
{
    public AzurermPrivateLinkService(string name) : base("azurerm_private_link_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
    }

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    public HashSet<string>? AutoApprovalSubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("auto_approval_subscription_ids")?.Value;
        set => this.WithProperty("auto_approval_subscription_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The destination_ip_address attribute.
    /// </summary>
    public string? DestinationIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_ip_address")?.Value;
        set => this.WithProperty("destination_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public bool? EnableProxyProtocol
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_proxy_protocol")?.Value;
        set => this.WithProperty("enable_proxy_protocol", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public List<string>? Fqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fqdns")?.Value;
        set => this.WithProperty("fqdns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public HashSet<string>? LoadBalancerFrontendIpConfigurationIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("load_balancer_frontend_ip_configuration_ids")?.Value;
        set => this.WithProperty("load_balancer_frontend_ip_configuration_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public HashSet<string>? VisibilitySubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("visibility_subscription_ids")?.Value;
        set => this.WithProperty("visibility_subscription_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

}
