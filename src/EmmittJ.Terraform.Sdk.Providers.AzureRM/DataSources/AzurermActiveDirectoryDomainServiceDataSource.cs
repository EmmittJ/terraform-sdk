using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_active_directory_domain_service.
/// </summary>
public class AzurermActiveDirectoryDomainServiceDataSource : TerraformDataSource
{
    public AzurermActiveDirectoryDomainServiceDataSource(string name) : base("azurerm_active_directory_domain_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("deployment_id");
        this.DeclareOutput("domain_configuration_type");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("filtered_sync_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("notifications");
        this.DeclareOutput("replica_sets");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("secure_ldap");
        this.DeclareOutput("security");
        this.DeclareOutput("sku");
        this.DeclareOutput("sync_owner");
        this.DeclareOutput("tenant_id");
        this.DeclareOutput("version");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformExpression DeploymentId => this["deployment_id"];

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    public TerraformExpression DomainConfigurationType => this["domain_configuration_type"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    public TerraformExpression FilteredSyncEnabled => this["filtered_sync_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    public TerraformExpression Notifications => this["notifications"];

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    public TerraformExpression ReplicaSets => this["replica_sets"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    public TerraformExpression SecureLdap => this["secure_ldap"];

    /// <summary>
    /// The security attribute.
    /// </summary>
    public TerraformExpression Security => this["security"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    public TerraformExpression SyncOwner => this["sync_owner"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
