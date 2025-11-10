using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for release_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformProperty<double>? BatchSize
    {
        get => GetProperty<TerraformProperty<double>>("batch_size");
        set => WithProperty("batch_size", value);
    }

    /// <summary>
    /// The message_count attribute.
    /// </summary>
    public TerraformProperty<double>? MessageCount
    {
        get => GetProperty<TerraformProperty<double>>("message_count");
        set => WithProperty("message_count", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_logic_app_integration_account_batch_configuration resource.
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfiguration : TerraformResource
{
    public AzurermLogicAppIntegrationAccountBatchConfiguration(string name) : base("azurerm_logic_app_integration_account_batch_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The batch_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchGroupName is required")]
    public required TerraformProperty<string> BatchGroupName
    {
        get => GetProperty<TerraformProperty<string>>("batch_group_name");
        set => this.WithProperty("batch_group_name", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformProperty<string> IntegrationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for release_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReleaseCriteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseCriteria block(s) allowed")]
    public List<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock>? ReleaseCriteria
    {
        get => GetProperty<List<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock>>("release_criteria");
        set => this.WithProperty("release_criteria", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
