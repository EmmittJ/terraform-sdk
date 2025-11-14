using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_container_app.
/// </summary>
public class AzurermContainerAppDataSource : TerraformDataSource
{
    public AzurermContainerAppDataSource(string name) : base("azurerm_container_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [TerraformArgument("container_app_environment_id")]
    public TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
    }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformArgument("custom_domain_verification_id")]
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    [TerraformArgument("dapr")]
    public TerraformList<object> Dapr
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "dapr").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    [TerraformArgument("ingress")]
    public TerraformList<object> Ingress
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ingress").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
    /// </summary>
    [TerraformArgument("latest_revision_fqdn")]
    public TerraformValue<string> LatestRevisionFqdn
    {
        get => new TerraformReference<string>(this, "latest_revision_fqdn");
    }

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformArgument("latest_revision_name")]
    public TerraformValue<string> LatestRevisionName
    {
        get => new TerraformReference<string>(this, "latest_revision_name");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformArgument("max_inactive_revisions")]
    public TerraformValue<double> MaxInactiveRevisions
    {
        get => new TerraformReference<double>(this, "max_inactive_revisions");
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("outbound_ip_addresses")]
    public TerraformList<string> OutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The registry attribute.
    /// </summary>
    [TerraformArgument("registry")]
    public TerraformList<object> Registry
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "registry").ResolveNodes(ctx));
    }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [TerraformArgument("revision_mode")]
    public TerraformValue<string> RevisionMode
    {
        get => new TerraformReference<string>(this, "revision_mode");
    }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformArgument("secret")]
    public TerraformSet<object> Secret
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "secret").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The template attribute.
    /// </summary>
    [TerraformArgument("template")]
    public TerraformList<object> Template
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "template").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformArgument("workload_profile_name")]
    public TerraformValue<string> WorkloadProfileName
    {
        get => new TerraformReference<string>(this, "workload_profile_name");
    }

}
