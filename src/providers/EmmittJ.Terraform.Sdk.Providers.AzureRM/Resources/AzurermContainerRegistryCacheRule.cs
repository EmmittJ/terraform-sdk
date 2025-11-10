using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCacheRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_registry_cache_rule resource.
/// </summary>
public class AzurermContainerRegistryCacheRule : TerraformResource
{
    public AzurermContainerRegistryCacheRule(string name) : base("azurerm_container_registry_cache_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("container_registry_id");
        SetOutput("credential_set_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("source_repo");
        SetOutput("target_repo");
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
    /// The ARM resource ID of the credential store which is associated with the cache rule.
    /// </summary>
    public TerraformProperty<string> CredentialSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credential_set_id");
        set => SetProperty("credential_set_id", value);
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
    /// The name of the cache rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The full source repository path such as &#39;docker.io/library/ubuntu&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRepo is required")]
    public required TerraformProperty<string> SourceRepo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_repo");
        set => SetProperty("source_repo", value);
    }

    /// <summary>
    /// The target repository namespace such as &#39;ubuntu&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepo is required")]
    public required TerraformProperty<string> TargetRepo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_repo");
        set => SetProperty("target_repo", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryCacheRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
