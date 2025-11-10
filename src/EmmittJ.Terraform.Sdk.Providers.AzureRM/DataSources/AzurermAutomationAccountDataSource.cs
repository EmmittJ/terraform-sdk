using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationAccountDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_automation_account.
/// </summary>
public class AzurermAutomationAccountDataSource : TerraformDataSource
{
    public AzurermAutomationAccountDataSource(string name) : base("azurerm_automation_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("hybrid_service_url");
        this.DeclareOutput("identity");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("private_endpoint_connection");
        this.DeclareOutput("secondary_key");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationAccountDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The hybrid_service_url attribute.
    /// </summary>
    public TerraformExpression HybridServiceUrl => this["hybrid_service_url"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnection => this["private_endpoint_connection"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
