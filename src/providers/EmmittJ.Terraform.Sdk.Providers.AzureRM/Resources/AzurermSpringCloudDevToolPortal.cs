using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sso in AzurermSpringCloudDevToolPortal.
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
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The metadata_url attribute.
    /// </summary>
    public TerraformValue<string>? MetadataUrl
    {
        get => new TerraformReference<string>(this, "metadata_url");
        set => SetArgument("metadata_url", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformSet<string>? Scope
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scope").ResolveNodes(ctx));
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudDevToolPortal.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_dev_tool_portal Terraform resource.
/// Manages a azurerm_spring_cloud_dev_tool_portal resource.
/// </summary>
public partial class AzurermSpringCloudDevToolPortal(string name) : TerraformResource("azurerm_spring_cloud_dev_tool_portal", name)
{
    /// <summary>
    /// The application_accelerator_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ApplicationAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "application_accelerator_enabled");
        set => SetArgument("application_accelerator_enabled", value);
    }

    /// <summary>
    /// The application_live_view_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ApplicationLiveViewEnabled
    {
        get => new TerraformReference<bool>(this, "application_live_view_enabled");
        set => SetArgument("application_live_view_enabled", value);
    }

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => new TerraformReference<string>(this, "spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Sso block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public TerraformList<AzurermSpringCloudDevToolPortalSsoBlock>? Sso
    {
        get => GetArgument<TerraformList<AzurermSpringCloudDevToolPortalSsoBlock>>("sso");
        set => SetArgument("sso", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudDevToolPortalTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudDevToolPortalTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
