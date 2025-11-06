using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_confidential_ledger.
/// </summary>
public class AzurermConfidentialLedgerDataSource : TerraformDataSource
{
    public AzurermConfidentialLedgerDataSource(string name) : base("azurerm_confidential_ledger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("azuread_based_service_principal");
        this.DeclareOutput("certificate_based_security_principal");
        this.DeclareOutput("identity_service_endpoint");
        this.DeclareOutput("ledger_endpoint");
        this.DeclareOutput("ledger_type");
        this.DeclareOutput("location");
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
    /// The azuread_based_service_principal attribute.
    /// </summary>
    public TerraformExpression AzureadBasedServicePrincipal => this["azuread_based_service_principal"];

    /// <summary>
    /// The certificate_based_security_principal attribute.
    /// </summary>
    public TerraformExpression CertificateBasedSecurityPrincipal => this["certificate_based_security_principal"];

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    public TerraformExpression IdentityServiceEndpoint => this["identity_service_endpoint"];

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    public TerraformExpression LedgerEndpoint => this["ledger_endpoint"];

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    public TerraformExpression LedgerType => this["ledger_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
