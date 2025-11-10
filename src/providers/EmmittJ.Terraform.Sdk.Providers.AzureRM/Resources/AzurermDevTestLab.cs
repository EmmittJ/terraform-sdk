using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestLabTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_dev_test_lab resource.
/// </summary>
public class AzurermDevTestLab : TerraformResource
{
    public AzurermDevTestLab(string name) : base("azurerm_dev_test_lab", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("artifacts_storage_account_id");
        SetOutput("default_premium_storage_account_id");
        SetOutput("default_storage_account_id");
        SetOutput("key_vault_id");
        SetOutput("premium_data_disk_storage_account_id");
        SetOutput("unique_identifier");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevTestLabTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    public TerraformExpression ArtifactsStorageAccountId => this["artifacts_storage_account_id"];

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    public TerraformExpression DefaultPremiumStorageAccountId => this["default_premium_storage_account_id"];

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    public TerraformExpression DefaultStorageAccountId => this["default_storage_account_id"];

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformExpression KeyVaultId => this["key_vault_id"];

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    public TerraformExpression PremiumDataDiskStorageAccountId => this["premium_data_disk_storage_account_id"];

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformExpression UniqueIdentifier => this["unique_identifier"];

}
