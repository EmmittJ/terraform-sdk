using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_frontdoor_firewall_policy resource.
/// </summary>
public class AzurermFrontdoorFirewallPolicy : TerraformResource
{
    public AzurermFrontdoorFirewallPolicy(string name) : base("azurerm_frontdoor_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("frontend_endpoint_ids");
        this.DeclareOutput("location");
    }

    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    public TerraformProperty<string>? CustomBlockResponseBody
    {
        get => GetProperty<TerraformProperty<string>>("custom_block_response_body");
        set => this.WithProperty("custom_block_response_body", value);
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    public TerraformProperty<double>? CustomBlockResponseStatusCode
    {
        get => GetProperty<TerraformProperty<double>>("custom_block_response_status_code");
        set => this.WithProperty("custom_block_response_status_code", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
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
    /// The redirect_url attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectUrl
    {
        get => GetProperty<TerraformProperty<string>>("redirect_url");
        set => this.WithProperty("redirect_url", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformExpression FrontendEndpointIds => this["frontend_endpoint_ids"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

}
