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
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The metadata_url attribute.
    /// </summary>
    public TerraformValue<string>? MetadataUrl
    {
        get => GetArgument<TerraformValue<string>>("metadata_url");
        set => SetArgument("metadata_url", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformSet<string>? Scope
    {
        get => GetArgument<TerraformSet<string>>("scope");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformValue<bool>? ApplicationAcceleratorEnabled
    {
        get => GetArgument<TerraformValue<bool>>("application_accelerator_enabled");
        set => SetArgument("application_accelerator_enabled", value);
    }

    /// <summary>
    /// The application_live_view_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ApplicationLiveViewEnabled
    {
        get => GetArgument<TerraformValue<bool>>("application_live_view_enabled");
        set => SetArgument("application_live_view_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_service_id");
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
