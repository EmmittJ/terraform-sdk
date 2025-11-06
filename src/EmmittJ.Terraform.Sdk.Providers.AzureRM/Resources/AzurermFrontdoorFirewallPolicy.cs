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
    public string? CustomBlockResponseBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_block_response_body")?.Value;
        set => this.WithProperty("custom_block_response_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    public double? CustomBlockResponseStatusCode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("custom_block_response_status_code")?.Value;
        set => this.WithProperty("custom_block_response_status_code", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The redirect_url attribute.
    /// </summary>
    public string? RedirectUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redirect_url")?.Value;
        set => this.WithProperty("redirect_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformExpression FrontendEndpointIds => this["frontend_endpoint_ids"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

}
