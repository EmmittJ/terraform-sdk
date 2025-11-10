using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_storage_account_sas_token_definition resource.
/// </summary>
public class AzurermKeyVaultManagedStorageAccountSasTokenDefinition : TerraformResource
{
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinition(string name) : base("azurerm_key_vault_managed_storage_account_sas_token_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("secret_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The managed_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedStorageAccountId is required")]
    public required TerraformProperty<string> ManagedStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("managed_storage_account_id");
        set => this.WithProperty("managed_storage_account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sas_template_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasTemplateUri is required")]
    public required TerraformProperty<string> SasTemplateUri
    {
        get => GetProperty<TerraformProperty<string>>("sas_template_uri");
        set => this.WithProperty("sas_template_uri", value);
    }

    /// <summary>
    /// The sas_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasType is required")]
    public required TerraformProperty<string> SasType
    {
        get => GetProperty<TerraformProperty<string>>("sas_type");
        set => this.WithProperty("sas_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The validity_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidityPeriod is required")]
    public required TerraformProperty<string> ValidityPeriod
    {
        get => GetProperty<TerraformProperty<string>>("validity_period");
        set => this.WithProperty("validity_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformExpression SecretId => this["secret_id"];

}
