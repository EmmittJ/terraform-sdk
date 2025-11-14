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
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudDevToolPortalSsoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sso";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformArgument("client_id")]
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformArgument("client_secret")]
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The metadata_url attribute.
    /// </summary>
    [TerraformArgument("metadata_url")]
    public TerraformValue<string>? MetadataUrl
    {
        get => new TerraformReference<string>(this, "metadata_url");
        set => SetArgument("metadata_url", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformArgument("scope")]
    public TerraformSet<string>? Scope
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scope").ResolveNodes(ctx));
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudDevToolPortalTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_dev_tool_portal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudDevToolPortal : TerraformResource
{
    public AzurermSpringCloudDevToolPortal(string name) : base("azurerm_spring_cloud_dev_tool_portal", name)
    {
    }

    /// <summary>
    /// The application_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("application_accelerator_enabled")]
    public TerraformValue<bool> ApplicationAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "application_accelerator_enabled");
        set => SetArgument("application_accelerator_enabled", value);
    }

    /// <summary>
    /// The application_live_view_enabled attribute.
    /// </summary>
    [TerraformArgument("application_live_view_enabled")]
    public TerraformValue<bool> ApplicationLiveViewEnabled
    {
        get => new TerraformReference<bool>(this, "application_live_view_enabled");
        set => SetArgument("application_live_view_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformArgument("spring_cloud_service_id")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => new TerraformReference<string>(this, "spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    [TerraformArgument("sso")]
    public TerraformList<AzurermSpringCloudDevToolPortalSsoBlock> Sso { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudDevToolPortalTimeoutsBlock Timeouts { get; set; } = new();

}
