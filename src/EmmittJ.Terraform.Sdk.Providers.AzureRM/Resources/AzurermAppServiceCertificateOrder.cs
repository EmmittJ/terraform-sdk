using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_certificate_order resource.
/// </summary>
public class AzurermAppServiceCertificateOrder : TerraformResource
{
    public AzurermAppServiceCertificateOrder(string name) : base("azurerm_app_service_certificate_order", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_service_certificate_not_renewable_reasons");
        this.DeclareOutput("certificates");
        this.DeclareOutput("domain_verification_token");
        this.DeclareOutput("expiration_time");
        this.DeclareOutput("intermediate_thumbprint");
        this.DeclareOutput("is_private_key_external");
        this.DeclareOutput("root_thumbprint");
        this.DeclareOutput("signed_certificate_thumbprint");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoRenew
    {
        get => GetProperty<TerraformProperty<bool>>("auto_renew");
        set => this.WithProperty("auto_renew", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformProperty<string>? Csr
    {
        get => GetProperty<TerraformProperty<string>>("csr");
        set => this.WithProperty("csr", value);
    }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? DistinguishedName
    {
        get => GetProperty<TerraformProperty<string>>("distinguished_name");
        set => this.WithProperty("distinguished_name", value);
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
    /// The key_size attribute.
    /// </summary>
    public TerraformProperty<double>? KeySize
    {
        get => GetProperty<TerraformProperty<double>>("key_size");
        set => this.WithProperty("key_size", value);
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
    /// The product_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProductType
    {
        get => GetProperty<TerraformProperty<string>>("product_type");
        set => this.WithProperty("product_type", value);
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
    /// The validity_in_years attribute.
    /// </summary>
    public TerraformProperty<double>? ValidityInYears
    {
        get => GetProperty<TerraformProperty<double>>("validity_in_years");
        set => this.WithProperty("validity_in_years", value);
    }

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    public TerraformExpression AppServiceCertificateNotRenewableReasons => this["app_service_certificate_not_renewable_reasons"];

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformExpression Certificates => this["certificates"];

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

}
