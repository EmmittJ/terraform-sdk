using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_mq_broker resource.
/// </summary>
public class AwsMqBroker : TerraformResource
{
    public AwsMqBroker(string name) : base("aws_mq_broker", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("instances");
        this.DeclareOutput("pending_data_replication_mode");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public string? AuthenticationStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_strategy")?.Value;
        set => this.WithProperty("authentication_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public bool? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    public string? BrokerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("broker_name")?.Value;
        set => this.WithProperty("broker_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    public string? DataReplicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_replication_mode")?.Value;
        set => this.WithProperty("data_replication_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    public string? DataReplicationPrimaryBrokerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_replication_primary_broker_arn")?.Value;
        set => this.WithProperty("data_replication_primary_broker_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public string? DeploymentMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_mode")?.Value;
        set => this.WithProperty("deployment_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public string? EngineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_type")?.Value;
        set => this.WithProperty("engine_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public string? HostInstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_instance_type")?.Value;
        set => this.WithProperty("host_instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

    /// <summary>
    /// The pending_data_replication_mode attribute.
    /// </summary>
    public TerraformExpression PendingDataReplicationMode => this["pending_data_replication_mode"];

}
