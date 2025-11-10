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
        SetOutput("arn");
        SetOutput("availability_zone");
        SetOutput("failure_reason");
        SetOutput("private_address");
        SetOutput("public_address");
        SetOutput("status");
        SetOutput("vpc_id");
        SetOutput("yarn_endpoint_address");
        SetOutput("zeppelin_remote_spark_interpreter_port");
        SetOutput("arguments");
        SetOutput("extra_jars_s3_path");
        SetOutput("extra_python_libs_s3_path");
        SetOutput("glue_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("number_of_nodes");
        SetOutput("number_of_workers");
        SetOutput("public_key");
        SetOutput("public_keys");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("security_configuration");
        SetOutput("security_group_ids");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("worker_type");
    }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Arguments
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("arguments");
        set => SetProperty("arguments", value);
    }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    public TerraformProperty<string> ExtraJarsS3Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extra_jars_s3_path");
        set => SetProperty("extra_jars_s3_path", value);
    }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    public TerraformProperty<string> ExtraPythonLibsS3Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extra_python_libs_s3_path");
        set => SetProperty("extra_python_libs_s3_path", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformProperty<string> GlueVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("glue_version");
        set => SetProperty("glue_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfNodes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_nodes");
        set => SetProperty("number_of_nodes", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfWorkers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_workers");
        set => SetProperty("number_of_workers", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformProperty<string> PublicKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_key");
        set => SetProperty("public_key", value);
    }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> PublicKeys
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("public_keys");
        set => SetProperty("public_keys", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string> SecurityConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_configuration");
        set => SetProperty("security_configuration", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformProperty<string> WorkerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("worker_type");
        set => SetProperty("worker_type", value);
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
