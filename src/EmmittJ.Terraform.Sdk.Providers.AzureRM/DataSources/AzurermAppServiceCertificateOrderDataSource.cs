using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_app_service_certificate_order.
/// </summary>
public class AzurermAppServiceCertificateOrderDataSource : TerraformDataSource
{
    public AzurermAppServiceCertificateOrderDataSource(string name) : base("azurerm_app_service_certificate_order", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_service_certificate_not_renewable_reasons");
        this.DeclareOutput("auto_renew");
        this.DeclareOutput("certificates");
        this.DeclareOutput("csr");
        this.DeclareOutput("distinguished_name");
        this.DeclareOutput("domain_verification_token");
        this.DeclareOutput("expiration_time");
        this.DeclareOutput("intermediate_thumbprint");
        this.DeclareOutput("is_private_key_external");
        this.DeclareOutput("key_size");
        this.DeclareOutput("location");
        this.DeclareOutput("product_type");
        this.DeclareOutput("root_thumbprint");
        this.DeclareOutput("signed_certificate_thumbprint");
        this.DeclareOutput("status");
        this.DeclareOutput("tags");
        this.DeclareOutput("validity_in_years");
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
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    public TerraformExpression AppServiceCertificateNotRenewableReasons => this["app_service_certificate_not_renewable_reasons"];

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformExpression AutoRenew => this["auto_renew"];

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformExpression Certificates => this["certificates"];

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformExpression Csr => this["csr"];

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public TerraformExpression DistinguishedName => this["distinguished_name"];

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    public TerraformExpression DomainVerificationToken => this["domain_verification_token"];

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    public TerraformExpression ExpirationTime => this["expiration_time"];

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    public TerraformExpression IntermediateThumbprint => this["intermediate_thumbprint"];

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    public TerraformExpression IsPrivateKeyExternal => this["is_private_key_external"];

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformExpression KeySize => this["key_size"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    public TerraformExpression ProductType => this["product_type"];

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    public TerraformExpression RootThumbprint => this["root_thumbprint"];

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    public TerraformExpression SignedCertificateThumbprint => this["signed_certificate_thumbprint"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    public TerraformExpression ValidityInYears => this["validity_in_years"];

}
