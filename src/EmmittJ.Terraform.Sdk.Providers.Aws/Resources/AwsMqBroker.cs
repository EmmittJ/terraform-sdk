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
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("authentication_strategy");
        set => this.WithProperty("authentication_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    public TerraformProperty<string>? BrokerName
    {
        get => GetProperty<TerraformProperty<string>>("broker_name");
        set => this.WithProperty("broker_name", value);
    }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DataReplicationMode
    {
        get => GetProperty<TerraformProperty<string>>("data_replication_mode");
        set => this.WithProperty("data_replication_mode", value);
    }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DataReplicationPrimaryBrokerArn
    {
        get => GetProperty<TerraformProperty<string>>("data_replication_primary_broker_arn");
        set => this.WithProperty("data_replication_primary_broker_arn", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentMode
    {
        get => GetProperty<TerraformProperty<string>>("deployment_mode");
        set => this.WithProperty("deployment_mode", value);
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformProperty<string>? EngineType
    {
        get => GetProperty<TerraformProperty<string>>("engine_type");
        set => this.WithProperty("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? HostInstanceType
    {
        get => GetProperty<TerraformProperty<string>>("host_instance_type");
        set => this.WithProperty("host_instance_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
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
