using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("primary_authorization_key");
        this.DeclareOutput("secondary_authorization_key");
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The self_contained_interactive_authoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SelfContainedInteractiveAuthoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("self_contained_interactive_authoring_enabled");
        set => this.WithProperty("self_contained_interactive_authoring_enabled", value);
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
