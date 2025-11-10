using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rbac_authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        set => SetProperty("resource_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_integration_runtime_self_hosted resource.
/// </summary>
public class AzurermDataFactoryIntegrationRuntimeSelfHosted : TerraformResource
{
    public AzurermDataFactoryIntegrationRuntimeSelfHosted(string name) : base("azurerm_data_factory_integration_runtime_self_hosted", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("primary_authorization_key");
        SetOutput("secondary_authorization_key");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("self_contained_interactive_authoring_enabled");
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The self_contained_interactive_authoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SelfContainedInteractiveAuthoringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("self_contained_interactive_authoring_enabled");
        set => SetProperty("self_contained_interactive_authoring_enabled", value);
    }

    /// <summary>
    /// Block for rbac_authorization.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermDataFactoryIntegrationRuntimeSelfHostedRbacAuthorizationBlock>? RbacAuthorization
    {
        set => SetProperty("rbac_authorization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryIntegrationRuntimeSelfHostedTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The primary_authorization_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAuthorizationKey => this["primary_authorization_key"];

    /// <summary>
    /// The secondary_authorization_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAuthorizationKey => this["secondary_authorization_key"];

}
