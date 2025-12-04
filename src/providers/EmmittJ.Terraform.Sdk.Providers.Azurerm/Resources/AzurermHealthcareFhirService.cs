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
        get => GetRequiredArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformValue<string> Authority
    {
        get => GetRequiredArgument<TerraformValue<string>>("authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SmartProxyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smart_proxy_enabled");
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
        get => GetRequiredArgument<TerraformSet<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public required TerraformSet<string> AllowedMethods
    {
        get => GetRequiredArgument<TerraformSet<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => GetRequiredArgument<TerraformSet<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? CredentialsAllowed
    {
        get => GetArgument<TerraformValue<bool>>("credentials_allowed");
        set => SetArgument("credentials_allowed", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_age_in_seconds");
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformValue<string>? ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    public required TerraformValue<string> LoginServer
    {
        get => GetRequiredArgument<TerraformValue<string>>("login_server");
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
        get => GetArgument<TerraformSet<string>>("access_policy_object_ids");
        set => SetArgument("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationExportStorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("configuration_export_storage_account_name");
        set => SetArgument("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    public TerraformSet<string>? ContainerRegistryLoginServerUrl
    {
        get => GetArgument<TerraformSet<string>>("container_registry_login_server_url");
        set => SetArgument("container_registry_login_server_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

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
