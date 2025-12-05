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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    public TerraformList<string> AppServiceCertificateNotRenewableReasons
        => CreateReference("app_service_certificate_not_renewable_reasons");

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformValue<bool> AutoRenew
        => CreateReference("auto_renew");

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
        => CreateReference("certificates");

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformValue<string> Csr
        => CreateReference("csr");

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public TerraformValue<string> DistinguishedName
        => CreateReference("distinguished_name");

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    public TerraformValue<string> DomainVerificationToken
        => CreateReference("domain_verification_token");

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    public TerraformValue<string> ExpirationTime
        => CreateReference("expiration_time");

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> IntermediateThumbprint
        => CreateReference("intermediate_thumbprint");

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    public TerraformValue<bool> IsPrivateKeyExternal
        => CreateReference("is_private_key_external");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double> KeySize
        => CreateReference("key_size");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    public TerraformValue<string> ProductType
        => CreateReference("product_type");

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> RootThumbprint
        => CreateReference("root_thumbprint");

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> SignedCertificateThumbprint
        => CreateReference("signed_certificate_thumbprint");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    public TerraformValue<double> ValidityInYears
        => CreateReference("validity_in_years");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
