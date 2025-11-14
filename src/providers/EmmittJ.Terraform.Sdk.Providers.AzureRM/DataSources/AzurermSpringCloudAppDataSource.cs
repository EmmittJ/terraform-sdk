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
public class AzurermSpringCloudAppDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_spring_cloud_app.
/// </summary>
public class AzurermSpringCloudAppDataSource : TerraformDataSource
{
    public AzurermSpringCloudAppDataSource(string name) : base("azurerm_spring_cloud_app", name)
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformArgument("service_name")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudAppDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool> HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
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
    /// The is_public attribute.
    /// </summary>
    [TerraformArgument("is_public")]
    public TerraformValue<bool> IsPublic
    {
        get => new TerraformReference<bool>(this, "is_public");
    }

    /// <summary>
    /// The persistent_disk attribute.
    /// </summary>
    [TerraformArgument("persistent_disk")]
    public TerraformList<object> PersistentDisk
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "persistent_disk").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_enabled")]
    public TerraformValue<bool> TlsEnabled
    {
        get => new TerraformReference<bool>(this, "tls_enabled");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
