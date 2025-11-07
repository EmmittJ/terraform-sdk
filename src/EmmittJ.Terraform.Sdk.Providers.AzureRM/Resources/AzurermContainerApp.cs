using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_app resource.
/// </summary>
public class AzurermContainerApp : TerraformResource
{
    public AzurermContainerApp(string name) : base("azurerm_container_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("latest_revision_fqdn");
        this.DeclareOutput("latest_revision_name");
        this.DeclareOutput("location");
        this.DeclareOutput("outbound_ip_addresses");
    }

    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    public TerraformProperty<string>? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
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
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformProperty<double>? MaxInactiveRevisions
    {
        get => GetProperty<TerraformProperty<double>>("max_inactive_revisions");
        set => this.WithProperty("max_inactive_revisions", value);
    }

    /// <summary>
    /// The name for this Container App.
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
    /// The revision_mode attribute.
    /// </summary>
    public TerraformProperty<string>? RevisionMode
    {
        get => GetProperty<TerraformProperty<string>>("revision_mode");
        set => this.WithProperty("revision_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadProfileName
    {
        get => GetProperty<TerraformProperty<string>>("workload_profile_name");
        set => this.WithProperty("workload_profile_name", value);
    }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    public TerraformExpression LatestRevisionFqdn => this["latest_revision_fqdn"];

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    public TerraformExpression LatestRevisionName => this["latest_revision_name"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

}
