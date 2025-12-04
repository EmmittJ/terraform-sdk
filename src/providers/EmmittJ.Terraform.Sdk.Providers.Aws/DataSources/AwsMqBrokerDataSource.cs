using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_mq_broker Terraform data source.
/// Retrieves information about a aws_mq_broker.
/// </summary>
public partial class AwsMqBrokerDataSource(string name) : TerraformDataSource("aws_mq_broker", name)
{
    /// <summary>
    /// The broker_id attribute.
    /// </summary>
    public TerraformValue<string>? BrokerId
    {
        get => GetArgument<TerraformValue<string>>("broker_id");
        set => SetArgument("broker_id", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    public TerraformValue<string>? BrokerName
    {
        get => GetArgument<TerraformValue<string>>("broker_name");
        set => SetArgument("broker_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationStrategy
        => AsReference("authentication_strategy");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
        => AsReference("auto_minor_version_upgrade");

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configuration
        => AsReference("configuration");

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformValue<string> DeploymentMode
        => AsReference("deployment_mode");

    /// <summary>
    /// The encryption_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionOptions
        => AsReference("encryption_options");

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformValue<string> EngineType
        => AsReference("engine_type");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public TerraformValue<string> HostInstanceType
        => AsReference("host_instance_type");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Instances
        => AsReference("instances");

    /// <summary>
    /// The ldap_server_metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LdapServerMetadata
        => AsReference("ldap_server_metadata");

    /// <summary>
    /// The logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logs
        => AsReference("logs");

    /// <summary>
    /// The maintenance_window_start_time attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindowStartTime
        => AsReference("maintenance_window_start_time");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
        => AsReference("publicly_accessible");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => AsReference("security_groups");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
        => AsReference("storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
        => AsReference("subnet_ids");

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> User
        => AsReference("user");

}
