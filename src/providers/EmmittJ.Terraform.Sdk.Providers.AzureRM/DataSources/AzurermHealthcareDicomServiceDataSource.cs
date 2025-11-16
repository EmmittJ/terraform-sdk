using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareDicomServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_healthcare_dicom_service Terraform data source.
/// Retrieves information about a azurerm_healthcare_dicom_service.
/// </summary>
public partial class AzurermHealthcareDicomServiceDataSource(string name) : TerraformDataSource("azurerm_healthcare_dicom_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Authentication
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cors attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Cors
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cors").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataPartitionsEnabled
    {
        get => new TerraformReference<bool>(this, "data_partitions_enabled");
    }

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeyUrl
    {
        get => new TerraformReference<string>(this, "encryption_key_url");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateEndpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceUrl
    {
        get => new TerraformReference<string>(this, "service_url");
    }

    /// <summary>
    /// The storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Storage
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareDicomServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareDicomServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
