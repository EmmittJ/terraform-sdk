using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_replication_config resource.
/// </summary>
public class AwsDmsReplicationConfig : TerraformResource
{
    public AwsDmsReplicationConfig(string name) : base("aws_dms_replication_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The replication_config_identifier attribute.
    /// </summary>
    public string? ReplicationConfigIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_config_identifier")?.Value;
        set => this.WithProperty("replication_config_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    public string? ReplicationSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_settings")?.Value;
        set => this.WithProperty("replication_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    public string? ReplicationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_type")?.Value;
        set => this.WithProperty("replication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public string? ResourceIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_identifier")?.Value;
        set => this.WithProperty("resource_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public string? SourceEndpointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_endpoint_arn")?.Value;
        set => this.WithProperty("source_endpoint_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    public bool? StartReplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_replication")?.Value;
        set => this.WithProperty("start_replication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    public string? SupplementalSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("supplemental_settings")?.Value;
        set => this.WithProperty("supplemental_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public string? TableMappings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_mappings")?.Value;
        set => this.WithProperty("table_mappings", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public string? TargetEndpointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_endpoint_arn")?.Value;
        set => this.WithProperty("target_endpoint_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
