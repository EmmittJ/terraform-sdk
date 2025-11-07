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
    public TerraformLiteralProperty<Dictionary<string, string>>? Arguments
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("arguments");
        set => this.WithProperty("arguments", value);
    }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExtraJarsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extra_jars_s3_path");
        set => this.WithProperty("extra_jars_s3_path", value);
    }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExtraPythonLibsS3Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extra_python_libs_s3_path");
        set => this.WithProperty("extra_python_libs_s3_path", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GlueVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("glue_version");
        set => this.WithProperty("glue_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NumberOfNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_nodes");
        set => this.WithProperty("number_of_nodes", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NumberOfWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_workers");
        set => this.WithProperty("number_of_workers", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key");
        set => this.WithProperty("public_key", value);
    }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PublicKeys
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("public_keys");
        set => this.WithProperty("public_keys", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_configuration");
        set => this.WithProperty("security_configuration", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("worker_type");
        set => this.WithProperty("worker_type", value);
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
