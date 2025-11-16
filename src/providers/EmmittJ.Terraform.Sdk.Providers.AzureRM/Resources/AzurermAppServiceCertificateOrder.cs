using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    public TerraformValue<string> Csr
    {
        get => new TerraformReference<string>(this, "csr");
        set => SetArgument("csr", value);
    }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    public TerraformValue<string> DistinguishedName
    {
        get => new TerraformReference<string>(this, "distinguished_name");
        set => SetArgument("distinguished_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double>? KeySize
    {
        get => new TerraformReference<double>(this, "key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    public TerraformValue<string>? ProductType
    {
        get => new TerraformReference<string>(this, "product_type");
        set => SetArgument("product_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    public TerraformValue<double>? ValidityInYears
    {
        get => new TerraformReference<double>(this, "validity_in_years");
        set => SetArgument("validity_in_years", value);
    }

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    public TerraformList<string> AppServiceCertificateNotRenewableReasons
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "app_service_certificate_not_renewable_reasons").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    public TerraformValue<string> DomainVerificationToken
    {
        get => new TerraformReference<string>(this, "domain_verification_token");
    }

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    public TerraformValue<string> ExpirationTime
    {
        get => new TerraformReference<string>(this, "expiration_time");
    }

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> IntermediateThumbprint
    {
        get => new TerraformReference<string>(this, "intermediate_thumbprint");
    }

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    public TerraformValue<bool> IsPrivateKeyExternal
    {
        get => new TerraformReference<bool>(this, "is_private_key_external");
    }

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> RootThumbprint
    {
        get => new TerraformReference<string>(this, "root_thumbprint");
    }

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> SignedCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "signed_certificate_thumbprint");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceCertificateOrderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateOrderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
