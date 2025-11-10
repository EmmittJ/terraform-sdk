using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("app_service_certificate_not_renewable_reasons");
        this.WithOutput("auto_renew");
        this.WithOutput("certificates");
        this.WithOutput("csr");
        this.WithOutput("distinguished_name");
        this.WithOutput("domain_verification_token");
        this.WithOutput("expiration_time");
        this.WithOutput("intermediate_thumbprint");
        this.WithOutput("is_private_key_external");
        this.WithOutput("key_size");
        this.WithOutput("location");
        this.WithOutput("product_type");
        this.WithOutput("root_thumbprint");
        this.WithOutput("signed_certificate_thumbprint");
        this.WithOutput("status");
        this.WithOutput("tags");
        this.WithOutput("validity_in_years");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
