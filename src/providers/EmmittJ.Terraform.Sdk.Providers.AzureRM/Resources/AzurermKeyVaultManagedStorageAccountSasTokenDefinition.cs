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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("secret_id");
        SetOutput("id");
        SetOutput("managed_storage_account_id");
        SetOutput("name");
        SetOutput("sas_template_uri");
        SetOutput("sas_type");
        SetOutput("tags");
        SetOutput("validity_period");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The managed_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedStorageAccountId is required")]
    public required TerraformProperty<string> ManagedStorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_storage_account_id");
        set => SetProperty("managed_storage_account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The sas_template_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasTemplateUri is required")]
    public required TerraformProperty<string> SasTemplateUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sas_template_uri");
        set => SetProperty("sas_template_uri", value);
    }

    /// <summary>
    /// The sas_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasType is required")]
    public required TerraformProperty<string> SasType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sas_type");
        set => SetProperty("sas_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The validity_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidityPeriod is required")]
    public required TerraformProperty<string> ValidityPeriod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("validity_period");
        set => SetProperty("validity_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformExpression SecretId => this["secret_id"];

}
