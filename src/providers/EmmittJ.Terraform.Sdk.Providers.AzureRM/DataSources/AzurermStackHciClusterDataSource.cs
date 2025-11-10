using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciClusterDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_stack_hci_cluster.
/// </summary>
public class AzurermStackHciClusterDataSource : TerraformDataSource
{
    public AzurermStackHciClusterDataSource(string name) : base("azurerm_stack_hci_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("automanage_configuration_id");
        this.WithOutput("client_id");
        this.WithOutput("cloud_id");
        this.WithOutput("identity");
        this.WithOutput("location");
        this.WithOutput("resource_provider_object_id");
        this.WithOutput("service_endpoint");
        this.WithOutput("tags");
        this.WithOutput("tenant_id");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStackHciClusterDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The automanage_configuration_id attribute.
    /// </summary>
    public TerraformExpression AutomanageConfigurationId => this["automanage_configuration_id"];

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// The cloud_id attribute.
    /// </summary>
    public TerraformExpression CloudId => this["cloud_id"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The resource_provider_object_id attribute.
    /// </summary>
    public TerraformExpression ResourceProviderObjectId => this["resource_provider_object_id"];

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public TerraformExpression ServiceEndpoint => this["service_endpoint"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
