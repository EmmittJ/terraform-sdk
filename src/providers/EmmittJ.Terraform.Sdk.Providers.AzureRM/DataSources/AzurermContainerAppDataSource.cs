using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_container_app.
/// </summary>
public class AzurermContainerAppDataSource : TerraformDataSource
{
    public AzurermContainerAppDataSource(string name) : base("azurerm_container_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("container_app_environment_id");
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("dapr");
        this.DeclareOutput("identity");
        this.DeclareOutput("ingress");
        this.DeclareOutput("latest_revision_fqdn");
        this.DeclareOutput("latest_revision_name");
        this.DeclareOutput("location");
        this.DeclareOutput("max_inactive_revisions");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("registry");
        this.DeclareOutput("revision_mode");
        this.DeclareOutput("secret");
        this.DeclareOutput("tags");
        this.DeclareOutput("template");
        this.DeclareOutput("workload_profile_name");
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
    public AzurermContainerAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    public TerraformExpression ContainerAppEnvironmentId => this["container_app_environment_id"];

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    public TerraformExpression Dapr => this["dapr"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    public TerraformExpression Ingress => this["ingress"];

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
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
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformExpression MaxInactiveRevisions => this["max_inactive_revisions"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The registry attribute.
    /// </summary>
    public TerraformExpression Registry => this["registry"];

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    public TerraformExpression RevisionMode => this["revision_mode"];

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The template attribute.
    /// </summary>
    public TerraformExpression Template => this["template"];

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformExpression WorkloadProfileName => this["workload_profile_name"];

}
