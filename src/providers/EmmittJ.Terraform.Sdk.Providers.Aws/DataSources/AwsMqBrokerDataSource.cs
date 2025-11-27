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
    public TerraformValue<string> BrokerId
    {
        get => new TerraformReference<string>(this, "broker_id");
        set => SetArgument("broker_id", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    public TerraformValue<string> BrokerName
    {
        get => new TerraformReference<string>(this, "broker_name");
        set => SetArgument("broker_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationStrategy
    {
        get => new TerraformReference<string>(this, "authentication_strategy");
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configuration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformValue<string> DeploymentMode
    {
        get => new TerraformReference<string>(this, "deployment_mode");
    }

    /// <summary>
    /// The encryption_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformValue<string> EngineType
    {
        get => new TerraformReference<string>(this, "engine_type");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public TerraformValue<string> HostInstanceType
    {
        get => new TerraformReference<string>(this, "host_instance_type");
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Instances
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instances").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ldap_server_metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LdapServerMetadata
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ldap_server_metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The maintenance_window_start_time attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindowStartTime
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_window_start_time").ResolveNodes(ctx));
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> User
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "user").ResolveNodes(ctx));
    }

}
