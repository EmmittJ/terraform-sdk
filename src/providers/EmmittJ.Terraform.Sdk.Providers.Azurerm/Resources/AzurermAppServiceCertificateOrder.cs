using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceCertificateOrder.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateOrderTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_certificate_order Terraform resource.
/// Manages a azurerm_app_service_certificate_order resource.
/// </summary>
public partial class AzurermAppServiceCertificateOrder(string name) : TerraformResource("azurerm_app_service_certificate_order", name)
{
    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformValue<bool>? AutoRenew
    {
        get => GetArgument<TerraformValue<bool>>("auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformValue<string> Csr
    {
        get => GetArgument<TerraformValue<string>>("csr") ?? AsReference("csr");
        set => SetArgument("csr", value);
    }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public TerraformValue<string> DistinguishedName
    {
        get => GetArgument<TerraformValue<string>>("distinguished_name") ?? AsReference("distinguished_name");
        set => SetArgument("distinguished_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double>? KeySize
    {
        get => GetArgument<TerraformValue<double>>("key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The product_type attribute.
    /// </summary>
    public TerraformValue<string>? ProductType
    {
        get => GetArgument<TerraformValue<string>>("product_type");
        set => SetArgument("product_type", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    public TerraformValue<double>? ValidityInYears
    {
        get => GetArgument<TerraformValue<double>>("validity_in_years");
        set => SetArgument("validity_in_years", value);
    }

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    public TerraformList<string> AppServiceCertificateNotRenewableReasons
        => AsReference("app_service_certificate_not_renewable_reasons");

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
        => AsReference("certificates");

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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCertificateOrderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateOrderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
