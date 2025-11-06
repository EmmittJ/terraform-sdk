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
    public string? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_id")?.Value;
        set => this.WithProperty("container_app_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    public double? MaxInactiveRevisions
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_inactive_revisions")?.Value;
        set => this.WithProperty("max_inactive_revisions", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    public string? RevisionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision_mode")?.Value;
        set => this.WithProperty("revision_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public string? WorkloadProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_profile_name")?.Value;
        set => this.WithProperty("workload_profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
