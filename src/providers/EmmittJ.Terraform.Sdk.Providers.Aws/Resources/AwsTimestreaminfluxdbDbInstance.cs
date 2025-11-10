using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_delivery_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTimestreaminfluxdbDbInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_timestreaminfluxdb_db_instance resource.
/// </summary>
public class AwsTimestreaminfluxdbDbInstance : TerraformResource
{
    public AwsTimestreaminfluxdbDbInstance(string name) : base("aws_timestreaminfluxdb_db_instance", name)
    {
    }

    /// <summary>
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocatedStorage is required")]
    [TerraformPropertyName("allocated_storage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> AllocatedStorage { get; set; }

    /// <summary>
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. 
    /// 					A bucket combines the concept of a database and a retention period (the duration of time 
    /// 					that each data point persists). A bucket belongs to an organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceType is required")]
    [TerraformPropertyName("db_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DbInstanceType { get; set; }

    /// <summary>
    /// The id of the DB parameter group assigned to your DB instance.
    /// </summary>
    [TerraformPropertyName("db_parameter_group_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data. 
    /// 					You can choose between 3 different types of provisioned Influx IOPS included storage according 
    /// 					to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, 
    /// 					Influx IO Included 16000 IOPS.
    /// </summary>
    [TerraformPropertyName("db_storage_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbStorageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_storage_type");

    /// <summary>
    /// Specifies whether the DB instance will be deployed as a standalone instance or 
    /// 					with a Multi-AZ standby for high availability.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeploymentType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_type");

    /// <summary>
    /// The name that uniquely identifies the DB instance when interacting with the 
    /// 					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a 
    /// 					prefix included in the endpoint. DB instance names must be unique per customer 
    /// 					and per region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is 
    /// 					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate 
    /// 					over both IPv4 and IPv6 protocols.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The name of the initial organization for the initial admin user in InfluxDB. An 
    /// 					InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformPropertyName("organization")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Organization { get; set; }

    /// <summary>
    /// The password of the initial admin user created in InfluxDB. This password will 
    /// 					allow you to access the InfluxDB UI to perform various administrative tasks and 
    /// 					also use the InfluxDB CLI to create an operator token. These attributes will be 
    /// 					stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Port { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// Configures the DB instance with a public IP to facilitate access.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

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
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

    /// <summary>
    /// A list of VPC security group IDs to associate with the DB instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSecurityGroupIds is required")]
    [TerraformPropertyName("vpc_security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// A list of VPC subnet IDs to associate with the DB instance. Provide at least 
    /// 					two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    [TerraformPropertyName("vpc_subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? VpcSubnetIds { get; set; }

    /// <summary>
    /// Block for log_delivery_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("log_delivery_configuration")]
    public TerraformList<TerraformBlock<AwsTimestreaminfluxdbDbInstanceLogDeliveryConfigurationBlock>>? LogDeliveryConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsTimestreaminfluxdbDbInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The Availability Zone in which the DB instance resides.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret containing the 
    /// 					initial InfluxDB authorization parameters. The secret value is a JSON formatted 
    /// 					key-value pair holding InfluxDB authorization values: organization, bucket, 
    /// 					username, and password.
    /// </summary>
    [TerraformPropertyName("influx_auth_parameters_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InfluxAuthParametersSecretArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "influx_auth_parameters_secret_arn");

    /// <summary>
    /// The Availability Zone in which the standby instance is located when deploying 
    /// 					with a MultiAZ standby instance.
    /// </summary>
    [TerraformPropertyName("secondary_availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_availability_zone");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
