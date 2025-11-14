using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_certificate_order resource.
/// </summary>
public class AzurermAppServiceCertificateOrder : TerraformResource
{
    public AzurermAppServiceCertificateOrder(string name) : base("azurerm_app_service_certificate_order", name)
    {
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformArgument("auto_renew")]
    public TerraformValue<bool>? AutoRenew
    {
        get => new TerraformReference<bool>(this, "auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformArgument("csr")]
    public TerraformValue<string> Csr
    {
        get => new TerraformReference<string>(this, "csr");
        set => SetArgument("csr", value);
    }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    [TerraformArgument("distinguished_name")]
    public TerraformValue<string> DistinguishedName
    {
        get => new TerraformReference<string>(this, "distinguished_name");
        set => SetArgument("distinguished_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformArgument("key_size")]
    public TerraformValue<double>? KeySize
    {
        get => new TerraformReference<double>(this, "key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    [TerraformArgument("product_type")]
    public TerraformValue<string>? ProductType
    {
        get => new TerraformReference<string>(this, "product_type");
        set => SetArgument("product_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    [TerraformArgument("validity_in_years")]
    public TerraformValue<double>? ValidityInYears
    {
        get => new TerraformReference<double>(this, "validity_in_years");
        set => SetArgument("validity_in_years", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceCertificateOrderTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    [TerraformArgument("app_service_certificate_not_renewable_reasons")]
    public TerraformList<string> AppServiceCertificateNotRenewableReasons
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "app_service_certificate_not_renewable_reasons").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformArgument("certificates")]
    public TerraformList<object> Certificates
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    [TerraformArgument("domain_verification_token")]
    public TerraformValue<string> DomainVerificationToken
    {
        get => new TerraformReference<string>(this, "domain_verification_token");
    }

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    [TerraformArgument("expiration_time")]
    public TerraformValue<string> ExpirationTime
    {
        get => new TerraformReference<string>(this, "expiration_time");
    }

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    [TerraformArgument("intermediate_thumbprint")]
    public TerraformValue<string> IntermediateThumbprint
    {
        get => new TerraformReference<string>(this, "intermediate_thumbprint");
    }

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    [TerraformArgument("is_private_key_external")]
    public TerraformValue<bool> IsPrivateKeyExternal
    {
        get => new TerraformReference<bool>(this, "is_private_key_external");
    }

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    [TerraformArgument("root_thumbprint")]
    public TerraformValue<string> RootThumbprint
    {
        get => new TerraformReference<string>(this, "root_thumbprint");
    }

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    [TerraformArgument("signed_certificate_thumbprint")]
    public TerraformValue<string> SignedCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "signed_certificate_thumbprint");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
