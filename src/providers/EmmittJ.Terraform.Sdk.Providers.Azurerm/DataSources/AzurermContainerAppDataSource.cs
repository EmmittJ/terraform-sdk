using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerAppDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_container_app Terraform data source.
/// Retrieves information about a azurerm_container_app.
/// </summary>
public partial class AzurermContainerAppDataSource(string name) : TerraformDataSource("azurerm_container_app", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    public TerraformValue<string> ContainerAppEnvironmentId
        => CreateReference("container_app_environment_id");

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => CreateReference("custom_domain_verification_id");

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Dapr
        => CreateReference("dapr");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ingress
        => CreateReference("ingress");

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
    /// </summary>
    public TerraformValue<string> LatestRevisionFqdn
        => CreateReference("latest_revision_fqdn");

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    public TerraformValue<string> LatestRevisionName
        => CreateReference("latest_revision_name");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformValue<double> MaxInactiveRevisions
        => CreateReference("max_inactive_revisions");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddresses
        => CreateReference("outbound_ip_addresses");

    /// <summary>
    /// The registry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Registry
        => CreateReference("registry");

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    public TerraformValue<string> RevisionMode
        => CreateReference("revision_mode");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Secret
        => CreateReference("secret");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Template
        => CreateReference("template");

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformValue<string> WorkloadProfileName
        => CreateReference("workload_profile_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
