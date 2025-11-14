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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_dicom_service.
/// </summary>
public class AzurermHealthcareDicomServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareDicomServiceDataSource(string name) : base("azurerm_healthcare_dicom_service", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHealthcareDicomServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformArgument("authentication")]
    public TerraformList<object> Authentication
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformArgument("cors")]
    public TerraformList<object> Cors
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "cors").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    [TerraformArgument("data_partitions_enabled")]
    public TerraformValue<bool> DataPartitionsEnabled
    {
        get => new TerraformReference<bool>(this, "data_partitions_enabled");
    }

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    [TerraformArgument("encryption_key_url")]
    public TerraformValue<string> EncryptionKeyUrl
    {
        get => new TerraformReference<string>(this, "encryption_key_url");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformArgument("private_endpoint")]
    public TerraformList<object> PrivateEndpoint
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "private_endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformArgument("service_url")]
    public TerraformValue<string> ServiceUrl
    {
        get => new TerraformReference<string>(this, "service_url");
    }

    /// <summary>
    /// The storage attribute.
    /// </summary>
    [TerraformArgument("storage")]
    public TerraformList<object> Storage
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
