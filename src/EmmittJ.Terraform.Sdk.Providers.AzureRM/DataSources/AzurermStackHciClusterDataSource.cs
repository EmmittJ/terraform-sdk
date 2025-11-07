using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("automanage_configuration_id");
        this.DeclareOutput("client_id");
        this.DeclareOutput("cloud_id");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("resource_provider_object_id");
        this.DeclareOutput("service_endpoint");
        this.DeclareOutput("tags");
        this.DeclareOutput("tenant_id");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
