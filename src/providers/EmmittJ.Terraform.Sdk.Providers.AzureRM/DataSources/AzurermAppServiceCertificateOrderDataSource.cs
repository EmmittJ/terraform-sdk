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
        set => SetProperty("read", value);
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
        SetOutput("app_service_certificate_not_renewable_reasons");
        SetOutput("auto_renew");
        SetOutput("certificates");
        SetOutput("csr");
        SetOutput("distinguished_name");
        SetOutput("domain_verification_token");
        SetOutput("expiration_time");
        SetOutput("intermediate_thumbprint");
        SetOutput("is_private_key_external");
        SetOutput("key_size");
        SetOutput("location");
        SetOutput("product_type");
        SetOutput("root_thumbprint");
        SetOutput("signed_certificate_thumbprint");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("validity_in_years");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
