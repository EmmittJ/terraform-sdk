using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for secret in AzurermCdnFrontdoorSecret.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorSecretSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// CustomerCertificate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerCertificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CustomerCertificate block(s) required")]
    public required TerraformList<AzurermCdnFrontdoorSecretSecretBlockCustomerCertificateBlock> CustomerCertificate
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorSecretSecretBlockCustomerCertificateBlock>>("customer_certificate");
        set => SetArgument("customer_certificate", value);
    }

}

/// <summary>
/// Block type for customer_certificate in AzurermCdnFrontdoorSecretSecretBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorSecretSecretBlockCustomerCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_certificate";

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultCertificateId is required")]
    public required TerraformValue<string> KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public TerraformList<string> SubjectAlternativeNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subject_alternative_names").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorSecret.
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorSecretTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_cdn_frontdoor_secret Terraform resource.
/// Manages a azurerm_cdn_frontdoor_secret resource.
/// </summary>
public partial class AzurermCdnFrontdoorSecret(string name) : TerraformResource("azurerm_cdn_frontdoor_secret", name)
{
    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformValue<string> CdnFrontdoorProfileId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The cdn_frontdoor_profile_name attribute.
    /// </summary>
    public TerraformValue<string> CdnFrontdoorProfileName
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_name");
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secret block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secret block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorSecretSecretBlock> Secret
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorSecretSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorSecretTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorSecretTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
