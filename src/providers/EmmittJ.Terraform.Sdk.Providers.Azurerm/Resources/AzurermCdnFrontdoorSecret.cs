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
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public TerraformList<string> SubjectAlternativeNames
        => CreateReference("subject_alternative_names");

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
        get => GetRequiredArgument<TerraformValue<string>>("cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
    }

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
    /// The cdn_frontdoor_profile_name attribute.
    /// </summary>
    public TerraformValue<string> CdnFrontdoorProfileName
        => CreateReference("cdn_frontdoor_profile_name");

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
