using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_snapshot resource.
/// </summary>
public class AzurermSnapshot : TerraformResource
{
    public AzurermSnapshot(string name) : base("azurerm_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("trusted_launch_enabled");
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public string? CreateOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_option")?.Value;
        set => this.WithProperty("create_option", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_access_id attribute.
    /// </summary>
    public string? DiskAccessId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_access_id")?.Value;
        set => this.WithProperty("disk_access_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public double? DiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_gb")?.Value;
        set => this.WithProperty("disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The incremental_enabled attribute.
    /// </summary>
    public bool? IncrementalEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("incremental_enabled")?.Value;
        set => this.WithProperty("incremental_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_access_policy attribute.
    /// </summary>
    public string? NetworkAccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_access_policy")?.Value;
        set => this.WithProperty("network_access_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public string? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id")?.Value;
        set => this.WithProperty("source_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public string? SourceUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_uri")?.Value;
        set => this.WithProperty("source_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformExpression TrustedLaunchEnabled => this["trusted_launch_enabled"];

}
