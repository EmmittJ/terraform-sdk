using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for contact in AzurermKeyVaultCertificateContacts.
/// Nesting mode: set
/// </summary>
public class AzurermKeyVaultCertificateContactsContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contact";

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public TerraformValue<string>? Phone
    {
        get => GetArgument<TerraformValue<string>>("phone");
        set => SetArgument("phone", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKeyVaultCertificateContacts.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateContactsTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_certificate_contacts Terraform resource.
/// Manages a azurerm_key_vault_certificate_contacts resource.
/// </summary>
public partial class AzurermKeyVaultCertificateContacts(string name) : TerraformResource("azurerm_key_vault_certificate_contacts", name)
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// Contact block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermKeyVaultCertificateContactsContactBlock>? Contact
    {
        get => GetArgument<TerraformSet<AzurermKeyVaultCertificateContactsContactBlock>>("contact");
        set => SetArgument("contact", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateContactsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateContactsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
