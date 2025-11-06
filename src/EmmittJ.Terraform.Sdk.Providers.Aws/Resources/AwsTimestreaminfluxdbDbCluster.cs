using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_timestreaminfluxdb_db_cluster resource.
/// </summary>
public class AwsTimestreaminfluxdbDbCluster : TerraformResource
{
    public AwsTimestreaminfluxdbDbCluster(string name) : base("aws_timestreaminfluxdb_db_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("id");
        this.DeclareOutput("influx_auth_parameters_secret_arn");
        this.DeclareOutput("reader_endpoint");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    public double? AllocatedStorage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocated_storage")?.Value;
        set => this.WithProperty("allocated_storage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. 
    /// 					A bucket combines the concept of a database and a retention period (the duration of time 
    /// 					that each data point persists). A bucket belongs to an organization.
    /// </summary>
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    public string? DbInstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_instance_type")?.Value;
        set => this.WithProperty("db_instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the DB parameter group to assign to your DB cluster. 
    /// 					DB parameter groups specify how the database is configured. For example, DB parameter groups 
    /// 					can specify the limit for query concurrency.
    /// </summary>
    public string? DbParameterGroupIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_parameter_group_identifier")?.Value;
        set => this.WithProperty("db_parameter_group_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data. 
    /// 					You can choose between 3 different types of provisioned Influx IOPS included storage according 
    /// 					to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, 
    /// 					Influx IO Included 16000 IOPS.
    /// </summary>
    public string? DbStorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_storage_type")?.Value;
        set => this.WithProperty("db_storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the type of cluster to create.
    /// </summary>
    public string? DeploymentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_type")?.Value;
        set => this.WithProperty("deployment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the behavior of failure recovery when the primary node of the cluster
    /// 					fails.
    /// </summary>
    public string? FailoverMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("failover_mode")?.Value;
        set => this.WithProperty("failover_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name that uniquely identifies the DB cluster when interacting with the 
    /// 					Amazon Timestream for InfluxDB API and CLI commands. This name will also be a 
    /// 					prefix included in the endpoint. DB cluster names must be unique per customer 
    /// 					and per region.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB cluster is 
    /// 					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate 
    /// 					over both IPv4 and IPv6 protocols.
    /// </summary>
    public string? NetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_type")?.Value;
        set => this.WithProperty("network_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the initial organization for the initial admin user in InfluxDB. An 
    /// 					InfluxDB organization is a workspace for a group of users.
    /// </summary>
    public string? Organization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization")?.Value;
        set => this.WithProperty("organization", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password of the initial admin user created in InfluxDB. This password will 
    /// 					allow you to access the InfluxDB UI to perform various administrative tasks and 
    /// 					also use the InfluxDB CLI to create an operator token. These attributes will be 
    /// 					stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least 
    /// 					two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    public HashSet<string>? VpcSubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_subnet_ids")?.Value;
        set => this.WithProperty("vpc_subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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
    /// The endpoint used to connect to the Timestream for InfluxDB cluster for 
    /// 					read-only operations.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
