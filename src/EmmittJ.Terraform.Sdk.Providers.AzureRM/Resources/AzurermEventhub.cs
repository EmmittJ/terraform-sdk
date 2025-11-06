using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventhub resource.
/// </summary>
public class AzurermEventhub : TerraformResource
{
    public AzurermEventhub(string name) : base("azurerm_eventhub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("partition_ids");
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
    /// The message_retention attribute.
    /// </summary>
    public double? MessageRetention
    {
        get => GetProperty<TerraformLiteralProperty<double>>("message_retention")?.Value;
        set => this.WithProperty("message_retention", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The namespace_id attribute.
    /// </summary>
    public string? NamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_id")?.Value;
        set => this.WithProperty("namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    public double? PartitionCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("partition_count")?.Value;
        set => this.WithProperty("partition_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partition_ids attribute.
    /// </summary>
    public TerraformExpression PartitionIds => this["partition_ids"];

}
