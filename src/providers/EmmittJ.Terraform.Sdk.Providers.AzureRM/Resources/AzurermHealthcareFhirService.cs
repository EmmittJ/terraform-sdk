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
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    [TerraformArgument("audience")]
    public required TerraformValue<string> Audience
    {
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    [TerraformArgument("authority")]
    public required TerraformValue<string> Authority
    {
        get => new TerraformReference<string>(this, "authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    [TerraformArgument("smart_proxy_enabled")]
    public TerraformValue<bool>? SmartProxyEnabled
    {
        get => new TerraformReference<bool>(this, "smart_proxy_enabled");
        set => SetArgument("smart_proxy_enabled", value);
    }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformArgument("allowed_headers")]
    public required TerraformSet<string> AllowedHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformArgument("allowed_methods")]
    public required TerraformSet<string> AllowedMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformArgument("allowed_origins")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    [TerraformArgument("credentials_allowed")]
    public TerraformValue<bool>? CredentialsAllowed
    {
        get => new TerraformReference<bool>(this, "credentials_allowed");
        set => SetArgument("credentials_allowed", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [TerraformArgument("max_age_in_seconds")]
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => new TerraformReference<double>(this, "max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for oci_artifact in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareFhirServiceOciArtifactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oci_artifact";

    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformArgument("digest")]
    public TerraformValue<string>? Digest
    {
        get => new TerraformReference<string>(this, "digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [TerraformArgument("image_name")]
    public TerraformValue<string>? ImageName
    {
        get => new TerraformReference<string>(this, "image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    [TerraformArgument("login_server")]
    public required TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
        set => SetArgument("login_server", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareFhirServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_healthcare_fhir_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHealthcareFhirService : TerraformResource
{
    public AzurermHealthcareFhirService(string name) : base("azurerm_healthcare_fhir_service", name)
    {
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformArgument("access_policy_object_ids")]
    public TerraformSet<string>? AccessPolicyObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "access_policy_object_ids").ResolveNodes(ctx));
        set => SetArgument("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    [TerraformArgument("configuration_export_storage_account_name")]
    public TerraformValue<string>? ConfigurationExportStorageAccountName
    {
        get => new TerraformReference<string>(this, "configuration_export_storage_account_name");
        set => SetArgument("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    [TerraformArgument("container_registry_login_server_url")]
    public TerraformSet<string>? ContainerRegistryLoginServerUrl
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "container_registry_login_server_url").ResolveNodes(ctx));
        set => SetArgument("container_registry_login_server_url", value);
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
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformArgument("workspace_id")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformArgument("authentication")]
    public required TerraformList<AzurermHealthcareFhirServiceAuthenticationBlock> Authentication { get; set; } = new();

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformArgument("cors")]
    public TerraformList<AzurermHealthcareFhirServiceCorsBlock> Cors { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermHealthcareFhirServiceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for oci_artifact.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("oci_artifact")]
    public TerraformList<AzurermHealthcareFhirServiceOciArtifactBlock> OciArtifact { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHealthcareFhirServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

}
