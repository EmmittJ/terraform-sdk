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
    public TerraformLiteralProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_strategy");
        set => this.WithProperty("authentication_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BrokerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("broker_name");
        set => this.WithProperty("broker_name", value);
    }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataReplicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_replication_mode");
        set => this.WithProperty("data_replication_mode", value);
    }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataReplicationPrimaryBrokerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_replication_primary_broker_arn");
        set => this.WithProperty("data_replication_primary_broker_arn", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_mode");
        set => this.WithProperty("deployment_mode", value);
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_type");
        set => this.WithProperty("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostInstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_instance_type");
        set => this.WithProperty("host_instance_type", value);
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
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
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
    /// The security_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
