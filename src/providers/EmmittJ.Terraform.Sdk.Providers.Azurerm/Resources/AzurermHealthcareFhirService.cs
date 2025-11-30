using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authentication in AzurermHealthcareFhirService.
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
    public required TerraformValue<string> Audience
    {
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformValue<string> Authority
    {
        get => new TerraformReference<string>(this, "authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SmartProxyEnabled
    {
        get => new TerraformReference<bool>(this, "smart_proxy_enabled");
        set => SetArgument("smart_proxy_enabled", value);
    }

}


/// <summary>
/// Block type for cors in AzurermHealthcareFhirService.
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
    public required TerraformSet<string> AllowedHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public required TerraformSet<string> AllowedMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? CredentialsAllowed
    {
        get => new TerraformReference<bool>(this, "credentials_allowed");
        set => SetArgument("credentials_allowed", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => new TerraformReference<double>(this, "max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}


/// <summary>
/// Block type for identity in AzurermHealthcareFhirService.
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for oci_artifact in AzurermHealthcareFhirService.
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
    public TerraformValue<string>? Digest
    {
        get => new TerraformReference<string>(this, "digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformValue<string>? ImageName
    {
        get => new TerraformReference<string>(this, "image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    public required TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
        set => SetArgument("login_server", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermHealthcareFhirService.
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
/// Represents a azurerm_healthcare_fhir_service Terraform resource.
/// Manages a azurerm_healthcare_fhir_service resource.
/// </summary>
public partial class AzurermHealthcareFhirService(string name) : TerraformResource("azurerm_healthcare_fhir_service", name)
{
    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public TerraformSet<string>? AccessPolicyObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "access_policy_object_ids").ResolveNodes(ctx));
        set => SetArgument("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationExportStorageAccountName
    {
        get => new TerraformReference<string>(this, "configuration_export_storage_account_name");
        set => SetArgument("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    public TerraformSet<string>? ContainerRegistryLoginServerUrl
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "container_registry_login_server_url").ResolveNodes(ctx));
        set => SetArgument("container_registry_login_server_url", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// Authentication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public required TerraformList<AzurermHealthcareFhirServiceAuthenticationBlock> Authentication
    {
        get => GetRequiredArgument<TerraformList<AzurermHealthcareFhirServiceAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermHealthcareFhirServiceCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermHealthcareFhirServiceCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermHealthcareFhirServiceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermHealthcareFhirServiceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// OciArtifact block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHealthcareFhirServiceOciArtifactBlock>? OciArtifact
    {
        get => GetArgument<TerraformList<AzurermHealthcareFhirServiceOciArtifactBlock>>("oci_artifact");
        set => SetArgument("oci_artifact", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareFhirServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareFhirServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
