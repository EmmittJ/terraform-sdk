using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in AwsTimestreaminfluxdbDbInstance.
/// Nesting mode: list
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_delivery_configuration";

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlockS3ConfigurationBlock : TerraformBlock
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
/// Block type for timeouts in AwsTimestreaminfluxdbDbInstance.
/// Nesting mode: single
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_timestreaminfluxdb_db_instance Terraform resource.
/// Manages a aws_timestreaminfluxdb_db_instance resource.
/// </summary>
public partial class AwsTimestreaminfluxdbDbInstance(string name) : TerraformResource("aws_timestreaminfluxdb_db_instance", name)
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
    /// The id of the DB parameter group assigned to your DB instance.
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
    /// Specifies whether the DB instance will be deployed as a standalone instance or 
    /// 					with a Multi-AZ standby for high availability.
    /// </summary>
    public TerraformValue<string>? DeploymentType
    {
        get => GetArgument<TerraformValue<string>>("deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The name that uniquely identifies the DB instance when interacting with the 
    /// 					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a 
    /// 					prefix included in the endpoint. DB instance names must be unique per customer 
    /// 					and per region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is 
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
    /// Configures the DB instance with a public IP to facilitate access.
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
    /// 					Manager in your account
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// A list of VPC security group IDs to associate with the DB instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSecurityGroupIds is required")]
    public required TerraformSet<string> VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// A list of VPC subnet IDs to associate with the DB instance. Provide at least 
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
    /// The Availability Zone in which the DB instance resides.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

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
    /// The Availability Zone in which the standby instance is located when deploying 
    /// 					with a MultiAZ standby instance.
    /// </summary>
    public TerraformValue<string> SecondaryAvailabilityZone
        => AsReference("secondary_availability_zone");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// LogDeliveryConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        get => GetArgument<TerraformList<AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock>>("log_delivery_configuration");
        set => SetArgument("log_delivery_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsTimestreaminfluxdbDbInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsTimestreaminfluxdbDbInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
