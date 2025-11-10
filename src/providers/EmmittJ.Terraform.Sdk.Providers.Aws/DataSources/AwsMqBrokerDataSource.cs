using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker.
/// </summary>
public class AwsMqBrokerDataSource : TerraformDataSource
{
    public AwsMqBrokerDataSource(string name) : base("aws_mq_broker", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("authentication_strategy");
        this.WithOutput("auto_minor_version_upgrade");
        this.WithOutput("configuration");
        this.WithOutput("deployment_mode");
        this.WithOutput("encryption_options");
        this.WithOutput("engine_type");
        this.WithOutput("engine_version");
        this.WithOutput("host_instance_type");
        this.WithOutput("instances");
        this.WithOutput("ldap_server_metadata");
        this.WithOutput("logs");
        this.WithOutput("maintenance_window_start_time");
        this.WithOutput("publicly_accessible");
        this.WithOutput("security_groups");
        this.WithOutput("storage_type");
        this.WithOutput("subnet_ids");
        this.WithOutput("user");
    }

    /// <summary>
    /// The broker_id attribute.
    /// </summary>
    public TerraformProperty<string>? BrokerId
    {
        get => GetProperty<TerraformProperty<string>>("broker_id");
        set => this.WithProperty("broker_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformExpression AuthenticationStrategy => this["authentication_strategy"];

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformExpression AutoMinorVersionUpgrade => this["auto_minor_version_upgrade"];

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformExpression Configuration => this["configuration"];

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformExpression DeploymentMode => this["deployment_mode"];

    /// <summary>
    /// The encryption_options attribute.
    /// </summary>
    public TerraformExpression EncryptionOptions => this["encryption_options"];

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformExpression EngineType => this["engine_type"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public TerraformExpression HostInstanceType => this["host_instance_type"];

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

    /// <summary>
    /// The ldap_server_metadata attribute.
    /// </summary>
    public TerraformExpression LdapServerMetadata => this["ldap_server_metadata"];

    /// <summary>
    /// The logs attribute.
    /// </summary>
    public TerraformExpression Logs => this["logs"];

    /// <summary>
    /// The maintenance_window_start_time attribute.
    /// </summary>
    public TerraformExpression MaintenanceWindowStartTime => this["maintenance_window_start_time"];

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformExpression PubliclyAccessible => this["publicly_accessible"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformExpression User => this["user"];

}
