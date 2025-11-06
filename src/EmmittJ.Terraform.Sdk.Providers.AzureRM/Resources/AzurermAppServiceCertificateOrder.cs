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
    public bool? AutoRenew
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_renew")?.Value;
        set => this.WithProperty("auto_renew", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public string? Csr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("csr")?.Value;
        set => this.WithProperty("csr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public string? DistinguishedName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("distinguished_name")?.Value;
        set => this.WithProperty("distinguished_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_size attribute.
    /// </summary>
    public double? KeySize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("key_size")?.Value;
        set => this.WithProperty("key_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The product_type attribute.
    /// </summary>
    public string? ProductType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_type")?.Value;
        set => this.WithProperty("product_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The validity_in_years attribute.
    /// </summary>
    public double? ValidityInYears
    {
        get => GetProperty<TerraformLiteralProperty<double>>("validity_in_years")?.Value;
        set => this.WithProperty("validity_in_years", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
