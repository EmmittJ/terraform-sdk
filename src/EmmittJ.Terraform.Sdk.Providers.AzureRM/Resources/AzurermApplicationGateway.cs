using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_gateway resource.
/// </summary>
public class AzurermApplicationGateway : TerraformResource
{
    public AzurermApplicationGateway(string name) : base("azurerm_application_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("private_endpoint_connection");
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableHttp2
    {
        get => GetProperty<TerraformProperty<bool>>("enable_http2");
        set => this.WithProperty("enable_http2", value);
    }

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy_id");
        set => this.WithProperty("firewall_policy_id", value);
    }

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceFirewallPolicyAssociation
    {
        get => GetProperty<TerraformProperty<bool>>("force_firewall_policy_association");
        set => this.WithProperty("force_firewall_policy_association", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnection => this["private_endpoint_connection"];

}
