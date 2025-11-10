using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_container_registry_cache_rule.
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSource : TerraformDataSource
{
    public AzurermContainerRegistryCacheRuleDataSource(string name) : base("azurerm_container_registry_cache_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("credential_set_id");
        SetOutput("source_repo");
        SetOutput("target_repo");
        SetOutput("container_registry_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformProperty<string> ContainerRegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_registry_id");
        set => SetProperty("container_registry_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The credential_set_id attribute.
    /// </summary>
    public TerraformExpression CredentialSetId => this["credential_set_id"];

    /// <summary>
    /// The source_repo attribute.
    /// </summary>
    public TerraformExpression SourceRepo => this["source_repo"];

    /// <summary>
    /// The target_repo attribute.
    /// </summary>
    public TerraformExpression TargetRepo => this["target_repo"];

}
