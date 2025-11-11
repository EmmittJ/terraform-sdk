using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsTimestreaminfluxdbDbClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_timestreaminfluxdb_db_cluster resource.
/// </summary>
public partial class AwsTimestreaminfluxdbDbCluster : TerraformResource
{
    public AwsTimestreaminfluxdbDbCluster(string name) : base("aws_timestreaminfluxdb_db_cluster", name)
    {
    }

    /// <summary>
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocatedStorage is required")]
    [TerraformProperty("allocated_storage")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> AllocatedStorage { get; set; }

    /// <summary>
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. 
    /// 					A bucket combines the concept of a database and a retention period (the duration of time 
    /// 					that each data point persists). A bucket belongs to an organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceType is required")]
    [TerraformProperty("db_instance_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DbInstanceType { get; set; }

    /// <summary>
    /// The ID of the DB parameter group to assign to your DB cluster. 
    /// 					DB parameter groups specify how the database is configured. For example, DB parameter groups 
    /// 					can specify the limit for query concurrency.
    /// </summary>
    [TerraformProperty("db_parameter_group_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data. 
    /// 					You can choose between 3 different types of provisioned Influx IOPS included storage according 
    /// 					to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, 
    /// 					Influx IO Included 16000 IOPS.
    /// </summary>
    [TerraformProperty("db_storage_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DbStorageType { get; set; }

    /// <summary>
    /// Specifies the type of cluster to create.
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DeploymentType { get; set; }

    /// <summary>
    /// Specifies the behavior of failure recovery when the primary node of the cluster
    /// 					fails.
    /// </summary>
    [TerraformProperty("failover_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FailoverMode { get; set; }

    /// <summary>
    /// The name that uniquely identifies the DB cluster when interacting with the 
    /// 					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a 
    /// 					prefix included in the endpoint. DB cluster names must be unique per customer 
    /// 					and per region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB cluster is 
    /// 					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate 
    /// 					over both IPv4 and IPv6 protocols.
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkType { get; set; }

    /// <summary>
    /// The name of the initial organization for the initial admin user in InfluxDB. An 
    /// 					InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// The password of the initial admin user created in InfluxDB. This password will 
    /// 					allow you to access the InfluxDB UI to perform various administrative tasks and 
    /// 					also use the InfluxDB CLI to create an operator token. These attributes will be 
    /// 					stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Port { get; set; }

    /// <summary>
    /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

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
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

    /// <summary>
    /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSecurityGroupIds is required")]
    [TerraformProperty("vpc_security_group_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least 
    /// 					two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    [TerraformProperty("vpc_subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> VpcSubnetIds { get; set; }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("log_delivery_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreaminfluxdbDbClusterLogDeliveryConfigurationBlock>>? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsTimestreaminfluxdbDbClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret containing the 
    /// 					initial InfluxDB authorization parameters. The secret value is a JSON formatted 
    /// 					key-value pair holding InfluxDB authorization values: organization, bucket, 
    /// 					username, and password.
    /// </summary>
    [TerraformProperty("influx_auth_parameters_secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InfluxAuthParametersSecretArn { get; }

    /// <summary>
    /// The endpoint used to connect to the Timestream for InfluxDB cluster for 
    /// 					read-only operations.
    /// </summary>
    [TerraformProperty("reader_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReaderEndpoint { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
