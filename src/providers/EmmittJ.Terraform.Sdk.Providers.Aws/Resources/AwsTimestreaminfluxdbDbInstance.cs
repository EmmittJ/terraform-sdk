using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_timestreaminfluxdb_db_instance resource.
/// </summary>
public class AwsTimestreaminfluxdbDbInstance : TerraformResource
{
    public AwsTimestreaminfluxdbDbInstance(string name) : base("aws_timestreaminfluxdb_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zone");
        SetOutput("endpoint");
        SetOutput("id");
        SetOutput("influx_auth_parameters_secret_arn");
        SetOutput("secondary_availability_zone");
        SetOutput("tags_all");
        SetOutput("allocated_storage");
        SetOutput("bucket");
        SetOutput("db_instance_type");
        SetOutput("db_parameter_group_identifier");
        SetOutput("db_storage_type");
        SetOutput("deployment_type");
        SetOutput("name");
        SetOutput("network_type");
        SetOutput("organization");
        SetOutput("password");
        SetOutput("port");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("username");
        SetOutput("vpc_security_group_ids");
        SetOutput("vpc_subnet_ids");
    }

    /// <summary>
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocatedStorage is required")]
    public required TerraformProperty<double> AllocatedStorage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("allocated_storage");
        set => SetProperty("allocated_storage", value);
    }

    /// <summary>
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. 
    /// 					A bucket combines the concept of a database and a retention period (the duration of time 
    /// 					that each data point persists). A bucket belongs to an organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceType is required")]
    public required TerraformProperty<string> DbInstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_instance_type");
        set => SetProperty("db_instance_type", value);
    }

    /// <summary>
    /// The id of the DB parameter group assigned to your DB instance.
    /// </summary>
    public TerraformProperty<string> DbParameterGroupIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_parameter_group_identifier");
        set => SetProperty("db_parameter_group_identifier", value);
    }

    /// <summary>
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data. 
    /// 					You can choose between 3 different types of provisioned Influx IOPS included storage according 
    /// 					to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, 
    /// 					Influx IO Included 16000 IOPS.
    /// </summary>
    public TerraformProperty<string> DbStorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_storage_type");
        set => SetProperty("db_storage_type", value);
    }

    /// <summary>
    /// Specifies whether the DB instance will be deployed as a standalone instance or 
    /// 					with a Multi-AZ standby for high availability.
    /// </summary>
    public TerraformProperty<string> DeploymentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_type");
        set => SetProperty("deployment_type", value);
    }

    /// <summary>
    /// The name that uniquely identifies the DB instance when interacting with the 
    /// 					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a 
    /// 					prefix included in the endpoint. DB instance names must be unique per customer 
    /// 					and per region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is 
    /// 					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate 
    /// 					over both IPv4 and IPv6 protocols.
    /// </summary>
    public TerraformProperty<string> NetworkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_type");
        set => SetProperty("network_type", value);
    }

    /// <summary>
    /// The name of the initial organization for the initial admin user in InfluxDB. An 
    /// 					InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformProperty<string> Organization
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization");
        set => SetProperty("organization", value);
    }

    /// <summary>
    /// The password of the initial admin user created in InfluxDB. This password will 
    /// 					allow you to access the InfluxDB UI to perform various administrative tasks and 
    /// 					also use the InfluxDB CLI to create an operator token. These attributes will be 
    /// 					stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Configures the DB instance with a public IP to facilitate access.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// A list of VPC security group IDs to associate with the DB instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// A list of VPC subnet IDs to associate with the DB instance. Provide at least 
    /// 					two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    public HashSet<TerraformProperty<string>> VpcSubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_subnet_ids");
        set => SetProperty("vpc_subnet_ids", value);
    }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock>? LogDeliveryConfiguration
    {
        set => SetProperty("log_delivery_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsTimestreaminfluxdbDbInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The Availability Zone in which the DB instance resides.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret containing the 
    /// 					initial InfluxDB authorization parameters. The secret value is a JSON formatted 
    /// 					key-value pair holding InfluxDB authorization values: organization, bucket, 
    /// 					username, and password.
    /// </summary>
    public TerraformExpression InfluxAuthParametersSecretArn => this["influx_auth_parameters_secret_arn"];

    /// <summary>
    /// The Availability Zone in which the standby instance is located when deploying 
    /// 					with a MultiAZ standby instance.
    /// </summary>
    public TerraformExpression SecondaryAvailabilityZone => this["secondary_availability_zone"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
