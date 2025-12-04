using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultManagedStorageAccountSasTokenDefinition.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_managed_storage_account_sas_token_definition Terraform resource.
/// Manages a azurerm_key_vault_managed_storage_account_sas_token_definition resource.
/// </summary>
public partial class AzurermKeyVaultManagedStorageAccountSasTokenDefinition(string name) : TerraformResource("azurerm_key_vault_managed_storage_account_sas_token_definition", name)
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
    /// The managed_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedStorageAccountId is required")]
    public required TerraformValue<string> ManagedStorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("managed_storage_account_id");
        set => SetArgument("managed_storage_account_id", value);
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
    /// The sas_template_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasTemplateUri is required")]
    public required TerraformValue<string> SasTemplateUri
    {
        get => GetArgument<TerraformValue<string>>("sas_template_uri");
        set => SetArgument("sas_template_uri", value);
    }

    /// <summary>
    /// The sas_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasType is required")]
    public required TerraformValue<string> SasType
    {
        get => GetArgument<TerraformValue<string>>("sas_type");
        set => SetArgument("sas_type", value);
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
    /// The validity_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidityPeriod is required")]
    public required TerraformValue<string> ValidityPeriod
    {
        get => GetArgument<TerraformValue<string>>("validity_period");
        set => SetArgument("validity_period", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformValue<string> SecretId
        => AsReference("secret_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
