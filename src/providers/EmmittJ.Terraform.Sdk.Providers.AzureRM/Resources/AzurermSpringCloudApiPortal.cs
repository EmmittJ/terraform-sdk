using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudApiPortalSsoBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer_uri attribute.
    /// </summary>
    public TerraformProperty<string>? IssuerUri
    {
        set => SetProperty("issuer_uri", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Scope
    {
        set => SetProperty("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudApiPortalTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_api_portal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudApiPortal : TerraformResource
{
    public AzurermSpringCloudApiPortal(string name) : base("azurerm_spring_cloud_api_portal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("url");
        SetOutput("api_try_out_enabled");
        SetOutput("gateway_ids");
        SetOutput("https_only_enabled");
        SetOutput("id");
        SetOutput("instance_count");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The api_try_out_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ApiTryOutEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("api_try_out_enabled");
        set => SetProperty("api_try_out_enabled", value);
    }

    /// <summary>
    /// The gateway_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> GatewayIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("gateway_ids");
        set => SetProperty("gateway_ids", value);
    }

    /// <summary>
    /// The https_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HttpsOnlyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_only_enabled");
        set => SetProperty("https_only_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double> InstanceCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_count");
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_service_id");
        set => SetProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public List<AzurermSpringCloudApiPortalSsoBlock>? Sso
    {
        set => SetProperty("sso", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudApiPortalTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
