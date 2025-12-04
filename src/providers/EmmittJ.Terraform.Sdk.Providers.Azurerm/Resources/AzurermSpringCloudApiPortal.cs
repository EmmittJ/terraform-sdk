using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sso in AzurermSpringCloudApiPortal.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudApiPortalSsoBlock : TerraformBlock
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
    /// The issuer_uri attribute.
    /// </summary>
    public TerraformValue<string>? IssuerUri
    {
        get => GetArgument<TerraformValue<string>>("issuer_uri");
        set => SetArgument("issuer_uri", value);
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
/// Block type for timeouts in AzurermSpringCloudApiPortal.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudApiPortalTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_api_portal Terraform resource.
/// Manages a azurerm_spring_cloud_api_portal resource.
/// </summary>
public partial class AzurermSpringCloudApiPortal(string name) : TerraformResource("azurerm_spring_cloud_api_portal", name)
{
    /// <summary>
    /// The api_try_out_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ApiTryOutEnabled
    {
        get => GetArgument<TerraformValue<bool>>("api_try_out_enabled");
        set => SetArgument("api_try_out_enabled", value);
    }

    /// <summary>
    /// The gateway_ids attribute.
    /// </summary>
    public TerraformSet<string>? GatewayIds
    {
        get => GetArgument<TerraformSet<string>>("gateway_ids");
        set => SetArgument("gateway_ids", value);
    }

    /// <summary>
    /// The https_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnlyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("https_only_enabled");
        set => SetArgument("https_only_enabled", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
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
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// Sso block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public TerraformList<AzurermSpringCloudApiPortalSsoBlock>? Sso
    {
        get => GetArgument<TerraformList<AzurermSpringCloudApiPortalSsoBlock>>("sso");
        set => SetArgument("sso", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudApiPortalTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudApiPortalTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
