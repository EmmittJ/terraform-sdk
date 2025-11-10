using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudDevToolPortalSsoBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

    /// <summary>
    /// The metadata_url attribute.
    /// </summary>
    public TerraformProperty<string>? MetadataUrl
    {
        get => GetProperty<TerraformProperty<string>>("metadata_url");
        set => WithProperty("metadata_url", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Scope
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("scope");
        set => WithProperty("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudDevToolPortalTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplicationAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("application_accelerator_enabled");
        set => this.WithProperty("application_accelerator_enabled", value);
    }

    /// <summary>
    /// The application_live_view_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplicationLiveViewEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("application_live_view_enabled");
        set => this.WithProperty("application_live_view_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    public List<AzurermSpringCloudDevToolPortalSsoBlock>? Sso
    {
        get => GetProperty<List<AzurermSpringCloudDevToolPortalSsoBlock>>("sso");
        set => this.WithProperty("sso", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudDevToolPortalTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudDevToolPortalTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
