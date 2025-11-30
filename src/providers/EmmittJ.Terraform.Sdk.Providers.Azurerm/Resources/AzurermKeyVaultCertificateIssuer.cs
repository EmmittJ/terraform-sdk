using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for admin in AzurermKeyVaultCertificateIssuer.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateIssuerAdminBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin";

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformValue<string> EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public TerraformValue<string>? Phone
    {
        get => new TerraformReference<string>(this, "phone");
        set => SetArgument("phone", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKeyVaultCertificateIssuer.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateIssuerTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_certificate_issuer Terraform resource.
/// Manages a azurerm_key_vault_certificate_issuer resource.
/// </summary>
public partial class AzurermKeyVaultCertificateIssuer(string name) : TerraformResource("azurerm_key_vault_certificate_issuer", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string>? OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// Admin block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermKeyVaultCertificateIssuerAdminBlock>? Admin
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateIssuerAdminBlock>>("admin");
        set => SetArgument("admin", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateIssuerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateIssuerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
