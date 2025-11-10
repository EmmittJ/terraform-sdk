using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    public required TerraformProperty<string> Audience
    {
        get => GetRequiredProperty<TerraformProperty<string>>("audience");
        set => WithProperty("audience", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformProperty<string> Authority
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authority");
        set => WithProperty("authority", value);
    }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmartProxyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smart_proxy_enabled");
        set => WithProperty("smart_proxy_enabled", value);
    }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceCorsBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public HashSet<TerraformProperty<string>>? AllowedHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_headers");
        set => WithProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public HashSet<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public HashSet<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? CredentialsAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("credentials_allowed");
        set => WithProperty("credentials_allowed", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_age_in_seconds");
        set => WithProperty("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for oci_artifact in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceOciArtifactBlock : TerraformBlock
{
    /// <summary>
    /// The digest attribute.
    /// </summary>
    public TerraformProperty<string>? Digest
    {
        get => GetProperty<TerraformProperty<string>>("digest");
        set => WithProperty("digest", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => WithProperty("image_name", value);
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    public required TerraformProperty<string> LoginServer
    {
        get => GetRequiredProperty<TerraformProperty<string>>("login_server");
        set => WithProperty("login_server", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareFhirServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_healthcare_fhir_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHealthcareFhirService : TerraformResource
{
    public AzurermHealthcareFhirService(string name) : base("azurerm_healthcare_fhir_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("public_network_access_enabled");
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AccessPolicyObjectIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("access_policy_object_ids");
        set => this.WithProperty("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationExportStorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_export_storage_account_name");
        set => this.WithProperty("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ContainerRegistryLoginServerUrl
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("container_registry_login_server_url");
        set => this.WithProperty("container_registry_login_server_url", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public List<AzurermHealthcareFhirServiceAuthenticationBlock>? Authentication
    {
        get => GetProperty<List<AzurermHealthcareFhirServiceAuthenticationBlock>>("authentication");
        set => this.WithProperty("authentication", value);
    }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public List<AzurermHealthcareFhirServiceCorsBlock>? Cors
    {
        get => GetProperty<List<AzurermHealthcareFhirServiceCorsBlock>>("cors");
        set => this.WithProperty("cors", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermHealthcareFhirServiceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermHealthcareFhirServiceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for oci_artifact.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermHealthcareFhirServiceOciArtifactBlock>? OciArtifact
    {
        get => GetProperty<List<AzurermHealthcareFhirServiceOciArtifactBlock>>("oci_artifact");
        set => this.WithProperty("oci_artifact", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHealthcareFhirServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermHealthcareFhirServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

}
