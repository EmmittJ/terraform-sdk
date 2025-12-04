using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cors in AzurermHealthcareDicomService.
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareDicomServiceCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
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
/// Block type for identity in AzurermHealthcareDicomService.
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareDicomServiceIdentityBlock : TerraformBlock
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
/// Block type for storage in AzurermHealthcareDicomService.
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareDicomServiceStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemName is required")]
    public required TerraformValue<string> FileSystemName
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_name");
        set => SetArgument("file_system_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermHealthcareDicomService.
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareDicomServiceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_healthcare_dicom_service Terraform resource.
/// Manages a azurerm_healthcare_dicom_service resource.
/// </summary>
public partial class AzurermHealthcareDicomService(string name) : TerraformResource("azurerm_healthcare_dicom_service", name)
{
    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataPartitionsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_partitions_enabled");
        set => SetArgument("data_partitions_enabled", value);
    }

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionKeyUrl
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_url");
        set => SetArgument("encryption_key_url", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Authentication
        => AsReference("authentication");

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PrivateEndpoint
        => AsReference("private_endpoint");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceUrl
        => AsReference("service_url");

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermHealthcareDicomServiceCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermHealthcareDicomServiceCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermHealthcareDicomServiceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermHealthcareDicomServiceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public TerraformList<AzurermHealthcareDicomServiceStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<AzurermHealthcareDicomServiceStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareDicomServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareDicomServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
