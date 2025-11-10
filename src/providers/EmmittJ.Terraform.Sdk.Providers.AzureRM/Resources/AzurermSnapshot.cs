using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermSnapshotEncryptionSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSnapshotTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_snapshot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSnapshot : TerraformResource
{
    public AzurermSnapshot(string name) : base("azurerm_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("trusted_launch_enabled");
        SetOutput("create_option");
        SetOutput("disk_access_id");
        SetOutput("disk_size_gb");
        SetOutput("id");
        SetOutput("incremental_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_access_policy");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("source_resource_id");
        SetOutput("source_uri");
        SetOutput("storage_account_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateOption is required")]
    public required TerraformProperty<string> CreateOption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_option");
        set => SetProperty("create_option", value);
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public TerraformProperty<string> DiskAccessId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_access_id");
        set => SetProperty("disk_access_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double> DiskSizeGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disk_size_gb");
        set => SetProperty("disk_size_gb", value);
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
    /// The incremental_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IncrementalEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("incremental_enabled");
        set => SetProperty("incremental_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The network_access_policy attribute.
    /// </summary>
    public TerraformProperty<string> NetworkAccessPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_access_policy");
        set => SetProperty("network_access_policy", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_resource_id");
        set => SetProperty("source_resource_id", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformProperty<string> SourceUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_uri");
        set => SetProperty("source_uri", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for encryption_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSettings block(s) allowed")]
    public List<AzurermSnapshotEncryptionSettingsBlock>? EncryptionSettings
    {
        set => SetProperty("encryption_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSnapshotTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformExpression TrustedLaunchEnabled => this["trusted_launch_enabled"];

}
