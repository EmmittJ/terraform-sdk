using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stack_hci_cluster resource.
/// </summary>
public class AzurermStackHciCluster : TerraformResource
{
    public AzurermStackHciCluster(string name) : base("azurerm_stack_hci_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cloud_id");
        this.DeclareOutput("resource_provider_object_id");
        this.DeclareOutput("service_endpoint");
    }

    /// <summary>
    /// The automanage_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? AutomanageConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("automanage_configuration_id");
        set => this.WithProperty("automanage_configuration_id", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The cloud_id attribute.
    /// </summary>
    public TerraformExpression CloudId => this["cloud_id"];

    /// <summary>
    /// The resource_provider_object_id attribute.
    /// </summary>
    public TerraformExpression ResourceProviderObjectId => this["resource_provider_object_id"];

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public TerraformExpression ServiceEndpoint => this["service_endpoint"];

}
