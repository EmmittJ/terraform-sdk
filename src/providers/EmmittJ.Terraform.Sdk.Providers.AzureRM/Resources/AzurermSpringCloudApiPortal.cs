using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sso in .
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
    /// The issuer_uri attribute.
    /// </summary>
    public TerraformValue<string>? IssuerUri
    {
        get => new TerraformReference<string>(this, "issuer_uri");
        set => SetArgument("issuer_uri", value);
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
/// Block type for timeouts in .
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
        get => new TerraformReference<bool>(this, "api_try_out_enabled");
        set => SetArgument("api_try_out_enabled", value);
    }

    /// <summary>
    /// The gateway_ids attribute.
    /// </summary>
    public TerraformSet<string>? GatewayIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "gateway_ids").ResolveNodes(ctx));
        set => SetArgument("gateway_ids", value);
    }

    /// <summary>
    /// The https_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "https_only_enabled");
        set => SetArgument("https_only_enabled", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
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
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

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
