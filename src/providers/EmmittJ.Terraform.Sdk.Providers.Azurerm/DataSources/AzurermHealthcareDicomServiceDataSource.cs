using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermHealthcareDicomServiceDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The cors attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Cors
        => AsReference("cors");

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataPartitionsEnabled
        => AsReference("data_partitions_enabled");

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeyUrl
        => AsReference("encryption_key_url");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateEndpoint
        => AsReference("private_endpoint");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceUrl
        => AsReference("service_url");

    /// <summary>
    /// The storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Storage
        => AsReference("storage");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareDicomServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareDicomServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
