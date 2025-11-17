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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    public TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
    }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Dapr
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dapr").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ingress
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ingress").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
    /// </summary>
    public TerraformValue<string> LatestRevisionFqdn
    {
        get => new TerraformReference<string>(this, "latest_revision_fqdn");
    }

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    public TerraformValue<string> LatestRevisionName
    {
        get => new TerraformReference<string>(this, "latest_revision_name");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformValue<double> MaxInactiveRevisions
    {
        get => new TerraformReference<double>(this, "max_inactive_revisions");
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The registry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Registry
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "registry").ResolveNodes(ctx));
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    public TerraformValue<string> RevisionMode
    {
        get => new TerraformReference<string>(this, "revision_mode");
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Secret
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "secret").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Template
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "template").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformValue<string> WorkloadProfileName
    {
        get => new TerraformReference<string>(this, "workload_profile_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
