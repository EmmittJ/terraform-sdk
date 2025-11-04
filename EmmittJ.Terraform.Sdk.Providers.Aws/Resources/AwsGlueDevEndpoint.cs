using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_dev_endpoint resource.
/// </summary>
public class AwsGlueDevEndpoint : TerraformResource
{
    public AwsGlueDevEndpoint(string name) : base("aws_glue_dev_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("failure_reason");
        this.DeclareOutput("private_address");
        this.DeclareOutput("public_address");
        this.DeclareOutput("status");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("yarn_endpoint_address");
        this.DeclareOutput("zeppelin_remote_spark_interpreter_port");
    }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public Dictionary<string, string>? Arguments
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("arguments")?.Value;
        set => this.WithProperty("arguments", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    public string? ExtraJarsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extra_jars_s3_path")?.Value;
        set => this.WithProperty("extra_jars_s3_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    public string? ExtraPythonLibsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extra_python_libs_s3_path")?.Value;
        set => this.WithProperty("extra_python_libs_s3_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public string? GlueVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("glue_version")?.Value;
        set => this.WithProperty("glue_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public double? NumberOfNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_nodes")?.Value;
        set => this.WithProperty("number_of_nodes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public double? NumberOfWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_workers")?.Value;
        set => this.WithProperty("number_of_workers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public string? PublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key")?.Value;
        set => this.WithProperty("public_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    public HashSet<string>? PublicKeys
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("public_keys")?.Value;
        set => this.WithProperty("public_keys", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public string? SecurityConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_configuration")?.Value;
        set => this.WithProperty("security_configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public string? WorkerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("worker_type")?.Value;
        set => this.WithProperty("worker_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformExpression FailureReason => this["failure_reason"];

    /// <summary>
    /// The private_address attribute.
    /// </summary>
    public TerraformExpression PrivateAddress => this["private_address"];

    /// <summary>
    /// The public_address attribute.
    /// </summary>
    public TerraformExpression PublicAddress => this["public_address"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The yarn_endpoint_address attribute.
    /// </summary>
    public TerraformExpression YarnEndpointAddress => this["yarn_endpoint_address"];

    /// <summary>
    /// The zeppelin_remote_spark_interpreter_port attribute.
    /// </summary>
    public TerraformExpression ZeppelinRemoteSparkInterpreterPort => this["zeppelin_remote_spark_interpreter_port"];

}
