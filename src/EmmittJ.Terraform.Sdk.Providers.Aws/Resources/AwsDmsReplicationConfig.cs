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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_config_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicationConfigIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_config_identifier");
        set => this.WithProperty("replication_config_identifier", value);
    }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicationSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_settings");
        set => this.WithProperty("replication_settings", value);
    }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplicationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replication_type");
        set => this.WithProperty("replication_type", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_identifier");
        set => this.WithProperty("resource_identifier", value);
    }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceEndpointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_endpoint_arn");
        set => this.WithProperty("source_endpoint_arn", value);
    }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StartReplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_replication");
        set => this.WithProperty("start_replication", value);
    }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SupplementalSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("supplemental_settings");
        set => this.WithProperty("supplemental_settings", value);
    }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableMappings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_mappings");
        set => this.WithProperty("table_mappings", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_endpoint_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetEndpointArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_endpoint_arn");
        set => this.WithProperty("target_endpoint_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
