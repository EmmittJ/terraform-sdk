using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_load_balancer_frontend resource.
/// </summary>
public class AzurermApplicationLoadBalancerFrontend : TerraformResource
{
    public AzurermApplicationLoadBalancerFrontend(string name) : base("azurerm_application_load_balancer_frontend", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fully_qualified_domain_name");
    }

    /// <summary>
    /// The application_load_balancer_id attribute.
    /// </summary>
    public string? ApplicationLoadBalancerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_load_balancer_id")?.Value;
        set => this.WithProperty("application_load_balancer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    public TerraformExpression FullyQualifiedDomainName => this["fully_qualified_domain_name"];

}
