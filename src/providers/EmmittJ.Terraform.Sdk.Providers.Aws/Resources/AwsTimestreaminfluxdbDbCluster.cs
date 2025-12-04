using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in AwsTimestreaminfluxdbDbCluster.
/// Nesting mode: list
/// </summary>
public class AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_delivery_configuration";

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The name of the S3 bucket to deliver logs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsTimestreaminfluxdbDbCluster.
/// Nesting mode: single
/// </summary>
public class AwsTimestreaminfluxdbDbClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_timestreaminfluxdb_db_cluster Terraform resource.
/// Manages a aws_timestreaminfluxdb_db_cluster resource.
/// </summary>
public partial class AwsTimestreaminfluxdbDbCluster(string name) : TerraformResource("aws_timestreaminfluxdb_db_cluster", name)
{
    /// <summary>
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocatedStorage is required")]
    public required TerraformValue<double> AllocatedStorage
    {
        get => GetArgument<TerraformValue<double>>("allocated_storage");
        set => SetArgument("allocated_storage", value);
    }

    /// <summary>
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. 
    /// 					A bucket combines the concept of a database and a retention period (the duration of time 
    /// 					that each data point persists). A bucket belongs to an organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceType is required")]
    public required TerraformValue<string> DbInstanceType
    {
        get => GetArgument<TerraformValue<string>>("db_instance_type");
        set => SetArgument("db_instance_type", value);
    }

    /// <summary>
    /// The ID of the DB parameter group to assign to your DB cluster. 
    /// 					DB parameter groups specify how the database is configured. For example, DB parameter groups 
    /// 					can specify the limit for query concurrency.
    /// </summary>
    public TerraformValue<string>? DbParameterGroupIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_parameter_group_identifier");
        set => SetArgument("db_parameter_group_identifier", value);
    }

    /// <summary>
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data. 
    /// 					You can choose between 3 different types of provisioned Influx IOPS included storage according 
    /// 					to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, 
    /// 					Influx IO Included 16000 IOPS.
    /// </summary>
    public TerraformValue<string>? DbStorageType
    {
        get => GetArgument<TerraformValue<string>>("db_storage_type");
        set => SetArgument("db_storage_type", value);
    }

    /// <summary>
    /// Specifies the type of cluster to create.
    /// </summary>
    public TerraformValue<string>? DeploymentType
    {
        get => GetArgument<TerraformValue<string>>("deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// Specifies the behavior of failure recovery when the primary node of the cluster
    /// 					fails.
    /// </summary>
    public TerraformValue<string>? FailoverMode
    {
        get => GetArgument<TerraformValue<string>>("failover_mode");
        set => SetArgument("failover_mode", value);
    }

    /// <summary>
    /// The name that uniquely identifies the DB cluster when interacting with the 
    /// 					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a 
    /// 					prefix included in the endpoint. DB cluster names must be unique per customer 
    /// 					and per region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB cluster is 
    /// 					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate 
    /// 					over both IPv4 and IPv6 protocols.
    /// </summary>
    public TerraformValue<string>? NetworkType
    {
        get => GetArgument<TerraformValue<string>>("network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The name of the initial organization for the initial admin user in InfluxDB. An 
    /// 					InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The password of the initial admin user created in InfluxDB. This password will 
    /// 					allow you to access the InfluxDB UI to perform various administrative tasks and 
    /// 					also use the InfluxDB CLI to create an operator token. These attributes will be 
    /// 					stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
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
    /// The username of the initial admin user created in InfluxDB. 
    /// 					Must start with a letter and can&#39;t end with a hyphen or contain two 
    /// 					consecutive hyphens. For example, my-user1. This username will allow 
    /// 					you to access the InfluxDB UI to perform various administrative tasks 
    /// 					and also use the InfluxDB CLI to create an operator token. These 
    /// 					attributes will be stored in a Secret created in Amazon Secrets 
    /// 					Manager in your account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSecurityGroupIds is required")]
    public required TerraformSet<string> VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least 
    /// 					two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    public required TerraformSet<string> VpcSubnetIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_subnet_ids");
        set => SetArgument("vpc_subnet_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret containing the 
    /// 					initial InfluxDB authorization parameters. The secret value is a JSON formatted 
    /// 					key-value pair holding InfluxDB authorization values: organization, bucket, 
    /// 					username, and password.
    /// </summary>
    public TerraformValue<string> InfluxAuthParametersSecretArn
        => AsReference("influx_auth_parameters_secret_arn");

    /// <summary>
    /// The endpoint used to connect to the Timestream for InfluxDB cluster for 
    /// 					read-only operations.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
        => AsReference("reader_endpoint");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// LogDeliveryConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlock>>("log_delivery_configuration");
        set => SetArgument("log_delivery_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsTimestreaminfluxdbDbClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsTimestreaminfluxdbDbClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
