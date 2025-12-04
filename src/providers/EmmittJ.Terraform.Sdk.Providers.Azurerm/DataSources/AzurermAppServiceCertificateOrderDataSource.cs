using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceCertificateOrderDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_certificate_order Terraform data source.
/// Retrieves information about a azurerm_app_service_certificate_order.
/// </summary>
public partial class AzurermAppServiceCertificateOrderDataSource(string name) : TerraformDataSource("azurerm_app_service_certificate_order", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    public TerraformList<string> AppServiceCertificateNotRenewableReasons
        => AsReference("app_service_certificate_not_renewable_reasons");

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformValue<bool> AutoRenew
        => AsReference("auto_renew");

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
        => AsReference("certificates");

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformValue<string> Csr
        => AsReference("csr");

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public TerraformValue<string> DistinguishedName
        => AsReference("distinguished_name");

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    public TerraformValue<string> DomainVerificationToken
        => AsReference("domain_verification_token");

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    public TerraformValue<string> ExpirationTime
        => AsReference("expiration_time");

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> IntermediateThumbprint
        => AsReference("intermediate_thumbprint");

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    public TerraformValue<bool> IsPrivateKeyExternal
        => AsReference("is_private_key_external");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double> KeySize
        => AsReference("key_size");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    public TerraformValue<string> ProductType
        => AsReference("product_type");

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> RootThumbprint
        => AsReference("root_thumbprint");

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> SignedCertificateThumbprint
        => AsReference("signed_certificate_thumbprint");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    public TerraformValue<double> ValidityInYears
        => AsReference("validity_in_years");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
